# README ANGULAR Y .NET
PROYECTO BACKEND. (PERTENECIENTE A UN PROYECTO FULLSTACK)


# DESARROLLADOR
* David Herrera Bermúdez
* Celular: +57 3104907577
* Correo: herrera17david@gmail.com


## TEMATICA
CRUD de tarjetas credito/debito

## Tecnologias a implementar
* .Net 7
* Entity Framework
* Swagger


##  DATOS IMPORTANTES:
* CORS: Se agregó "Cors" al  para poder realizar el trafico de consultas que necesita el "Front" 


# Proceso y Anotaciones
### Proceso

* ADMINISTRACION de paquetes NUGGETS general, para todo el proyecto
* Entity framework: para crear la BDD
* Entity framework Tools: para hacer las migraciones y actualizaciones a la BDD
* PARA SqlServer.
* Entity framework SqlServer:

* Crear carpeta Controller y Crear controllador Api, lectura y escritura
* Crear carpeta Models y Crear sus atributor siempre con require, de ahi parte el modelo a crear
* Crear una clase par aAplicationDBContext a nivel de proyecto. Heredarle DbContext: crea instancia en la BDD, para poder almacenar datos, hacer las Querys
* crear la BDD a partir del Modelo...
* Establecer cadena de conexion: "Server=DAVIDHB\\SQLEXPRESS;Database=TarjetasCreditoDB;Trusted_Connection=True;MultipleActiveResultSets=True;"
* Hacer la migracion desdela consola Administrador de paquetes.
 * Comando 1: Add-Migration "nombreMigracion"
* Comando 2: Update-Database (Recordar SSL)

### Anotaciones
* Cuando no se cree la base de datos a travez de la consola Administracion de paquetes:
* Deshabilitar SSL Si estás trabajando en un entorno de desarrollo y no necesitas una conexión SSL, puedes deshabilitarla en tu cadena de conexión añadiendo "TrustServerCertificate=True".
* "DevConnection": "Server=DAVIDHB\\SQLEXPRESS;Database=TarjetasCreditoDB;Trusted_Connection=true;MultipleActiveResultSets=True;TrustServerCertificate=True;"
* AGREGAR CORS PARA PERMITIR LAS CONSULTAS DEL FRONT
