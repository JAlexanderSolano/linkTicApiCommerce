Pasos para correr el programa 

Paso 1 // Configurar el archivo appsettings.json 
cambiear el valor en la llave hostUrl por la conexion a la base de datos indicada
Recordar que previamente a este paso se debe restaurar el backup de la base de datos
en SQL Server, SSMS (Manejador de SQL Server) 
----------> Link en donde estara el backup de la base de datos subida ----> https://mega.nz/file/REsSAJLC#-u_7Ukwi49XJg-c5xB2FlBANaONVtMMYS_UTMGBAkQE
----------> En caso de no poder restaurar el backup se dejara un link con el script para su posterior descarga ----> https://mega.nz/file/FIMAnabI#_cMHo1DcNL7HsLF__P6diFpjeOHDViRLmoQkfA1FkDI

En dicho script esta el paso paso para crear tanto las tablas como los procedimientos almacenados que se encuentran previamente 
programados.

La cadena de conexion a cambiar en el archivo es la siguiente: 
"Settings": {
    "hostUrl": "Data Source=tu host de base de datos\\SQLEXPRESS;Initial Catalog=linkTicPrueba;User ID=Usuario puede ser el sa;Password=contraseña de tu usuario sa"
  }

NOTA:
Initial Catalog = Nombre de base de datos este no se toca
Data Source = Host de conexion local de tu base de datos en SQL Server
ID = Usuario con el que te conectas a tu servidor de base de datos SQL Server
Password = Contraseña del usuario de tu servidor de SQL Server

Paso 2 // Ejecutar el proyecto y 
Abrir Postman o Si lo desean pueden ejecutrar el proyecto y utilizar swagger para probar el mismo o visualizar la documentacion de la API
el proyecto por defecto se ejecuta en la siguiente url: https://localhost:7026/
si desean ejecutar swagger pueden copiar la url de la siguiente manera: https://localhost:7026/swagger.


En caso de que deseen utilizar Postman para ejecutar pruebas, pueden realizarlo de la siguiente forma:
1 Ejecutan el proyecto en Visual Studio
2 Desde su navegador de preferencia utilizan el siguiente link https://elements.getpostman.com/redirect?entityId=14027288-354ff31b-0828-439e-ac5a-1df2113a6b26&entityType=collection
3 Ejecutan los metodos que desan utilizar ya sea para registrar el cliente, listar pedidos, listar productos, generar una compra ect..
y cambian los valores de acuerdo a lo que se encuentra en cada JSON.



