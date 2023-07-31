#include "Wire.h" // For I2C
#include "LCD.h" // For LCD
#include "LiquidCrystal_I2C.h" // Added library*
//Set the pins on the I2C chip used for LCD connections


LiquidCrystal_I2C lcd(0x27,2,1,0,4,5,6,7); // 0x27 is the default I2C bus address of the backpack-see articleint Prog=2;
const int trigPin = 2;
const int echoPin =3;


long duration;
int distance;

int Prog=2;
int CTS=3;
char incomingOption = 0; 
 

void setup() 
{
   pinMode(Prog,OUTPUT);
   pinMode(CTS,OUTPUT);
   pinMode(8,OUTPUT);
   Serial.begin(9600);
 
   digitalWrite(Prog, LOW);
   digitalWrite(CTS, HIGH);
   
   
   pinMode(7,OUTPUT);
   pinMode(trigPin, OUTPUT); // Sets the trigPin as an Output
   pinMode(echoPin, INPUT); // Sets the echoPin as an Input
  
   lcd.begin (16,2); // 16 x 2 LCD module
   lcd.setBacklightPin(3,POSITIVE); // BL, BL_POL
   lcd.setBacklight(HIGH);
   lcd.print("Hello, World!");
   lcd.setCursor(0,1);
   lcd.print("Good Day");
   
   delay(1000);
   lcd.clear();
   digitalWrite(7,HIGH);
   digitalWrite(8,HIGH);;


}

void loop() 
{ 
   Ultra();
  lcd.clear();
  lcd.print("Distance:- ");
  lcd.print(distance);
  lcd.print("cm");
  //Serial.println(distance);
  delay(500);
  if(distance >=100)
         {
            delay(5000);
           if(distance >=100)
           {
              digitalWrite(7,LOW);
              digitalWrite(8,HIGH);
              //Serial.println(distance);          
              lcd.print("Alert..!! ");
              delay(500); 
           }   
         }
         else 
         {
             
             incomingOption=Serial.read();
             switch(incomingOption)
             {
              case 'A':
            
                digitalWrite(13,LOW);
                Ultra();
                lcd.print("Sending the data..");
                if(distance >10)
                {
                Serial.println(distance);
                }
                delay(500);
                lcd.clear();
                
                  break;
                case 'B':
                    digitalWrite(7,LOW); 
                    lcd.print("Plant Water Start");
                    
                    delay(500);
                    lcd.clear(); 
                    
                break;
                case 'C':
                    digitalWrite(7,HIGH);
                    lcd.print("Plant Water Stop");
                    
                    delay(500);
                    lcd.clear();
                break;
                case 'D':
                    digitalWrite(8,LOW);
                    lcd.print("Tank Pump Start");
                    
                    delay(500);
                    lcd.clear();
                break;
                case 'E':
                    digitalWrite(8,HIGH);
                    lcd.print("Plant Water Stop");
                    
                    delay(500);
                    lcd.clear();
                break;
                
             }
  

}
} 
void Ultra()
{
  
      digitalWrite(trigPin, LOW);
      delayMicroseconds(2);
      
      digitalWrite(trigPin, HIGH);
      delayMicroseconds(10);
      digitalWrite(trigPin, LOW);
      
      duration = pulseIn(echoPin, HIGH);
      
      distance =(duration/2) / 29.1;
}

         
