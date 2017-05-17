// SG90servo.h

#ifndef _SG90SERVO_h
#define _SG90SERVO_h

#include <Servo.h>

#if defined(ARDUINO) && ARDUINO >= 100
	#include "arduino.h"
#else
	#include "WProgram.h"
#endif


class SG90servo : public Servo
{
private:
	int angle0,angle45,angle90,angle135,angle180;


 public:
	void init();
	 void writeMicrosecondsss(int value) {
	 }
};

extern SG90servo SG90servoObj;

#endif


