// Robot.h

#ifndef _ROBOT_h
#define _ROBOT_h

#if defined(ARDUINO) && ARDUINO >= 100
	#include "arduino.h"
	#include "RobotLeg.h"
#else
	#include "WProgram.h"
#endif

class Robot
{
 protected:
 public:
	 float posX, posY, posZ; //akt pozycja 
	 float alfa; //obort wzgledem polnocy
	 RobotLeg LegFL, LegFR, LegRL, LegRR; //nogi
	 
	void init();
	Robot();
	Robot(RobotLeg LegFL, RobotLeg LegFR, RobotLeg LegRL, RobotLeg LegRR);
	void MoveToPoint(float X, float Y, float Z);
	void Rotate(float alfa);
	//void MoveUp(float dist); //podnies/obniz
	//void SitDown(); //siadz na tylnych lapach
	//void StandUp(); //wstan do poz poczatkowej

	
};

extern Robot RobotObj;

#endif

