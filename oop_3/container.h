#include<iostream>

//������ ������ ����������, ���������� �����������-������, �������-������
template<class T> class Storage {
private:
	//�������������� ������ ������� � ��������� �� ��� ������
	T* mas;
	int size;
public:
	Storage() {
		size = 1;
		mas = new T[size];
	}
	Storage(int a) {
		size = a;
		mas = new T[size];
	}
	Storage(const Storage& copy) {
		size = copy.size;
		mas = new T[size];
		for (int i = 0; i < size; ++i)
			mas[i] = copy.mas[i];
	}
	~Storage() {
		delete[] mas;
	}
	int getSize();
	void pushObject(int ind, T* value);
	void setObject(int ind, T* value);
	T* deleteObject(int ind);
	T* getObject(int ind);
};

//��������� ������� ����������
template<class T>
int Storage<T>::getSize() {
	return size;
}

//���������� �������� � ��������� ��� ������������ ��������
template<class T>
void Storage<T>::pushObject(int ind, T* value) {
	int Tind = ind;
	if (Tind < 0)
		Tind = 0;
	else if (Tind > size)
		Tind = size;
	T* newmas = new T[size + 1];
	for (int i = 0; i < Tind; i++)
		newmas[i] = mas[i];
	newmas[Tind] = *value;
	for (int i = Tind + 1; i < size; i++)
		newmas[i] = mas[i - 1];
	delete[] mas;
	mas = newmas;
	size++;
}

//���������� �������� ������� ��������
template<class T>
void Storage<T>::setObject(int ind, T* value) {
	if (size == 0)
		return;
	if (ind <= 0)
		mas[0] = *value;
	else if (ind >= size)
		mas[size - 1] = *value;
	else
		mas[ind] = *value;
}

//���������� �������� (� ���������)
template<class T>
T* Storage<T>::deleteObject(int ind) {
	int Tind = ind;
	if (size == 1)
		return nullptr;
	if (Tind >= size)
		Tind = size - 1;
	else if (Tind < 0)
		Tind = 0;
	T* newmas = new T[size - 1];
	T e = mas[Tind];
	for (int i = 0; i < size; i++) {
		if (i < Tind)
			newmas[i] = mas[i];
		else if (i > Tind)
			newmas[i - 1] = mas[i];
	}
	delete[] mas;
	mas = newmas;
	size--;
	return &e;
}

//��������� (��� ��������)
template<class T>
T* Storage<T>::getObject(int ind) {
	if (size == 0)
		return nullptr;
	if (ind >= size)
		return &mas[size - 1];
	else if (ind <= 0)
		return &mas[0];
	return &mas[ind];
}
