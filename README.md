# PracticaDelegado.1
CalculadoraDelegados
Explicación del problema
El objetivo de esta práctica es construir una calculadora en consola que ejecute operaciones matemáticas (sumar, restar, multiplicar, dividir) de forma dinámica, sin usar if o switch para decidir qué operación ejecutar. En lugar de eso, se usan delegados para asignar y llamar al método correcto en tiempo de ejecución.

¿Qué es un delegado?
Un delegado en C# es un tipo que representa una referencia a un método. Funciona como una variable, pero en vez de guardar un número o texto, guarda un método. Esto permite que puedas pasar métodos como parámetros, guardarlos en colecciones, o decidir cuál ejecutar en tiempo de ejecución.
En este proyecto se definió así:
csharppublic delegate int OperacionMatematica(int a, int b);
Eso significa: "cualquier método que reciba dos enteros y devuelva un entero puede ser asignado a este delegado".

¿Por qué usar delegados en vez de llamar métodos directamente?
Cuando llamas un método directamente, el código queda fijo: siempre llama al mismo método sin posibilidad de cambiarlo en ejecución. Con delegados, puedes decidir en tiempo de ejecución qué método ejecutar, sin modificar la lógica central del programa.
En esta calculadora, si el usuario elige la opción "3", el delegado apunta automáticamente a Multiplicar. Si mañana quisieras agregar Potencia o Módulo, solo agregas el método y lo registras en el diccionario — sin tocar el resto del código. Eso hace el sistema más flexible y escalable.

Cómo se implementaron los delegados (pasos)

Se definió el delegado OperacionMatematica dentro de la clase Calculadora, especificando la firma que deben tener los métodos compatibles.
Se crearon los métodos Sumar, Restar, Multiplicar y Dividir, todos con la misma firma (int a, int b) => int.
Se usó un Dictionary<string, OperacionMatematica> para mapear cada opción del menú ("1", "2", etc.) al método correspondiente, cargado al inicializar la clase.
El método ObtenerOperacion() recibe la opción del usuario y devuelve el delegado correspondiente usando TryGetValue.
En Program.cs, el delegado devuelto se ejecuta directamente como si fuera un método normal: operacion(a, b).


Ejemplo de uso
Suma:
Seleccione operación: 1
Ingrese el primer número: 10
Ingrese el segundo número: 5
Resultado: 15

Multiplicación:
Seleccione operación: 3
Ingrese el primer número: 6
Ingrese el segundo número: 7
Resultado: 42

División por cero:
Seleccione operación: 4
Ingrese el primer número: 10
Ingrese el segundo número: 0
Error: División por cero.
Opción inválida:
Seleccione operación: 9
Opción no válida.

capturas del programa.
suma
<img width="1653" height="938" alt="image" src="https://github.com/user-attachments/assets/fb6b11e3-c393-48f2-bfe8-3ac20dae1f03" />
resta
<img width="1750" height="904" alt="image" src="https://github.com/user-attachments/assets/2c6b9d90-0384-43ef-8932-cc706f9d81fc" />
multiplicacion
<img width="1719" height="968" alt="image" src="https://github.com/user-attachments/assets/e82bd516-af39-4d26-827f-ef7cb5d4061d" />
division
<img width="1658" height="995" alt="image" src="https://github.com/user-attachments/assets/6e5aa98d-fd42-4a56-968b-d1d8b50d87dd" />





