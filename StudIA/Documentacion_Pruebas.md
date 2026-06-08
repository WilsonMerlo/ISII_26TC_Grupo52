# Documentación de Servicios y Plan de Pruebas - StudIA

Este documento detalla las especificaciones técnicas de los principales servicios de la capa de negocio (Business) y los casos de prueba unitaria implementados para la validación del sistema, siguiendo los estándares de la industria (XML Docs y Patrón AAA para QA).

---

## PARTE 1: Documentación de Código (XML Comments de C#)

A continuación, se presentan las directivas de documentación recomendadas para los métodos principales de los servicios testeados.

### ApunteService

```csharp
/// <summary>
/// Crea un nuevo apunte en la base de datos asociado a una materia específica.
/// Si el título proporcionado es nulo o está vacío, se le asigna automáticamente "Sin título" o un correlativo si este ya existe.
/// </summary>
/// <param name="apunte">La entidad Apunte que contiene los datos base como IdMateria, Título y Contenido.</param>
/// <returns>Retorna el objeto <see cref="Apunte"/> creado con las fechas de auditoría y título definitivos asignados.</returns>
public async Task<Apunte> CrearApunteAsync(Apunte apunte)
```

```csharp
/// <summary>
/// Elimina un apunte de la base de datos de manera lógica/física desvinculando previamente los Pomodoros asociados.
/// </summary>
/// <param name="id">El identificador único del Apunte a eliminar.</param>
/// <returns>Retorna <c>true</c> si el apunte se encontró y eliminó exitosamente; de lo contrario, retorna <c>false</c>.</returns>
/// <exception cref="Exception">Lanza excepción y revierte la transacción si ocurre un fallo al desvincular o eliminar.</exception>
public async Task<bool> EliminarApunteAsync(int id)
```

### MateriaService

```csharp
/// <summary>
/// Crea una nueva materia para un usuario validando que el nombre no esté duplicado.
/// Si el nombre ya existe para ese usuario, agrega un sufijo numérico secuencial (ej. "Nombre (2)").
/// </summary>
/// <param name="materia">La entidad Materia con el IdUsuario correspondiente y el Nombre deseado.</param>
/// <returns>Retorna la <see cref="Materia"/> recién creada y almacenada en el contexto de la base de datos.</returns>
public async Task<Materia> CrearMateriaAsync(Materia materia)
```

### ProgresoService

```csharp
/// <summary>
/// Actualiza el progreso de un usuario en una materia sumando la cantidad de segundos estudiados. 
/// Si no existe un registro previo de progreso para la combinación Usuario/Materia, crea uno nuevo.
/// </summary>
/// <param name="idUsuario">El identificador del usuario que realizó la sesión de estudio.</param>
/// <param name="idMateria">El identificador de la materia estudiada.</param>
/// <param name="segundosAcumulados">La cantidad de segundos a incrementar en el registro actual.</param>
/// <returns>El registro <see cref="Progreso"/> actualizado o recién creado.</returns>
public async Task<Progreso> ActualizarProgresoAsync(int idUsuario, int idMateria, int segundosAcumulados)
```

### PomodoroService

```csharp
/// <summary>
/// Registra una nueva sesión de Pomodoro en la base de datos asociada a un Usuario, y opcionalmente a una Materia y un Apunte.
/// </summary>
/// <param name="pomodoro">Objeto de la entidad Pomodoro a almacenar.</param>
/// <returns>Retorna el <see cref="Pomodoro"/> recién insertado con su nuevo ID generado.</returns>
/// <exception cref="DbUpdateException">Lanzada por Entity Framework Core si el <c>IdMateria</c> o <c>IdUsuario</c> referenciado no existe en la base de datos (Violación de Foreign Key).</exception>
public async Task<Pomodoro> CrearPomodoroAsync(Pomodoro pomodoro)
```

---

## PARTE 2: Documentación de Casos de Prueba (Test Plan)

Los siguientes casos de prueba han sido implementados utilizando **xUnit** y **Moq**, aplicando el patrón **AAA (Arrange, Act, Assert)** para garantizar la calidad del software en aislamiento.

### Módulo: ApunteService

| ID del Test | TC-APU-001 |
| :--- | :--- |
| **Descripción** | Validar la creación de un apunte cuando se provee un título nulo o vacío. |
| **Precondiciones (Arrange)** | - Instanciar Mock de `StudIAContext`.<br>- Crear un MockDbSet usando `MockQueryable.Moq` para la tabla `Apuntes`. |
| **Pasos de Ejecución (Act)** | - Se invoca `CrearApunteAsync` pasando un objeto `Apunte` donde `Titulo = null` o vacío. |
| **Resultado Esperado (Assert)** | - El sistema asigna automáticamente la cadena "Sin título" (o su correlativo) al objeto.<br>- El método `SaveChangesAsync` es llamado exactamente 1 vez. |

| ID del Test | TC-APU-002 |
| :--- | :--- |
| **Descripción** | Validar el intento de eliminación de un apunte que no existe en el sistema. |
| **Precondiciones (Arrange)** | - Instanciar Mock de `StudIAContext` y MockDbSet de `Apuntes`.<br>- Configurar el método `FindAsync` del Mock para que devuelva `null` independientemente de los argumentos provistos. |
| **Pasos de Ejecución (Act)** | - Se invoca `EliminarApunteAsync` pasando un `id` ficticio (ej. 999). |
| **Resultado Esperado (Assert)** | - El método finaliza inmediatamente y retorna el valor booleano `false`. |

### Módulo: MateriaService

| ID del Test | TC-MAT-001 |
| :--- | :--- |
| **Descripción** | Validar que se puedan obtener todas las materias asociadas a un Usuario específico. |
| **Precondiciones (Arrange)** | - Mock de `StudIAContext`.<br>- MockDbSet inyectado con 3 materias (2 pertenecen al IdUsuario 1 y 1 pertenece al IdUsuario 2). |
| **Pasos de Ejecución (Act)** | - Se invoca `ObtenerMateriasPorUsuarioAsync` solicitando las materias del Usuario `1`. |
| **Resultado Esperado (Assert)** | - El sistema devuelve una lista con exactamente 2 elementos.<br>- Se verifica que todas las materias devueltas pertenezcan al `IdUsuario` igual a `1`. |

| ID del Test | TC-MAT-002 |
| :--- | :--- |
| **Descripción** | Validar la correcta creación de una Materia. |
| **Precondiciones (Arrange)** | - Mock de `StudIAContext` inicializado con una lista de Materias vacía. |
| **Pasos de Ejecución (Act)** | - Se invoca `CrearMateriaAsync` con un objeto que tiene `NombreMateria = "Nueva Materia"`. |
| **Resultado Esperado (Assert)** | - Retorna el objeto materia sin alteraciones en su título.<br>- El método `Add` de `DbSet` se invoca exactamente 1 vez. |

### Módulo: ProgresoService

| ID del Test | TC-PRO-001 |
| :--- | :--- |
| **Descripción** | Validar la actualización y suma correcta de segundos estudiados sobre un progreso preexistente. |
| **Precondiciones (Arrange)** | - MockDbSet inicializado con un registro que indica `SegundosAcumulados = 1000` para un Usuario X y Materia Y. |
| **Pasos de Ejecución (Act)** | - Se invoca `ActualizarProgresoAsync` sumándole `500` segundos a ese mismo Usuario y Materia. |
| **Resultado Esperado (Assert)** | - El objeto retornado no es nulo.<br>- La propiedad `SegundosAcumulados` tiene el valor total exacto de `1500`. |

### Módulo: PomodoroService

| ID del Test | TC-POM-001 |
| :--- | :--- |
| **Descripción** | Validar el rechazo por parte de la base de datos cuando se intenta asociar un Pomodoro a una Materia inexistente. |
| **Precondiciones (Arrange)** | - Se configura el Mock de `StudIAContext` para que su método `SaveChangesAsync` lance explícitamente un error `DbUpdateException` emulando la restricción restrictiva/cascade de EF Core por violación de clave foránea. |
| **Pasos de Ejecución (Act)** | - Se invoca `CrearPomodoroAsync` con un objeto cuyo `IdMateria = 999`. |
| **Resultado Esperado (Assert)** | - El servicio debe lanzar y propagar hacia arriba la excepción `DbUpdateException`. |
