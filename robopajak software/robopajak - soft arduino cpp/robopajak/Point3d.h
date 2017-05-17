// Point3d.h

#ifndef _POINT3D_h
#define _POINT3D_h
#include "math.h"
#if defined(ARDUINO) && ARDUINO >= 100
#include "arduino.h"

#else
	#include "WProgram.h"
#endif

//namespace Points 
//{
	class Point3d
	{
	public: float X, Y, Z;
	public:
		void init();
		Point3d(float X = 0, float Y = 0, float Z = 0);
		float DistanceTo(Point3d target);
		float DistanceBetween(Point3d p1, Point3d p2);
	};

	extern Point3d P3d;
//}
#endif

