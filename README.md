# Tutorial Roll a Ball - Sistemas Interactivos

## Universidad Pompeu Fabra (UPF) 2020

**Alumno**: David Ciria Mayordomo <br/>
**NIA:** 206038 <br/>
**Usuario:** U150281 <br/>
**Email:** david.ciria01@estudiant.upf.edu <br/>

## Implementación

Para ver correctamente las dos displays hay que poner tanto la Display1 como la Display2 en Standalone 1024*768 y la escala a 0.619.

* Se ha implementado una visión panoramica con dos camaras. Ambas camaras siguen al jugador (tambien se podria haber hecho estatico desde un ángulo de mayor vision).
* Se ha creado otra camara para el minimapa (camara que tiene una rotación de 95 grados para ver todo el campo de juego). La camara es estatica (no se mueve con el jugador).
* Se ha creado un cubo al que se le ha asociado una render texture de otra camara que sigue al jugador. El cubo solo se puede ver desde determinadas posiciones del juego ya que no se mueve con el jugador.


## Mejoras añadidas Lab1

* Escenario ambientado en un laberinto.
* Fuerza de fricción añadida (para que cuando dejemos de movernos la pelota se detenga).
* El personaje puede saltar (pulsando la tecla espacio).
* Añadido un cubo enemigo rojo (si lo tocas vuelves al principio).
* Deteccion de limites (si caemos al vacio volvemos al principio).
* Materiales modificados, añadidos pick-ups de color dorado, etc.
