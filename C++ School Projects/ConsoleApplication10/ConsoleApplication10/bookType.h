#pragma once
#include <string>

using namespace std;
class bookType
{

private:
	string title;
	string author[4];
	string publisher;
	string ISBN;
	double price;
	int stock;
	int numAuthors;

public:
	
	string getTitle();
	void setTitle(string t);
	bool checkTitle(string t);

	
	void updateStock(int s);
	int getStock();

	
	void updateISBN(string i);
	string getISBN();

	
	void updatePrice(double p);
	double getPrice();

	void setAuthors();
	string getAuthors(int numAut);
	void updateAuthor(int num, string a);

	bookType();
	

};

