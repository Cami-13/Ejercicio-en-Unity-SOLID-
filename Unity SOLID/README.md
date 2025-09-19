# Ejercicio-en-Unity-SOLID-
Este prototipo trata sobre el un sistema de frutas en el cual el player podrá comer distintos tipos de frutas que mejoraran sus atributos. 
El principio de responsabilidad única plantea que una clase debe tener una única responsabilidad, es decir, una única función, y por ende, dicha clase debe tener solo una razón para modificarse. 
Entonces para este principio plantee cuatro entidades, player, Ifruit, banana y frutilla, todas son clases con sus respectivos métodos y atributos, menos Ifruit que será una abstracción que permite cumplir con el principio Inversión de dependencias.
El player administra su estado que será su visión y su recuperación muscular, la banana y la frutilla deciden que cambios producen al player.
Frutilla (mejora la visión y da energía), banana (realiza recuperación muscular y da energía).
En el principio Inversión de dependencias dice que las clases de alto nivel no deben depender de las de bajo nivel, sino que ambas deben depender de abstracciones. Y que los detalles deben depender de las abstracciones, y no al revés.
Entonces el player al ejecutar el método “ComerFruta” no depende de las clases concretas como “Banana” o “Frutilla”, sino que  depende de la abstracción “IFruit”, es decir, no necesita saber que fruta es, solo entiende que es algo que puede dar energía.
Con esto podemos agregar nuevas frutas sin modificar la clase player.
Por ultimo tendremos al GameController que solo coordina que come y muestra el estado inicial, cada vez que el jugador presiona el “SPACE” del teclado, el estado se actualiza y lo podremos apreciar en la consola.
