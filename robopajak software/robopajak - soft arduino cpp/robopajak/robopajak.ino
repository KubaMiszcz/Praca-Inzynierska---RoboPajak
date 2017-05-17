/*
 Name:		robopajak.ino
 Created:	11/10/2016 11:19:45 PM
 Author:	KubaMiszcz
*/

/*
Controlling a servo position using a potentiometer (variable resistor)
by Michal Rinott <http://people.interaction-ivrea.it/m.rinott>

modified on 8 Nov 2013
by Scott Fitzgerald
http://www.arduino.cc/en/Tutorial/Knob
*/

//#include "RobotLeg.h"
//#include <StandardCplusplus-master\StandardCplusplus.h>
//#include <StandardCplusplus-master\iterator>
//#include <StandardCplusplus-master\vector>
#include "SG90servo.h"
#include "Robot.h"
#include "Point3d.h"
#include <Servo.h>



using namespace std;

Servo myservo1;  // create servo object to control a servo
Servo myservo2;  // create servo object to control a servo
Servo myservo3;  // create servo object to control a servo

int potpin1 = A0;  // analog pin used to connect the potentiometer
int potpin2 = A1;  // analog pin used to connect the potentiometer
int potpin3 = A2;  // analog pin used to connect the potentiometer
int val1;    // variable to read the value from the analog pin
int val2;    // variable to read the value from the analog pin
int val3;    // variable to read the value from the analog pin



void setup() {
	Serial.begin(9600);
	myservo1.attach(9, 565, 2580);  // attaches the servo on pin 9 to the servo object
	myservo2.attach(10, 565, 2580);  // attaches the servo on pin 9 to the servo object
	myservo3.attach(11, 565, 2580);  // attaches the servo on pin 9 to the servo object
	Serial.println("hello");
}

void loop() {

	Point3d pp1 = Point3d(1,2,3);
	Point3d pp2 = Point3d(4,5,6);
	pp1.DistanceTo(pp2);
	
	int ctime = millis();
	val1 = analogRead(potpin1);
	val1 = map(val1, 0, 1023, 500, 2700);
	myservo1.writeMicroseconds(val1);

	val2 = analogRead(potpin2);
	val2 = map(val2, 0, 1023, 500, 2700);
	myservo2.writeMicroseconds(val2);
	
	val3 = analogRead(potpin3);
	val3 = map(val3, 0, 1023, 500, 2700);
	myservo3.writeMicroseconds(val3);
	delay(3);

	String str = val1 + ", ";
		str += val2 + ", ";
		str += val3;
		Serial.print(val1);
		Serial.print(", ");
		Serial.print(val2);
		Serial.print(", ");
		Serial.print(val3);
		Serial.print("\n");

		
}

void test2() {
//	int an0 = 550;
	int an0 = 4800;
	myservo1.attach(9,550,2475);  // attaches the servo on pin 9 to the servo object
	myservo1.write(180);
	delay(1000);
	myservo1.write(90);
	delay(1000);
	int str=myservo1.readMicroseconds();
	Serial.println(str);
	myservo1.write(0);
	delay(1000);

//	myservo1.writeMicroseconds(an0);                  // sets the servo position according to the scaled value


}

void test() {
	myservo1.attach(9,555,2450);
	int delaytime = 500;
	int an0 = 555;	//544
	int an45 = 920;
	int an90 = 1360;	//1350
	int an135 = 1860;
	int an180 = 2450;	//2400
	//myservo1.writeMicroseconds(zero);                  // sets the servo position according to the scaled value
//	delay(del);                           // waits for the servo to get there
	delay(delaytime * 2);
	myservo1.writeMicroseconds(an0);                  // sets the servo position according to the scaled value
	delay(delaytime);                           // waits for the servo to get there
	myservo1.writeMicroseconds(an45);                  // sets the servo position according to the scaled value
	delay(delaytime);                           // waits for the servo to get there
	myservo1.writeMicroseconds(an90);                  // sets the servo position according to the scaled value
	delay(delaytime);                           // waits for the servo to get there
	myservo1.writeMicroseconds(an135);                  // sets the servo position according to the scaled value
	delay(delaytime);                           // waits for the servo to get there
	myservo1.writeMicroseconds(an180);                  // sets the servo position according to the scaled value
}

void robo1() {
	int delaytime = 150;
	val1 = analogRead(potpin1);            // reads the value of the potentiometer (value between 0 and 1023)
	val1 = map(val1, 0, 1023, 565, 2580);     // scale it to use it with the servo (value between 0 and 180)
	Serial.println(val1);
	myservo1.writeMicroseconds(val1);                  // sets the servo position according to the scaled value
	delay(delaytime);                           // waits for the servo to get there
	
	val2 = analogRead(potpin2);            // reads the value of the potentiometer (value between 0 and 1023)
	val2 = map(val1, 0, 1023, 565, 2580);     // scale it to use it with the servo (value between 0 and 180)
	myservo1.writeMicroseconds(val2);                  // sets the servo position according to the scaled value
	delay(delaytime);                           // waits for the servo to get there

}



//float DistanceBetween(Point3d p1, Point3d p2)
//{
//	float distance = sqrt(pow((p2.X - p1.X), 2) + pow((p2.Y - p1.Y), 2) + pow((p1.Z - p1.Z), 2));
//	return distance;
//}




