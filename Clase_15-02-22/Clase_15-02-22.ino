const int LED1 = 13; //Salida
const int PUSH = 2; //Entrada
int respuesta;

void setup() {
  pinMode(LED1, OUTPUT);
  pinMode(PUSH, INPUT);
}

void loop() {
  respuesta=digitalRead(PUSH);

  if(respuesta==LOW){
    digitalWrite(LED1, LOW);
  }
  else{
    digitalWrite(LED1, HIGH);
    }
}
