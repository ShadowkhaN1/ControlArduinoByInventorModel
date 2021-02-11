#include <Servo.h>


Servo myservo1;
Servo myservo2;


String value;

void setup() {

 
  Serial.begin(9600);
  myservo1.attach(9);
  myservo2.attach(10); 


}

void loop() {

   value = Serial.readStringUntil('\n'); 
   
   myservo1.write(value1.substring(0, value1.indexOf(" ")).toInt());
   myservo2.write(value1.substring(value1.indexOf(" ")).toInt());
}
