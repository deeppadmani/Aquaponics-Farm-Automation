#include <SoftwareSerial.h>

SoftwareSerial mySerial(11, 12); // RX, TX

int Prog=2;
int CTS=3;
char incomingOption = 0; // This will hold one byte of the serial message
 // This is the pin that the led is conected to
String inputString = "";
bool stringComplete = false;

void setup() 
{
  pinMode(Prog,OUTPUT);
  pinMode(CTS,OUTPUT);
  pinMode(13,OUTPUT);
  pinMode(7,OUTPUT);
 Serial.begin(9600);
 mySerial.begin(9600);
 digitalWrite(Prog, LOW);
 digitalWrite(CTS, HIGH);
 digitalWrite(13,LOW);

}

void loop() 
{ 
  incomingOption=Serial.read();
  serialEvent();

  if (stringComplete == true)
  {
    //digitalWrite(8, HIGH);
    
    Serial.print(inputString);
    
    inputString = "";
    stringComplete = false;
    delay(500);
    
  }
   switch(incomingOption)
   {
      case 'A':
          digitalWrite(13,HIGH);
          delay(100);
          mySerial.write(incomingOption);
          //serial();
          break;
      case 'B':
          digitalWrite(7,HIGH);
          delay(100);
          //serial();
          mySerial.write(incomingOption);
          break;
      case 'C':
          digitalWrite(13,LOW);
          digitalWrite(8,LOW);
          //serial();
          mySerial.write(incomingOption);
          delay(100);
          break;
       case 'D':
          
          //serial();
          mySerial.write(incomingOption);
          delay(100);
       break;
       case 'E':
          
          //serial();
          mySerial.write(incomingOption);
          delay(100);
       break;
           
   }
  
      
}

void serialEvent()
{
  while (mySerial.available())
  {
    digitalWrite(8, HIGH);
    char inChar = (char)mySerial.read();
    inputString += inChar;
    if (inChar == '\n')
    {
     stringComplete = true;
    }
  }
}
   
 

