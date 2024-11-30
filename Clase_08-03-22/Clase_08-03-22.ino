#include<Servo.h>

Servo Servo1; //Se declara un servo
int const POT=A0; //Se declara el potenciometro
int LED = 12; // Led a pin 12

void setup(){
  pinMode (LED, OUTPUT); 
  Servo1.attach(9);
  Serial.begin(9600);
}

void loop(){
  
  int lectura = analogRead(A0);
  
  int angulo = map(lectura, 0, 1023, 0, 180);
  
  Servo1.write(angulo);//Enviar lo de la variable angulo al servo
  Serial.print("Angulo: ");//Impresion al puerto serial
  Serial.print(angulo);//Impresion al puerto serial
  delay(10);
  
   if (lectura >= 769 && lectura <=1023){ //Led de Alerta
     
     digitalWrite (LED, HIGH);
     digitalWrite (LED, LOW);
   }

}
