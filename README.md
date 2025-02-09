#Prerequisitos
- Tener instalado .NET 9.0
- Tener instalado node.js


1. Hace fork del repositorio
2. Abrir 2 instancias de Visual Studio Code

# Preparar proyecto web api para
1. Abrir CMD y navegar hasta el directorio de la web api ../back-end/alumnos
2. Escribir el comando code . para abrir VSCode
3. Asegurarse que los siguientes paquetes Nuget estén instalados en la aplicación o instalarlos desde la terminal dentro del proyecto de VSCode

dotnet add package Microsoft.AspNetCore.Cors --version 2.3.0
dotnet add package Microsoft.AspNetCore.OpenApi --version 8.0.12
dotnet add package Microsoft.EntityFrameworkCore --version 9.0.1
dotnet add package Microsoft.EntityFrameworkCore.InMemory --version 9.0.1
dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 9.0.1
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 9.0.1
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 9.0.1
dotnet add package AspNetCore.Authentication.Basic --version 9.0.0
dotnet add package AutoMapper --version 13.0.1

4. Ejecutar el comando dotnet build para compilar el proyecto y asegurarse que no hayan errores
5. Si no hay errores ejecutar dotnet run para que la aplicación esté disponible para consumo
6. La ejecución mostrará la dirección https que está siendo usada en el localhost para desplegar la api, copiar esa dirección para posibles ajustes en la aplicación react

# Preparar proyecto react para consumo de api
1. Abrir CMD y navegar hasta el directorio de la web api ../front-end/alumnos
2. Escribir el comando code . para abrir VSCode
3. Asegurarse que esté instalado React Route Dom, si no, instalarlo desde la terminal ejecutando npm install react-router-dom
4. abrir el archivo services/api.js
5. asegurarse que la dirección en la asignación de la constante  API_URL sea igual a la que se determinó en el el paso final de la aplicación web


