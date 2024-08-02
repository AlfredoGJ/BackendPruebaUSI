# Prueba 1 Backend

## Dependencias
* Visual Studio 2022
* .Net Core 7
* Entity Framework Core 7
* Npgsql for entity framework Core 7
* PostgreSQL 16

## Forma de usar

* 1 Instalar Postgres
     * Descargar el instalador para windows desde https://www.postgresql.org/download/ e instalar el gestor de bases de datos
* 2 Abrir solucion en Visual Studio
  * Clonar este repositorio en su equipo local
  * Abrir la solucion con visual studio
* 3 Instalar paquetes
    * Instalar o actualizar los siguientes oaquetes con el gestor de paquetes NuGet: ![image](https://github.com/user-attachments/assets/50d5964b-269d-42d3-97fe-25c3e9a605b2)

* 4 Configurar la base de datos
    * Configurar la cadena de conexion en el archivo `appSettings.json`, el `Host` puede ser localhost y `Database` puede contener cualquier valor. Los campos `Username` y `Password` dependen de la configuracion utilizada al instalar el gestor de bases de datos de Postges
    * Correr el comando `Update-Database` en la consola del administrador de paquetes de visual studio. Este comando detectara las migraciones pendientes por aplicar y las aplicara a la base de datos ( si es que existe), si la base de datos no existe creara una con el nombre especificado en el archivo `appsettings.json`. Si el comando no crea la base de datos se puede forzar la aplicacion de una migracion mediante el comando `Update-Database {Nombre de la ultima migracion}`. Si la migracion se aplica correctamente la base de datos sera llenada con datos iniciales para comenzar a usar la API en las tablas de `Entidades Federativas`, `Grados de Estudios`, `Puestos de Trabajo`, `Tipos de Empleados`
* 5 Correr la API
    * Si se desea, cambiar el puerto en el que se desea que reciba peticiones la API en el archivo de configuracion `appsSettings.json`
    * Correr el proyecto en visual studio: Se abrira una ventana en el navegador con la especificacion de OpenAPI para poder probar los endpoints de manera sencilla.
