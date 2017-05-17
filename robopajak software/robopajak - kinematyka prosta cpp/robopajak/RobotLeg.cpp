// 
// 
// 

#include "RobotLeg.h"
#include "math.h"

//using namespace Points;

void RobotLeg::init()
{
}

RobotLeg::RobotLeg()
{
}

RobotLeg::RobotLeg(Servo servoArm1, Servo servoArm2, Servo servoArm3, float offsetX, float offsetY, float offsetZ)
{
		this->servoArm1 = servoArm1;
		this->servoArm2 = servoArm2;
		this->servoArm3 = servoArm3;
		this->offsetX = offsetX;
		this->offsetY = offsetY;
		this->offsetZ = offsetZ;
		this->speed = speed;
}

void RobotLeg::MoveToPoint(Point3d target)
{
	
}

Point3d RobotLeg::CurrentPosition()
{
	return Point3d();
}


RobotLeg RobotLegObj;

