int led=13;
char lectura;
String concatenacion;

void setup() {
  pinMode(led, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  
while(Serial.available() > 0)//mayor que cero
{
 lectura= Serial.read();
 concatenacion.concat(lectura);
 delay(10);
}

if(concatenacion.equals("Encendido")==true)
{
digitalWrite(led,HIGH);
Serial.println("led encendido");  
}

if(concatenacion.equals("Apagado")==true)
{
digitalWrite(led,LOW);
Serial.println("led apagado");  
}

}
