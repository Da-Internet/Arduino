int led1 = 13;
int led2 = 12;

void setup() {
  // Setup
pinMode (led1, OUTPUT);
pinMode (led2, OUTPUT);
}

void loop() {
  // Codigo
digitalWrite(led1,HIGH); 
digitalWrite(led2,LOW);
delay(500);

digitalWrite(led1,LOW);
digitalWrite(led2,HIGH); 
delay(500);
}