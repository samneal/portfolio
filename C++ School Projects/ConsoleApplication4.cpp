// ConsoleApplication4.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <string>
#include <conio.h>
#include <iostream>
#include <fstream>
using namespace std;

class customerInfo{
private:
	int acctNum;
	string fName;
	string lName;
public:
	void setAll(int a,string f,string l);
	int getAcctNum();
	string getFName();
	string getLName();
	string getFullName();
	customerInfo();
};

class phoneBill{
private:
	customerInfo custListarray[9];
	int acctNum;
	int index;
	double curBalance;
	double totalDue;
	int totalTime;
	double callsCost;
public:
	void promptInfo();
	void loadList();
	void calculateCharges();
	void updateBalance();
	void printBalance();
	phoneBill();
	
};

class mobilePhone: public phoneBill
{

};

int main(){

	_getch();
	return 0;
	
}

phoneBill::phoneBill()
{
	loadList();
}

void phoneBill::loadList()
{
	int a;
	string f;
	string l;
	ifstream infile;
	infile.open("employees.txt");
	for (int i = 0; i < 9; i++){
		infile >> a;
		infile >> f;
		infile >> l;
		custListarray[i].setAll(a, f, l);
	}

}

void phoneBill::promptInfo()
{
	index = -1;
	cout << "Enter the account number: ";
	cin >> acctNum;
	while (index == -1){
	for (int i = 0; i < 9; i++){
		if (custListarray[i].getAcctNum == acctNum){
			index = i;
			cout << "Enter the current balance: ";
			cin >> curBalance;
			cout << "Enter the total time in minutes: ";
			cin >> totalTime;
		}
	}
	if (index == -1){
		cout << "Number not found, try again: ";
		cin >> acctNum;
	}
}

}

void phoneBill::calculateCharges()
{
	callsCost = .25*totalTime;
}

void phoneBill::updateBalance()
{
	totalDue = curBalance + callsCost;
	curBalance = totalDue;
}

void phoneBill::printBalance()
{
	cout << custListarray[index].getFullName() << endl;
	cout << curBalance << endl;
	cout << totalTime << endl;
	cout << callsCost << endl;
	cout << totalDue << endl;
	
}

customerInfo::customerInfo()
{
	acctNum = 9999;
	fName = "noName";
	lName = "noName";
}

int customerInfo::getAcctNum()
{
	return acctNum;
}

string customerInfo::getFName()
{
	return fName;
}

string customerInfo::getLName()
{
	return lName;
}

string customerInfo::getFullName()
{
	return fName + " " + lName;
}

void customerInfo::setAll(int a,string f,string l)
{
	acctNum = a;
	fName = f;
	lName = l;
}