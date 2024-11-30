const int LED1 = 13;
const int LED2 = 12;
const int LED3 = 11;
const int LED4 = 10;
const int LED5 = 9;
const int LED6 = 8;
const int PUSH1 = 2;
const int PUSH2 = 3;
int respuesta1;
int respuesta2;

void setup() {
  pinMode (LED1, OUTPUT);
  pinMode (LED2, OUTPUT);
  pinMode (LED3, OUTPUT);
  pinMode (LED4, OUTPUT);
  pinMode (LED5, OUTPUT);
  pinMode (LED6, OUTPUT);
  pinMode (PUSH1, INPUT);
  pinMode (PUSH2, INPUT);

}

void loop() {
  respuesta1=digitalRead(PUSH1);
  respuesta2=digitalRead(PUSH2);
  
  /////////////////////////////////////////////////////////

  if(respuesta1==HIGH){
    digitalWrite(LED1, HIGH);
    digitalWrite(LED2, HIGH);
    digitalWrite(LED3, HIGH);
  }
  else{
    digitalWrite(LED1, LOW);
    digitalWrite(LED2, LOW);
    digitalWrite(LED3, LOW);
    }
  
  /////////////////////////////////////////////////////////
  
   if(respuesta2==HIGH){
    digitalWrite(LED4, HIGH);
    digitalWrite(LED5, HIGH);
    digitalWrite(LED6, HIGH);
  }
  else{
    digitalWrite(LED4, LOW);
    digitalWrite(LED5, LOW);
    digitalWrite(LED6, LOW);
    }
    
}
