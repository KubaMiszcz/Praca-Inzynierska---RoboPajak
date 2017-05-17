// 
// 
// 

#include "SG90servo.h"

void SG90servo::init()
{
}

void SG90servo::writeMicrosecondsss(int value)
{
	this->writeMicroseconds(1000);
}


SG90servo SG90servoObj;

