long brillo; //Variable para el brillo

int LED1 = 13; // El Led Verde esta conectado al pin 13
int LED2 = 11; // El Led Amarillo esta conectado al pin 11
int LED3 = 9; // El Led Rojo esta conectado al pin 9
int LED4 = 7; // El Led Azul esta conectado al pin 7
int POT = A0; // El Potenciometro esta conectado al pin A0

void setup() {
  
  pinMode (LED1, OUTPUT); 
  pinMode (LED2, OUTPUT);
  pinMode (LED3, OUTPUT);
  pinMode (LED4, OUTPUT);
}

void loop(){
  
  brillo = analogRead (POT);

  if (brillo >= 0 && brillo <=256){ //Led 1 a 256

    digitalWrite (LED1, HIGH);
    digitalWrite (LED2, LOW);
    digitalWrite (LED3, LOW);
    digitalWrite (LED4, LOW);
    
  }

  if (brillo >= 257 && brillo <=512){ //Led 2 hasta 512
    
    digitalWrite (LED1, LOW);
    digitalWrite (LED2, HIGH);
    digitalWrite (LED3, LOW);
    digitalWrite (LED4, LOW);
   }

   if (brillo >= 513 && brillo <=578){ //Led 3 hasta 578
    
    digitalWrite (LED1, LOW);
    digitalWrite (LED2, LOW);
    digitalWrite (LED3, HIGH);
    digitalWrite (LED4, LOW);
   }

   if (brillo >= 769 && brillo <=1023){ //Led 4 hasta 1023
    
    digitalWrite (LED1, LOW);
    digitalWrite (LED2, LOW);
    digitalWrite (LED3, LOW);
    digitalWrite (LED4, HIGH);
   }
   
}
