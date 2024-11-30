int estado=0;

void setup() {
  Serial.begin(9600);
  pinMode(4, INPUT);
}

void loop() {

    estado=digitalRead(4);
    if(estado==HIGH){
      Serial.println("E");
      delay(200);
      }
      else{
        Serial.println("A");
        delay(200);
      }

}
