#include <Servo.h>

Servo servo1; //se crea un objeto servo,o declaran un servo

void setup() {
  servo1.attach(9);//asignar el servo al pin 9
  Serial.begin(9600);//definir la velocidad de transmisión para el puerto serial
}

void loop() {
  
  int lectura = analogRead(A1); //leer la señal del pot y guardarla en la variable "lectura" y el pot está conectado a A1
  //de 0 a 5v físicos la señal está de 0 a 1023 (resolución de la entrada analógica) en la variable "lectura"; 0v=0 y 5v=1023
  
  int angulo = map(lectura, 0, 1023, 0, 180);  //map(señal, min y max en el que se encuentra la señal, min y max al que se escala la señal)
  //la señal se encuentra de 0 a 180 en la variable angulo
  
  servo1.write(angulo);//enviar lo de la variable angulo al servo
  Serial.print("Angulo: ");//impresion al puerto serial
  Serial.print(angulo);//impresion al puerto serial
  delay(10);
}
