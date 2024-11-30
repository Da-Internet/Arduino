int led = 13;

void setup() {
  // Setup
pinMode (led, OUTPUT); //El pin 13 que marcamos como Led arriba es salda
}

void loop() {
  // Codigo
digitalWrite(led,HIGH); 
//HIGH es encender, LOW es Apagar
delay(1000); 
//Delay es el retraso para la orden, en ms

digitalWrite(led,LOW);
delay(1000);
}
