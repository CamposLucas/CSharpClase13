# CSharpClase12

El ejercicio consta de dos escenarios:

1) Dado un formulario de alta de usuario:
 
   Cargar el usuario en un txt separado por comma, y en una tabla sql.
   si llegare a fallar el archivo txt separado por comma: se cae la operacion.
   si llegare a fallar la insercion en sql, se sigue operando.


2) Si el SQL esta saturado, es decir, que en el ultimo, segundo se utilizo la 
   conexion ? no se intenta dar de alta el usuario, y solo se agrega en el txt.

Para ambos casos el txt es prioritario y mandatorio, y el sql es secundario.


