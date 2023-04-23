// oop2.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
#include <iostream>
#include<conio.h>

class Line {
protected:
    int x1, y1, x2, y2;
public:
    
    //конструктор по умолчанию
    Line() {
        x1 = 0;
        y1 = 0;
        x2 = 0;
        y2 = 1;
        printf("Line() - p1=(0; 0), p2=(0; 1)\n");
    }
    //конструктор с парамеетром
    Line(int x1, int y1, int x2, int y2) {
        this->x1 = x1;
        this->y1 = y1;
        this->x2 = x2;
        this->y2 = y2;
        printf("Line(int x1, int y1, int x2, int y2) - p1=(%d; %d), p2=(%d; %d)\n", x1, y1, x2, y2);
    }
    //конструктор копирования
    Line(const Line& p) {
        x1 = p.x1;
        y1 = p.y1;
        x2 = p.x2;
        y2 = p.y2;
        printf("Line(const Line& p) - p1=(%d; %d), p2=(%d; %d)\n", x1, y1, x2, y2);
    }
    //деструктор по умолчанию
    ~Line() {
        printf("~Line() - p1=(%d; %d), p2=(%d; %d)\n", x1, y1, x2, y2);
    }
    //защищенные свойства можно использовать в методах
    void move(int _x, int _y) {
        x1 = x1 + _x;
        y1 = y1 + _y;
        x2 = x2 + _x;
        y2 = y2 + _y;
        printf("move(%d, %d) - p1=(%d; %d), p2=(%d; %d)\n", _x, _y, x1, y1, x2, y2);
    }
    void reset();
};

void Line::reset() {
    x1 = 0;
    y1 = 0;
    x2 = 0;
    y2 = 1;
    printf("reset() - p1=(0; 0), p2=(0; 1)\n");
}

class ColorLine: public Line {
protected:
    int color;
public:
    ColorLine() {
        x1 = 0;
        y1 = 0;
        x2 = 0;
        y2 = 1;
        color = 0;
        printf("ColorLine() - p1=(0; 0), p2=(0; 1), color=0\n");
    }
    ColorLine(int x1, int y1, int x2, int y2, int color): Line(x1, y1, x2, y2) {
        this->color = color;
        printf("ColorLine(int x1, int y1, int x2, int y2, int color) - p1=(%d; %d), p2=(%d; %d), color=%d\n", x1, y1, x2, y2, color);
    }
    ColorLine(const ColorLine& p) {
        x1 = p.x1;
        y1 = p.y1;
        x2 = p.x2;
        y2 = p.y2;
        color = p.color;
        printf("ColorLine(const ColorLine& p) - p1=(%d; %d), p2=(%d; %d), color=%d\n", x1, y1, x2, y2, color);
    }
    ~ColorLine() {
        printf("~ColorLine() - p1=(%d; %d), p2=(%d; %d), color=%d\n", x1, y1, x2, y2, color);
    }
    //защищенные свойства можно использовать в методах
    void ColorChange(int _color) {
        color = _color;
        printf("ColorChange(%d) - p1=(%d; %d), p2=(%d; %d), color=%d\n", color, x1, y1, x2, y2, color);
    }
};

class Corner {
protected:
    Line* s1;
    Line* s2;
public:
    Corner() {
        s1 = new Line;
        s2 = new Line;
        printf("Corner()\n");
    }
    Corner(int x1, int y1, int x2, int y2, int _x1, int _y1, int _x2, int _y2) {
        s1 = new Line(x1, y1, x2, y2);
        s2 = new Line(_x1, _y1, _x2, _y2);
        printf("Corner(int x1, int y1, int x2, int y2, int _x1, int _y1, int _x2, int _y2)\n");
    }
    Corner(const Corner& s) {
        //s1 = s.s1;          поч?
        //s1 = s.s1;
        s1 = new Line(*(s.s1));
        s2 = new Line(*(s.s2));
        printf("Corner(const Corner& s)\n");
    }
    ~Corner() {
        delete s1;
        delete s2;
        printf("~Corner()\n");
    }
};

int main()
{
    setlocale(LC_ALL, "ru");
    printf("\tCтатическое создание объектов:\n");
    //a1 не удаляем
        Line a1;  
    {
        Line a2(0, 0, 3, 3);
        Line a3(a2);
    }

    printf("\n\tДинамическое создание объектов:\n");
    Line* a4 = new Line;
    Line* a5 = new Line(1, 1, 4, 4);
    Line*a6 = new Line(a1);
    Line* a7 = new Line(*a5);
    //a7 не удаляем
    delete a4;
    delete a5;
    delete a6;

    printf("\n\tИспользование методов:\n");
    //a7->x1;
    //не можем обратиться к свойству, т к оно задано не публично
    a1.move(2, 1);
    a7->reset();
    a7->move(1, 1);

    delete a7;

    printf("\n\tСтатистическое создание объектов дочернего класса:\n");
    ColorLine b;

    printf("\n\tДинамическое создание объектов дочернего класса:\n");
    ColorLine* b1 = new ColorLine;
    ColorLine* b2 = new ColorLine(2, 2, 5, 5, 9);
    ColorLine* b3 = new ColorLine(b);

    //b2 не удаляем
    delete b1;
    delete b3;

    printf("\n\tИспользование методов у дочернего класса:\n");
    b.move(2, 3);
    b.ColorChange(15);
    b2->reset();
    b2->ColorChange(7);

    delete b2;

    printf("\n\tСоздаем объект дочернего класса от класса-потомка:\n");
    //Line* b4 = new ColorLine(3, 3, 6, 6, 1); 
    //нельзя создать потомка от наследника, только наоборот
    Line* b4 = new ColorLine(3, 3, 6, 6, 1);
    delete b4;
    
    printf("\n\tCтатическое создание объектов класса с композицией:\n");  //когда хранится указатель на объект другого класса
    Corner c(4, 4, 7, 7, 5, 5, 8, 8);

    printf("\n\tДинамическое создание объектов класса с композицией:\n");
    Corner* c1 = new Corner;
    Corner* c2 = new Corner(c);
    delete c1;
    delete c2;

    return 0;
}