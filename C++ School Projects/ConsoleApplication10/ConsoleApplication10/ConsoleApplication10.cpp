// ConsoleApplication10.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "bookType.cpp"
#include <string>
#include <conio.h>
#include <iostream>

using namespace std;


int main()
{

	
	bookType books[10];
	string title = "";
	string ISBN = "";
	int stock = 0;
	double price = 0.0;
	int numB = 0;
	cout << "How many books are there?";
	cin >> numB;
	// Setting all the information
	for (int i = 0; i < numB; i++){
		cout << "Enter the title: ";
		cin >> title;
		books[i].setTitle(title);
		cout << "Enter book ISBN: ";
		cin >> ISBN;
		books[i].updateISBN(ISBN);
		int auths = 0;
		cout << "How many authors are there?" << endl;
		cin >> auths;
		string authName = "";
		for (int j = 0; j < auths; j++){
			cout << "Enter name of author " << j + 1 << endl;
			cin >> authName;
			books[i].updateAuthor(j, authName);
		}
		cout << "Enter the book price: ";
		cin >> price;
		books[i].updatePrice(price);
	}
	int Titleindex = 0;
	cout << "Enter a title to search for: ";
	cin >> title;
	int found = 0;
	for (int i = 0; i < 10; i++){
		if (books[i].getTitle() == title)
		{
			cout << "Title found at book numer: " << i << endl;
			Titleindex = i;
			found = 1;
		}
	}
	if (found != 1){
		cout << "Title not found" << endl;
	}

	int ISBNindex = 0;
	cout << "Enter an ISBN to search for: ";
	cin >> ISBN;
	found = 0;
	for (int i = 0; i < 10; i++){
		if (books[i].getISBN() == ISBN)
		{
			cout << "ISBN found at book numer: " << i << endl;
			ISBNindex = i;
			found = 1;
		}
	}
	if (found != 1){
		cout << "ISBN not found" << endl;
	}
	string upTitle = "";
	int upCopies = 0;
	cout << "==Update Number of Copies for a book==" << endl << endl;
	cout << "Enter book title to update: ";
	cin >> upTitle;
	cout << "Enter number of copies to update: ";
	cin >> upCopies;
	found = 0;
	for (int i = 0; i < 10; i++){
		if (books[i].getTitle() == upTitle)
		{
			books[i].updateStock(upCopies);
			found = 1;
			cout << "Book " << books[i].getTitle() << " now has " << books[i].getStock << " copies in stock." << endl;
		}
	}
	if (found != 1){
		cout << "Copy update failed, title not found." << endl;
	}
	_getch();
	return 0;
}
