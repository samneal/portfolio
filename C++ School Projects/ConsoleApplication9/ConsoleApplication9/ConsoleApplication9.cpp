// ConsoleApplication9.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <string>
#include <iostream>
#include <conio.h>

using namespace std;

template <class TYPE>
class someClass
{
protected:
	TYPE Data;
public:
	someClass() : Data(TYPE())
	{}

	void SetData(TYPE nValue)
	{
		Data = nValue;
	}

	TYPE GetData() const
	{
		return Data;
	}

	void PrintData()
	{
		cout << Data;
	}
};

class Point{
private:
	int x;
	int y;
public:
	Point(int = 0, int = 0);
	Point(const Point& p);
	void set(int = 0, int = 0);
	void setX(int = 0);
	void setY(int = 0);
	int getX();
	int getY();
	void operator=(const Point& rgt);
	friend ostream& operator<<(ostream& out, const Point& p);
};

int main()
{
	someClass<int> intClass;
	someClass<string> strClass;
	someClass<double> dblClass;
	someClass<Point> ptClass;
	Point ptc(3, 6);

	int a = 7;

	//Set data of each object
	intClass.SetData(a);
	strClass.SetData("Hello");
	ptClass.SetData(ptc);

	//Get object data and assign to another object
	int b = intClass.GetData();
	string c = strClass.GetData();
	Point d = ptClass.GetData();

	cout << "Class Template Demo App" << "" << "\n-----------------------------" << endl;
	cout << "Integer Call --- b: " << b << endl;
	cout << "String Call --- c: " << c << endl;
	cout << "Point Call --- d: " << d << endl;

	_getch();
	return 0;
	
}

Point::Point(int _x, int _y){
	set(_x, _y);
}
Point::Point(const Point& p){
	x = p.x;
	y = p.y;
}
void Point::set(int _x, int _y){
	x = _x;
	y = _y;
}
void Point::setX(int _x){
	x = _x;
}
void Point::setY(int _y){
	y = _y;
}
int Point::getX(){
	return x;
}
int Point::getY(){
	return y;
}
void Point::operator=(const Point& rgt){
	x = rgt.x;
	y = rgt.y;
}
ostream& operator<<(ostream& out, const Point& p){
	out << "(" << p.x << "," << p.y << ")";
	return out;
}