int led1 = 13;
int led2 = 12;
int led3 = 11;
int led4 = 10;
int led5 = 9;

void setup() {
  // Setup
pinMode (led1, OUTPUT);
pinMode (led2, OUTPUT);
pinMode (led3, OUTPUT);
pinMode (led4, OUTPUT);
pinMode (led5, OUTPUT);
}

void loop() {
  // Codigo
digitalWrite(led1,HIGH); 
digitalWrite(led2,LOW);
digitalWrite(led3,LOW);
digitalWrite(led4,LOW);
digitalWrite(led5,LOW);
delay(500);

digitalWrite(led1,LOW); 
digitalWrite(led2,HIGH);
digitalWrite(led3,LOW);
digitalWrite(led4,LOW);
digitalWrite(led5,LOW);
delay(500);

digitalWrite(led1,LOW); 
digitalWrite(led2,LOW);
digitalWrite(led3,HIGH);
digitalWrite(led4,LOW);
digitalWrite(led5,LOW);
delay(500);

digitalWrite(led1,LOW); 
digitalWrite(led2,LOW);
digitalWrite(led3,LOW);
digitalWrite(led4,HIGH);
digitalWrite(led5,LOW);
delay(500);

digitalWrite(led1,LOW); 
digitalWrite(led2,LOW);
digitalWrite(led3,LOW);
digitalWrite(led4,LOW);
digitalWrite(led5,HIGH);
delay(500);

digitalWrite(led1,LOW); 
digitalWrite(led2,LOW);
digitalWrite(led3,LOW);
digitalWrite(led4,LOW);
digitalWrite(led5,LOW);
delay(500);
}
