# DatabaseProject
Proyecto sobre Bases de Datos en donde consigo agregar, eliminar y modificar productos de una tabla usando Windows Forms y C#

Al comenzar puedo logearme a una cuenta creada anteriormente que se encuentre en la base de datos. Si no tengo cuenta puedo crearme una. Esta misma se guarda en la base de datos y puede ser accedida en el Login de la aplicación.

Una vez logeado el usuario se encuentra con una tabla de productos cargados desde la base de datos donde aparece el nombre, precio, tag y vencimiento del producto. 

Dentro de esta aplicación se encuentran 4 botones:

- Add:  crea una ventana donde te deja agregar un producto con sus datos.

- Delete: al seleccionar una celda de la tabla, apretando este botón lo que hará será eliminar de la base de datos ese producto completo. Luego actualizará la tabla.

- Refresh: este botón refresca la tabla para mostrar la tabla por default.

- Apply: este botón aplica los cambios que se le hizo a un producto.

Uso un DataGridView para cargar los datos de una tabla en una base de datos creada en MySQL Management Studio.
