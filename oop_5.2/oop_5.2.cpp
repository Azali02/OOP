#include "Animals.h"
#include <vector>

using namespace std;

void method(Animal* who)
{
	who->talk();
}

void method(shared_ptr<Animal> who)
{
	who->talk();
}

unique_ptr<Animal> makeCat()
{
	//return new Cat();
	return make_unique<Cat>();
}

int main()
{
	unique_ptr<Animal> cat = make_unique<Cat>();
	shared_ptr<Animal> dog = make_unique<Dog>();
	printf("-----------------\n");
	{
		//unique_ptr<Animal> tmp_cat = cat;
		auto tmp_cat = makeCat();
		shared_ptr<Animal> tmp_dog = dog;
	}
	printf("-----------------\n");
	//delete *tmp_cat, tmp_dog(но не *tmp_dog)
	method(cat.get());
	method(dog);
	return 0;
}
//delete *cat, *dog