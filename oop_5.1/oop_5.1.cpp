#include <vector>
#include "Object.h"

using namespace std;

void in1(Base a)
{
	printf("in1(Base a)\n");
}

void in2(Base* a)
{
	printf("in2(Base* a)\n");
}

void in3(Base& a)
{
	printf("in3(Base& a)\n");
}

Base out1()
{
	Base o("out1");
	o.x = 1;
	return o;
}
Base out2()
{
	Base* po = new Base("out2");
	po->x = 2;
	return *po;
}
Base* out3()
{
	Base o("out3");
	o.x = 3;
	return &o;
}
Base* out4()
{
	Base* po = new Base("out4");
	po->x = 4;
	return po;
}
Base& out5()
{
	Base o("out5");
	o.x = 5;
	return o;
}
Base& out6()
{
	Base* po = new Base("out6");
	po->x = 6;
	return *po;
}

int main() {

	Base* b = new Base();
	printf("\n");
	Desc* d = new Desc();

	printf("----------------------\n");
	in1(*b);
	in2(b);
	in3(*b);
	printf("\n");
	in1(*d);
	in2(d);
	in3(*d);
	printf("----------------------\n");

	delete d;
	delete b;
	printf("\n");

	Base o;
	Base* po = nullptr;

	printf("----------------------\n");
	o = out1();
	//printf("%d\n", o.x);
	o = out2();
	//printf("%d\n", o.x);
	po = out3();
	//printf("%d\n", po->x);
	po = out4();
	//printf("%d\n", po->x);
	o = out5();
	//printf("%d\n", o.x);
	o = out6();
	//printf("%d\n", o.x);
	printf("----------------------\n");
	delete po;
	return 0;
}