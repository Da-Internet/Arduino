const int LED1 = 13;
const int LED2 = 12;
const int LED3 = 11;
const int LED4 = 10;
const int LED5 = 9;
const int PUSH1 = 6;
const int PUSH2 = 5;
const int PUSH3 = 4;
const int PUSH4 = 3;
const int PUSH5 = 2;
int respuesta1;
int respuesta2;
int respuesta3;
int respuesta4;
int respuesta5;

void setup() {
  pinMode (LED1, OUTPUT);
  pinMode (LED2, OUTPUT);
  pinMode (LED3, OUTPUT);
  pinMode (LED4, OUTPUT);
  pinMode (LED5, OUTPUT);
  pinMode (PUSH1, INPUT);
  pinMode (PUSH2, INPUT);
  pinMode (PUSH3, INPUT);
  pinMode (PUSH4, INPUT);
  pinMode (PUSH5, INPUT);
}

void loop() {
  respuesta1=digitalRead(PUSH1);
  respuesta2=digitalRead(PUSH2);
  respuesta3=digitalRead(PUSH3);
  respuesta4=digitalRead(PUSH4);
  respuesta5=digitalRead(PUSH5);
  
  /////////////////////////////////////////////////////////
  
  digitalWrite(LED1,HIGH);
  digitalWrite(LED2,HIGH);
  digitalWrite(LED3,HIGH);
  digitalWrite(LED4,HIGH);
  digitalWrite(LED5,HIGH);
  
  /////////////////////////////////////////////////////////
  
  if(respuesta1==HIGH){
    digitalWrite(LED1, LOW);
  }
  else{
    digitalWrite(LED1, HIGH);
    }
  
  /////////////////////////////////////////////////////////
  
  if(respuesta2==HIGH){
    digitalWrite(LED2, LOW);
  }
  else{
    digitalWrite(LED2, HIGH);
    }
  
  /////////////////////////////////////////////////////////
  
  if(respuesta3==HIGH){
    digitalWrite(LED3, LOW);
  }
  else{
    digitalWrite(LED3, HIGH);
    }
  
  /////////////////////////////////////////////////////////
  
  if(respuesta4==HIGH){
    digitalWrite(LED4, LOW);
  }
  else{
    digitalWrite(LED4, HIGH);
    }
  
  /////////////////////////////////////////////////////////

  if(respuesta5==HIGH){
    digitalWrite(LED5, LOW);
  }
  else{
    digitalWrite(LED5, HIGH);
    }
   
  /////////////////////////////////////////////////////////
  
}
