#include "stdafx.h"
#include "bookType.h"
#include <iostream>


bookType::bookType()
{
	title = "";
	stock = 0;
	ISBN = "";
	price = 0.0;
	author[4] = { "" };
	
}


string bookType::getTitle(){
	return title;
}
void bookType::setTitle(string t){

}
bool bookType::checkTitle(string t){
	return(t == title);
}

void bookType::updateStock(int s){
	stock = s;
}
int bookType::getStock(){
	return stock;
}


void bookType::updateISBN(string i){
	ISBN = i;
}
string bookType::getISBN(){
	return ISBN;
}

void bookType::updatePrice(double p){
	price = p;
}
double bookType::getPrice(){
	return price;
}


string bookType::getAuthors(int numAut){
	return author[numAut];
}

void bookType::updateAuthor(int num, string a){
	author[num - 1] = a;

}
