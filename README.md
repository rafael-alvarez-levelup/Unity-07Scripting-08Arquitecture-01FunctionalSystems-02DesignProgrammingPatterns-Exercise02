**Requisitos:**
- Unity 2020.x.
- Visual Studio.

**Descripción:**

![](http://git.azuritetechs.com:82/learning/programming/unity/scripting/08-arquitecture/01-functional-systems/02-design-programming-patterns/exercise-01/-/raw/master/readme_resources/screenshot.png "Mock up")

Desarrollo de un videojuego infinito por turnos para un jugador en el que el jugador se enfrenta a un enemigo por combate y cada combate supone un nivel del juego.

Para ello el jugador debe establecer tres acciones en cada turno: Disparar (daña al enemigo), defender (reduce el daño recibido al 50%) o curar (aumenta sus puntos de vida).

Las acciones se establecen pulsando cada uno de los tres botones de la parte inferior, el jugador puede determinar el orden de las acciones. Cada acción supone un consumo de puntos de acción (barra roja de la parte inferior). Las acciones establecidas para el turno no puede superar el límite de puntos de acción del jugador.
Una vez se han establecido las acciones del turno el jugador debe pulsar el botón “OK” para iniciar el turno. Al iniciarse el turno se establecen de manera aleatoria y automática las acciones del enemigo y posteriormente se resuelven las acciones del turno. El orden de resolución de acciones es el siguiente: 1ª acción del enemigo, 1ª acción del jugador, 2ª acción del enemigo, 2ª acción del jugador, 3ª acción del enemigo, 3ª acción del jugador.

Una vez se resuelve el turno se comprueba si el jugador o el enemigo han muerto:
* Si el enemigo no ha muerto se realizará otro turno en el combate hasta que uno de los dos muera
* Si el enemigo ha muerto se avanza de nivel (aumenta en 1 la etiqueta de texto que hay encima del enemigo) y aparece otro enemigo
* Si el jugador muere se reinicia el juego.


**Objetivos:**
1. Crear los siguientes sistemas e implementar el patrón command:
* Sistema de interacción de las acciones del jugador y del enemigo.
* Sistema de cálculo de gasto de energía de las acciones del jugador.
* Sistema de gestión de niveles del juego.
2. Estructurar y comentar el código correctamente.
3. Compilar el proyecto de Unity para Windows.


**Procedimientos:**
1. Crear un sistema basado en el patrón Observer que dependiendo de las acciones a realizar del jugador o enemigo notifique al otro.
2. Crear un sistema que en base a las acciones del jugador seleccionadas haga un cálculo de consumo de puntos de acción y lo refleje en la barra de puntos de acción del jugador (gameObject “BarActionPlayer”) y que después de cada turno rellene la barra de puntos de acción del jugador en su totalidad.
3. Crear un sistema que gestione la subida de niveles y almacene el nivel actual y notifique la subida de nivel a los elementos interesados, de momento al gameObject “Level” para indicar el nivel actual en la interfaz de usuario.
4. Estructurar y comentar el código utilizando las regiones adecuadas y comentarios.
5. El proyecto se debe compilar para ser ejecutado en Windows. La compilación del proyecto se debe guardar en una carpeta llamada "build" en la raíz del proyecto de Unity.