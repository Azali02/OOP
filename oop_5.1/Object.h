#pragma once
#include <iostream>
#include <string>

using namespace std;

class Base
{
public:
	int x = 0;
	Base()
	{
		printf("Base()\n");
		x = 0;
	}
	Base(const string& s)
	{
		printf("Base(%s)\n", s.c_str());
	}
	Base(int a)
	{
		printf("Base(int %d)\n", a);
		x = a;
	}
	Base(const Base& a)
	{
		printf("Base(a)\n");
		x = a.x;
	}
	virtual ~Base()
	{
		printf("~Base()\n");
	}
};

class Desc : public Base
{
public:
	int y;
	Desc()
	{
		printf("Desc()\n");
		y = 0;
	}
	Desc(const string& s)
	{
		printf("Desc(%s)\n", s.c_str());
	}
	Desc(int a)
	{
		printf("Base(int %d)\n", a);
		y = a;
	}
	Desc(const Desc& a)
	{
		printf("Desc(a)\n");
		y = a.y;
	}
	~Desc()
	{
		printf("~Desc()\n");
	}
};