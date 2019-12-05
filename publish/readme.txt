############### EVALUADOR DE EXPRESIONES CON WINDOWS FORMS Y C# #########################

Para poder ejecutar el programa, debera tener instaldo .Net Framework 4.2 o superior.
Ejecute el setup.exe para instalar el programa.

####################### MODO DE USO ############################################ 

La interfaz es muy sencilla.
Para evaluar una expresion, solo ingresa la expresion en caso en el primer cuadro de texto con el 
placeholder "Expression...", puede contener cualquier letra, mayusculas o minusculas, pero solo de un caracter.

Si su expresion no contiene variables, puede proceder a evaluar la expresion dando click en el boton "Evaluate",
o en caso de estar en la caja de texto de la expresion, puede presionar enter.

Si su expresion si contiene variables, entonces no podra evaluarla hasta que haya ingresado las variables que 
ingreso en la expresion.

Ejemplo:

Para la expresion: x ^ 2 + y

Debe ingresar en el campo de variables, las variables con su valor separadas por coma. 

Ejemplo campo variables:

x = 10, y = -3

Ahora si puede proceder a presionar el boton de "Evaluate" para conseguir un resultado, que sera mostrado
despues del signo '=' que esta debajo del cuadro de texto de las expresiones.