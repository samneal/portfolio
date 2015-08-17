#include "stdafx.h"
#include "memberType.h"


memberType::memberType()
{
	string name = "";
	string memberID = "";
	int booksBought = 0;
	double amtSpent = 0;
}


void memberType::setName(){
	string mem = "";
	cout << "Enter the member name: ";
	cin >> mem;
	name = mem;
}
string memberType::getName(){
	return name;
}

void memberType::setID(){
	string idd = "";
	cout << "Enter the member ID: ";
	cin >> idd;
	memberID = idd;
}
string memberType::getID(){
	return memberID;
}

void memberType::setBooks(){
	int bb = 0;
	cout << "Enter the number of books bought: ";
	cin >> bb;
	booksBought = bb;
}
int memberType::getBooks(){
	return booksBought;
}

void memberType::setSpent(){
	int ss = 0;
	cout << "Enter the amount spent: ";
	cin >> ss;
	amtSpent = ss;
}
double memberType::getSpent(){
	return amtSpent;
}