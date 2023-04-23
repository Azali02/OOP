#include <iostream>
#include <vector>
#include <ctime>
#include "Animals.h"

using namespace std;

void foo(Animal obj) {
	cout  << "foo(Animal obj) - " << obj.classname() << endl;
}
void boo(Animal* obj) {
	cout << "boo(Animal* obj) - " << obj->classname() << endl;
}
void too(Animal& obj) {
	cout << "too(Animal& obj) - " << obj.classname() << endl;
}

int main() {
	setlocale(LC_ALL, "ru");
	srand(time(nullptr));

	vector<Animal*> a(4);

	printf("Создание объектов класса Animal и классов-потомков:\n");
	a[0] = new Animal();
	a[1] = new Cat();
	a[2] = new Dog();
	int x = rand() % 3;
	switch(x) {
	case 0: 
		a[3] = new Animal();
		break;
	case 1: 
		a[3] = new Cat();
		break;
	case 2: 
		a[3] = new Dog();
		break;
	}

	printf("\nПерекрытие виртуального метода в классах-предках:\n");
	for (auto i : a)
		cout << i->voice();

	printf("\nПерекрытие невиртуального метода в классах-предках:\n");
	for (auto i : a)
		cout << i->whoAreYou();

	printf("\nВызов в методе eat() базового класса переопределенные методы gainWeight()-невиртуальный и gainHeight()-виртуальный:\n");
	for (auto i : a) {
		i->eat(10);
		cout << endl;
	}

	printf("\nНебезопасное приведение типов  с помощью static_cast и ручная проверка с помощью метода bool isA():\n");
	for (auto i : a)
		if (i->isA("Cat"))
			static_cast<Cat*>(i)->catchMouse();

	printf("\nБезопасное приведение типов с помощью dynamic_cast:\n");
	for (auto i : a) {
		Dog* d = dynamic_cast<Dog*>(i);
		if (d != nullptr)
			d->chaseCat();
	}

	printf("\nПередача объектов как параметров в функции:\n");
	foo(*a[0]);
	boo(a[0]);
	too(*a[0]);
	printf("\n");
	foo(*a[1]);
	boo(a[1]);
	too(*a[1]);

	cout << endl;
	for (auto i : a)
		delete i;
	return 0;
}