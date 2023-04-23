#pragma once
#include <iostream>
#include <string>

using namespace std;

class Animal {
public:
	int weight = 0;
	int height = 0;
	Animal() {
		printf("Animal()\n");
	}
	Animal(Animal& obj) {
		printf("Animal(Animal& obj)\n");
	}
	virtual ~Animal() {
		printf("~Animal()\n");
	}

	virtual bool isA(const string& who) {
		return who == "Animal";
	}
	virtual string classname() {
		return "Animal";
	}
	virtual string voice() {
		return "no voice\n";
	}
	string whoAreYou() {
		return "I am animal!\n";
	}
	void gainWeight(int w) {
		printf("gainWeight(%d)\n", w);
		weight += w;
	}
	virtual void gainHeight(int h) {
		printf("gainHeight(%d)\n", h);
		height += h;
	}
	void eat(int size) {
		printf("eat(%d)\n", size);
		gainWeight(size);
		gainHeight(size);
	}
};
class Cat : public Animal {
public:
	Cat() {
		printf("Cat()\n");
	}
	Cat(Cat& obj) {
		printf("Cat(Cat& obj)\n");
	}
	~Cat() {
		printf("~Cat()\n");
	}


	bool isA(const string& who) override {
		return (who == "Animal") || (who == "Cat");
	}
	string classname() override {
		return "Cat";
	}
	string voice() {
		return "meow\n";
	}
	string whoAreYou() {
		return "I am cat!\n";
	}
	void gainWeight(int w) {
		printf("gainWeight(%d)\n", w/2);
		weight += w/2;
	}
	void gainHeight(int h) {
		printf("gainHeight(%d)\n", h / 5);
		weight += h / 5;
	}
	void catchMouse() {
		printf("catchMouse()\n");
	}
};

class Dog : public Animal {
public:
	Dog() {
		printf("Dog()\n");
	}
	~Dog() {
		printf("~Dog()\n");
	}


	bool isA(const string& who) override {
		return (who == "Animal") || (who == "Dog");
	}
	string classname() override {
		return "Dog";
	}
	string voice() {
		return "wow\n";
	}
	string whoAreYou() {
		return "I am dog!\n";
	}
	void toGainWeight(int w) {
		printf("toGainWeight(%d)\n", w / 5);
		weight += w / 5;
	}
	void gainHeight(int h) {
		printf("gainHeight(%d)\n", h / 2);
		weight += h / 2;
	}
	void chaseCat() {
		printf("chaseCat()\n");
	}
};