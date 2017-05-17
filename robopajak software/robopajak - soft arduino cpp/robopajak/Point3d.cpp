// 
// 
// 

#include "Point3d.h"
//using namespace Points;

void Point3d::init()
{

}

Point3d::Point3d(float X, float Y, float Z)
{
	this->X = X;
	this->Y = Y;
	this->Z = Z;
}

float Point3d::DistanceTo(Point3d target)
{
	float X1 = target.X;
	float Y1 = target.Y;
	float Z1 = target.Z;

	float distance = sqrt(pow((X1 - X), 2) + pow((Y1 - Y), 2) + pow((Z1 - Z), 2));
	return distance;
}

float Point3d::DistanceBetween(Point3d p1, Point3d p2)
{
	float distance = sqrt(pow((p2.X - p1.X), 2) + pow((p2.Y - p1.Y), 2) + pow((p1.Z - p1.Z), 2));
	return distance;
}

Point3d P3d;

