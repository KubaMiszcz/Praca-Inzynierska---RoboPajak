// 
// 
// 

#include "RobotLeg.h"
#include "math.h"

using namespace std;

void RobotLeg::init()
{
}

RobotLeg::RobotLeg()
{
}

RobotLeg::RobotLeg(Servo servoArm1, Servo servoArm2, Servo servoArm3, float offsetX=0, float offsetY = 0, float offsetZ = 0, float offsetTh1 = 0, float offsetTh2 = 0, float offsetTh3 = 0)
{
		this->servoArm1 = servoArm1;
		this->servoArm2 = servoArm2;
		this->servoArm3 = servoArm3;
		this->offsetX = offsetX;
		this->offsetY = offsetY;
		this->offsetZ = offsetZ;
		this->offsetTh1 = offsetTh1;
		this->offsetTh2 = offsetTh2;
		this->offsetTh3 = offsetTh3;
		this->speed = speed;
}

void MoveToTheta(Point3d target)
{
	
}


void RobotLeg::MoveToPoint(Point3d target)
{
	
}

Point3d RobotLeg::CurrentPosition()
{
	return Point3d();
}


RobotLeg RobotLegObj;

