# CRUD-.NET
CRUD realizado con .NET Framework 4.8 el cual cuenta con las siguientes capas

1. Presentacion: El cual consume una API desarrollada en la capa de servicio tambien con .NET framwork
2. Datos: Capa de acceso a BD, se utiliza como motor de base de datos SQL Lite el cual permite realizar administracion mediante el siguiente programa https://sqlitebrowser.org/dl/
3. Negocio:: Capa encargada deenlazar la capa de servicio con la capa datos
4. Servicio: Capa que contiene el proyecto de API la cual se encuentra documentada con un Nuget de SWAGGER.
5. Transversales.

Aplicativo WEB
   ![image](https://user-images.githubusercontent.com/58193833/215146556-9e0c6cad-74b5-40ea-9c97-267088a4f7e1.png)
API
   ![image](https://user-images.githubusercontent.com/58193833/215146713-8705b1e4-5fab-43ae-8a1c-87ea9e0c7478.png)

 6. Al descargar el proeycto configurar la cadena de conexion a la base de datos en el proyecto de API en el archivo Web.config


