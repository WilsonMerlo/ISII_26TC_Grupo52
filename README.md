Guía de Instalación Rápida - StudIA (Entorno de Desarrollo)
Requisitos Previos

Git

.NET 8 SDK

Node.js (LTS) y npm

SQL Server (LocalDB o Express) en ejecución

1. Clonar el Repositorio

Bash
git clone <URL_DEL_REPOSITORIO>
cd <NOMBRE_CARPETA>
2. Despliegue del Backend (.NET 8) y Base de Datos
Abrir una terminal, navegar a la carpeta de la API y aplicar migraciones para generar la base de datos:

Bash
cd StudIA.API
dotnet tool install --global dotnet-ef
dotnet ef database update
Levantar el servidor web:

Bash
dotnet run
Requisito: Anotar la URL de escucha que muestra la consola (ej. http://localhost:5057 o https://localhost:7068).

3. Despliegue del Frontend (React/Vite)
Abrir una nueva terminal y navegar a la carpeta del frontend:

Bash
cd studia-frontend
Crear el archivo de entorno .env.local en la raíz de esta carpeta y enlazarlo a la API:

Fragmento de código
VITE_API_URL=<URL_DEL_BACKEND>/api
(Reemplazar <URL_DEL_BACKEND> con la ruta obtenida en el paso 2).

Instalar paquetes (con flag legacy por compatibilidad de react-quill) e iniciar el cliente:

Bash
npm install --legacy-peer-deps
npm run dev
4. Ejecución
Ingresar desde el navegador a http://localhost:5173. Para testear, crear un usuario nuevo desde la vista de Registro o utilizar credenciales previamente inyectadas en la base de datos local.
