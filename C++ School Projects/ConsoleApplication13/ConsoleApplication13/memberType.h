#pragma once
#include <iostream>
#include <string>

using namespace std;
class memberType
{
private:
	string name;
	string memberID;
	int booksBought;
	double amtSpent;

public:
	void setName();
	string getName();

	void setID();
	string getID();

	void setBooks();
	int getBooks();

	void setSpent();
	double getSpent();
	
	memberType();
	
};

