# Proyecto de Gestión de Reservas

## Descripción

Este proyecto es un sistema de gestión de reservas desarrollado con .NET Framework 4.8. Utiliza Dapper como ORM para interactuar con una base de datos SQL Server y cuenta con una interfaz web funcional que integra CSHTML (Razor), JavaScript y CSS.

## Requisitos

- .NET Framework 4.8
- SQL Server

## Configuración de la Base de Datos

El proyecto incluye un proyecto de tipo SQL en la solución. Para generar la base de datos de forma local, siguir estos pasos:

1. Abrir la solución en Visual Studio.
2. Ve al proyecto de tipo SQL.
3. Haz clic derecho en el proyecto y selecciona `Publish`.
4. Sigue las instrucciones para publicar la base de datos en tu instancia local de SQL Server.

Una vez que la base de datos se haya generado, estarás listo para ejecutar el proyecto.

## Ejecución del Proyecto

1. Asegurar de que la base de datos se haya generado correctamente siguiendo los pasos anteriores.
2. Configura la cadena de conexión en el archivo  `web.config` del proyecto principal para que apunte a tu instancia local de SQL Server.
3. Compila y ejecuta el proyecto desde Visual Studio.


## Solución de Problemas

- **Error de conexión a la base de datos**: Asegúrate de que la cadena de conexión esté configurada correctamente y que tu instancia de SQL Server esté en ejecución.

---

¡Gracias por revisar este proyecto!
