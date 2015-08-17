// ConsoleApplication11.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <string>
#include <iostream>
#include <conio.h>
#include <vector>
#include <time.h>
#include <list>

using namespace std;



template<class TYPE>
class Rectangle
{
private:
	TYPE width;
	TYPE length;
public:
	void setData(TYPE w, TYPE l){
		width = w;
		length = l;
	}
	TYPE getWidth(){
		return width;
	}
	TYPE getLength(){
		return length;
	}
	TYPE getArea(){
		return width * length;
	}

};


int main(){
	vector<double> scores;
	list<int> numbers(100);

	for (int i = 0; i < 100; i++){
		numbers.assign{ i, i };
	}

	scores.resize(20);
	for (int i = 0; i < 20; i++){
		scores[i] = rand() % 100 + 40;
		}
	int count;
	for (int i = 0; i < 20; i++){
		if (scores[i]>64){
			count++;
		}
	}
	cout << "Number of scores above 64: " << count << endl;











	Rectangle<int> intTangle;
	Rectangle<double> dblTangle;
	Rectangle<short> shTangle;

	

	intTangle.setData(12,5);
	dblTangle.setData(15.2,7.1);
	shTangle.setData(1,3);

	int iLen = intTangle.getLength();
	double dLen = dblTangle.getLength();
	short sLen = shTangle.getLength();

	int iWid = intTangle.getWidth();
	double dWid = dblTangle.getWidth();
	short sWid = shTangle.getWidth();

	int iArea = intTangle.getArea();
	double dArea = dblTangle.getArea();
	short sArea = shTangle.getArea();

	cout << "Lengths :" << endl;
	cout << iLen << " " << dLen << " " << sLen << endl;
	cout << "Widths:" << endl;
	cout << iWid << " " << dWid << " " << sWid << endl;
	cout << "Area:" << endl;
	cout << iArea << " " << dArea << " " << sArea << endl;

	_getch();
	return 0;
}
