/*
 Name:		serialBlink.ino
 Created:	12/10/2016 8:24:41 AM
 Author:	KubaMiszczLenovo
*/
#include <Servo.h>

using namespace std;

int LedPin = 13;
Servo myServo;

// the setup function runs once when you press reset or power the board
void setup()
{
	Serial.begin(57600);
	Serial.println("hello");
	pinMode(LedPin, OUTPUT);
	myServo.attach(3,500,2700);
	Serial.println(myServo.readMicroseconds());
	Serial.println(myServo.readMicroseconds());
	Serial.println(myServo.readMicroseconds());
}

void SmarowanieServa(const Servo& servo)
{
	int i = 100;
	while (i--) {
		MoveServo(600);
		MoveServo(2550);
	}
};

// the loop function runs over and over again until power down or reset
void loop() {
	if (Serial.available() > 0) {
		String inString = Serial.readString();
		// Type the next ASCII value from what you received:
		size_t value = inString.toInt();
		//BlinkNtimes(value);  //test
		MoveServo(value);
		//Serial.println(myServo.readMicroseconds());

		//SmarowanieServa(myServo);

	}
}

void MoveServo(size_t value) {
	int speed = 100;	
	int curPos = myServo.readMicroseconds();
	while (curPos != value) {
		if (curPos<value)
		{
			curPos++;
		}
		else
		{
			curPos--;
		}
		myServo.writeMicroseconds(curPos);
		curPos = myServo.readMicroseconds();
		_delay_us(speed);
	} 
	Serial.println(myServo.readMicroseconds());
}


void BlinkNtimes(size_t n) {
	size_t delayTime = 250;
	for (size_t i = 0; i < n; i++)
	{
		digitalWrite(LedPin, HIGH);
		_delay_ms(delayTime);
		digitalWrite(LedPin, LOW);
		_delay_ms(delayTime);
	}
	Serial.println(n);
}



