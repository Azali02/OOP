#include<iostream>
#include"container.h"
#include<time.h>

//Родительский класс
class Test {
protected:
	int value;
public:
	Test() {
		value = 0;
	}
	//присвоение значения value
	void setValue(int value) {
		this->value = value;
	}
	//получие значения value
	int getValue() {
		return value;
	}
};

//Дочерний класс
class Daughtertest : public Test {
public:
	//задаем значение value = 5
	Daughtertest() : Test() { value = 5; }
};

int main() {
	srand(time(0));
	setlocale(LC_ALL, "ru");
	Storage<Test> a;
	int c = 0;
	int iN = 100;
	while (c < 3) {
		long double time_spent = 0;
		clock_t begin = clock();
		for (int i = 0; i < iN; i++) {
			int x = rand() % 3;
			if (x == 0) //удаление объекта
				a.deleteObject(rand() % a.getSize());
			if (x == 1) //вставка объекта
				a.pushObject(rand() % a.getSize(), new Daughtertest());
			if (x == 2) { //вызов случайного метода объекта
				int x2 = rand() % 2;
				if(x == 0) //вызов метода getValue
					a.getObject(rand() % a.getSize())->getValue();
				if (x == 0) //вызов метода setValue
					a.getObject(rand() % a.getSize())->setValue(rand() % 100);
			}
		}
		clock_t end = clock();
		time_spent += (double)(end - begin) / CLOCKS_PER_SEC;
		printf("Количество итераций: %i;\nВремя выполнения: %lf сек\n\n", iN, time_spent);
		c++;
		iN *= 10;
	}

	getchar();
	return 0;
}
