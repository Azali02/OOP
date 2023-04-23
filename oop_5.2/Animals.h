#pragma once
#include <iostream>
#include <string>

using namespace std;

class Animal
{
public:
	Animal()
	{
		printf("Animal()\n");
	}
	virtual void talk()
	{
		cout << endl;
	}

	virtual ~Animal()
	{
		printf("~Animal()\n");
	}
};

class Cat : public Animal
{
public:
	Cat()
	{
		printf("Cat()\n");
	}
	void talk() override
	{
		printf("Meow meow\n");
	}

	~Cat() override
	{
		printf("~Cat()\n");
	}
};

class Dog : public Animal
{
public:
	Dog()
	{
		printf("Dog()\n");
	}
	void talk() override
	{
		printf("Bow wow\n");
	}

	~Dog() override
	{
		printf("~Dog()\n");
	}
};