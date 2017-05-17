// RobotLeg.h

#ifndef _ROBOTLEG_h
#define _ROBOTLEG_h
	#include"Point3d.h"
	#include <Servo.h>
#if defined(ARDUINO) && ARDUINO >= 100
	#include "arduino.h"
#else
	#include "WProgram.h"
#endif

//using namespace Points;


class RobotLeg
{
protected:

public:
	float th1, th2, th3;	//katy przegubow
	Servo servoArm1, servoArm2, servoArm3;	//serva
	float offsetX, offsetY, offsetZ;	//przesuniecie wzgledem srodka robota
	float offsetTh1, offsetTh2, offsetTh3;	//przesuniecie wzgledem 90st na serwie, zeby 0st bylo w polowie serwa
	float a1 = 33;	//dlugosci ramion
	float a2 = 100;	//dlugosci ramion
	float a3 = 147; //dlugosci ramion
	float speed;
	void init();
	RobotLeg();
	RobotLeg(Servo servoArm1, Servo servoArm2, Servo servoArm3, float offsetX, float offsetY, float offsetZ, float offsetTh1, float offsetTh2, float offsetTh3);
	void MoveToTheta(Point3d target);
	void MoveToPoint(Point3d target);
	Point3d CurrentPosition();
};

extern RobotLeg RobotLegObj;

#endif

