# EnemysFollow
![image](https://github.com/Ji07y/EnemysFollows/assets/85076732/c889553d-8dc6-4e5c-9549-76bbd2ffeba7)
link video YouTube: https://youtu.be/9zCp6Sm9few

Aplicación de principios y arquitecturas de sistemas hipermedia,este proyecto en Unity esta diseñado para que un enemigo siga al jugador y a su vez que dispara balas al jugador además controla las vidas del jugador. A continuación, se presenta una breve descripción de las características y funcionalidades:
 
# EnemigoDispara Script
## Variables Públicas
![image](https://github.com/Ji07y/EnemysFollows/assets/85076732/a3459575-b2e8-4d85-875e-925ab3a28316)

 .bulletPrefab: Una referencia al prefab de la bala que el enemigo dispara.
 
 .target: Un objeto de tipo Transform que sirve como el objetivo al que el enemigo dispara.
 
 .player: Una referencia al objeto de tipo Transform que representa al jugador.
 
 .textVidas: Un elemento de texto (TextMeshProUGUI) que muestra el número de vidas del jugador.
 
 .textGameOver: Otro elemento de texto (TextMeshProUGUI) que se utiliza para mostrar "Game Over".

## Variables Privadas
![image](https://github.com/Ji07y/EnemysFollows/assets/85076732/f386bbfa-f1fe-40d2-b7f3-58e9d0d0aee4)

 .timer: Un temporizador que controla la velocidad de disparo del enemigo.
 
 .lastShotTime: El tiempo del último disparo del enemigo.
 
  .vidasPlayer: El número de vidas del jugador.
 

## Métodos
 .Start(): En el inicio, establece el texto de las vidas del jugador y desactiva el texto de "Game Over".
 ![image](https://github.com/Ji07y/EnemysFollows/assets/85076732/fade5217-3fa6-4443-8d75-d3c8796da18b)

 .Update(): Actualiza continuamente el juego y controla cuándo el enemigo debe disparar balas.
 ![image](https://github.com/Ji07y/EnemysFollows/assets/85076732/dbcf4c7d-9fb7-4799-a1a5-f943d11e4f9a)

 .DisparoBalas(): Realiza un disparo hacia el jugador si se cumple cierta condición. Se utiliza un rayo para detectar si hay un obstáculo entre el enemigo y el jugador. Si el rayo alcanza al jugador, se instancia una bala y se le aplica una fuerza. También reduce las vidas del jugador y actualiza el texto de las vidas. Si el jugador se queda sin vidas, se activa el mensaje "Game Over" y se cierra la aplicación.
 
![image](https://github.com/Ji07y/EnemysFollows/assets/85076732/84b792ce-c298-420e-8ef6-341177826c27)

 .VidasJugador(int vidasPlayer): Verifica si el jugador ha perdido todas sus vidas. Si es así, muestra el mensaje de "Game Over" y desactiva el componente del script.
 
 ![image](https://github.com/Ji07y/EnemysFollows/assets/85076732/fe40405d-4a84-4c09-a55a-945257960a18)

 .DeberiaDisparar(): Determina si el enemigo debe disparar, basándose en la distancia al jugador. Si la distancia es menor que 30 unidades, el enemigo debería disparar.
 
 ![image](https://github.com/Ji07y/EnemysFollows/assets/85076732/6a51e5e0-2c10-4817-afd9-202aa37efe19)

 .ColisionConJugador(Collision collision): Maneja las colisiones con el jugador y reduce las vidas del jugador cuando se produce una colisión.
 
![image](https://github.com/Ji07y/EnemysFollows/assets/85076732/d540f2b5-91b7-4f9b-92e9-70db471303e5)

Este script se utiliza para controlar el comportamiento de un enemigo que dispara balas al jugador y maneja las vidas del jugador. Asegúrate de integrar este script correctamente en tu proyecto de Unity y ajustar las variables públicas según sea necesario para lograr el comportamiento deseado en tu juego.

# Descripción del Script de Disparo
Este script de Unity controla el disparo de proyectiles desde un objeto en el juego. A continuación, se proporciona una breve descripción de sus características y funcionalidades clave:

# Características Principales:
![image](https://github.com/Ji07y/EnemysFollows/assets/85076732/09ffce1f-f820-4a0b-a8c0-91ac9db58ec0)

bulletPrefab: Esta variable pública es una referencia al objeto prefab que se utilizará como proyectil.

timer: Es un temporizador que establece un intervalo de tiempo entre los disparos. En este caso, se fija en 2 segundos.

lastShotTime: Lleva un registro del tiempo en el que se efectuó el último disparo.

cont: Es un contador que realiza un seguimiento del número de disparos realizados.

# Funciones Principales:
Update(): Este método se ejecuta en cada cuadro de la animación y controla cuándo se debe realizar un disparo. Verifica si el contador cont es menor que 20 y si ha pasado el tiempo especificado en timer desde el último disparo. Si ambas condiciones se cumplen, se llama a la función DispararBala() para efectuar un disparo.

![image](https://github.com/Ji07y/EnemysFollows/assets/85076732/54aafbbd-a5c6-43b2-a1ef-d5fdf0d58b15)

DispararBala(): Esta función se encarga de crear una instancia del objeto prefab bulletPrefab en la posición y rotación del objeto que contiene el script. Luego, obtiene el componente Rigidbody del proyectil para aplicarle una fuerza hacia adelante. Esto simula el movimiento del proyectil. Finalmente, se incrementa el contador cont para llevar un registro de los disparos realizados.
![image](https://github.com/Ji07y/EnemysFollows/assets/85076732/58531952-fd93-4671-adb7-6c7c2ee71b4c)

Este script es útil para implementar el disparo controlado por tiempo de proyectiles en un juego de Unity y puede ser personalizado para ajustar la velocidad, la cantidad de disparos y otros aspectos relacionados con el comportamiento del proyectil.
