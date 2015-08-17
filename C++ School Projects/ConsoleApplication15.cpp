// ConsoleApplication15.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <conio.h>
#include <typeinfo>
#include <fstream>
#include <time.h>
#include <algorithm>

using namespace std;


class card
{
private:
	char value;
	char suit;
	int check;

public:
	card();
	char getValue();
	char getSuit();
	void showCard();
	card operator+(const card& c);
	void setCard();
	void setValue(char v);
	void setSuit(char h);
	


};

class deck :public card{
private:
	card cards[52];
	bool dealt[52];

public:
	deck();
	void loadDeck();
	void display();
	void shuffle();
	int randCard();
	void displayCard(int i);
	char getVal(int i);
};


int main(){
	/*
	card newCard;
	cout << newCard.getValue() << endl;
	cout << newCard.getSuit() << endl;
	newCard.showCard();
	cout << "SPACING: CARD TWWWWWOOOOO!" << endl << endl;
	card twoCard;
	twoCard.setCard();
	cout << twoCard.getValue() << endl;
	cout << twoCard.getSuit() << endl;
	twoCard.showCard();
	
	card threeCard;
	threeCard = newCard + twoCard;
	cout << "CARD 3 WHAT WITH THE ADDING AND STUFF" << endl << endl;
	cout << static_cast<int>(threeCard.getValue()) << endl;
	cout << threeCard.getSuit() << endl;
	threeCard.showCard();
	*/
	cout << "Time for some BLACKJACK!" << endl;
	int hitCheck = 1;
	int val1 = 0;
	int val2 = 0;
	int index = 0;
	int index2 = 0;
	int totalCard = 0;
	card newCard;
	deck newDeck;
	newDeck.loadDeck();
	newDeck.shuffle();
	index = newDeck.randCard();
	cout << "Your card:" << endl;
	newDeck.displayCard(index);
	val1 = static_cast<int>(newDeck.getVal(index));
	totalCard = val1;
	cout << "Your value: " << totalCard << endl;
	cout << endl;
	while (hitCheck == 1){
		cout << "Hit(1) or stay(2):";
		cin >> hitCheck;
		if (hitCheck == 1){
			index2 = newDeck.randCard();
			val2 = static_cast<int>(newDeck.getVal(index2));
			newDeck.displayCard(index2);
			cout << endl;
			totalCard+= val2;
			cout << "New value: " << totalCard;
		}
	}
	if (totalCard > 21){
		cout << "Bust!" << endl;
	}
	else{
		cout << "Your score is: " << totalCard;
	}
	_getch();
	return 0;
}

card::card(){
	value = 'o';
	suit = 'o';
	check = 0;
}
char card::getValue(){
	return value;
}
char card::getSuit(){
	return suit;
}

void card::showCard(){
	cout << value;
	if (suit == 'S' || suit == 's'){
		cout << char(6);
	}
	if (suit == 'C' || suit == 'c'){
		cout << char(5);
	}
	if (suit == 'H' || suit == 'h'){
		cout << char(3);
	}
	if (suit == 'D' || suit == 'd'){
		cout << char(4);
	}
	cout << " ";
}
card card::operator+(const card& c){
	card card;
	int card1 = 0;
	int card2 = 0;
	int temp = 0;
	if (value == '0' || value == 'J' || value == 'Q' || value == 'K' || value == 'j' || value == 'q' || value == 'k'){
		card1 = 10;
	}else if (value == 'A'){
		card1 = 11;
	}
	else{
		card1 = value - 48;
	}

	if (c.value == '0' || c.value == 'J' || c.value == 'Q' || c.value == 'K' || c.value == 'j' || c.value == 'q' || c.value == 'k'){
		card2 = 10;
	}
	else if (c.value == 'A'){
		card2 = 11;
	}
	else{
		card2 = c.value - 48;
	}
	temp = card1 + card2;
	card.value = temp;
	card.suit = suit;
	card.check = 1;
	return card;

}
void card::setCard(){
	char nValue = 'o';
	char nSuit = 'o';
	cout << "What is the card's value" << endl;
	cin >> nValue;
	cout << "What is thethe new card's suit:" << endl;
	cin >> nSuit;
	value = nValue;
	suit = nSuit;

}
void card::setValue(char v){
	value = v;
}
void card::setSuit(char h){
	suit = h;
}

deck::deck(){
	for (int i = 0; i < 52; i++){
		cards[i].setValue('o');
		cards[i].setSuit('o');
	}
}

void deck::loadDeck(){
	ifstream infile;
	infile.open("c:\\deck.txt");
	char v = 'o';
	char s = 'o';
	for (int i = 0; i < 52; i++){
		infile >> v;
		infile >> s;
		cards[i].setValue(v);
		cards[i].setSuit(s);
	}
		

}
void deck::display(){
	for (int i = 0; i < 52; i++){
		cards[i].showCard();
	}
	cout << endl;
}

void deck::displayCard(int i){
	
	cards[i].showCard();
	
	
}

char deck::getVal(int i){

	return cards[i].getValue();


}

void deck::shuffle(){
	card temp[52];
	for (int i = 0; i < 52; i++){
		temp[i].setValue(cards[i].getValue());
		temp[i].setSuit(cards[i].getSuit());
	}
	for (int i = 0; i < 52; i++){
		int r1 = rand() % 51;
		int r2 = rand() % 51;
			if (r1 != r2){
				swap(temp[r1], temp[r2]);
			}
	}
	for (int i = 0; i < 52; i++){
		cards[i].setValue(temp[i].getValue());
		cards[i].setSuit(temp[i].getSuit());
	}
}

int deck::randCard(){
	int r1 = rand() % 51;
	cards[r1].getSuit();
	cards[r1].getValue();
	return r1;
}

