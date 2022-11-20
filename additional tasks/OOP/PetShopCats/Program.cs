/* Написать класс кошки для зоомагазина со всеми нужными полями и методом, 
который выводит информацию в консоль. В классе обязательно должен быть конструктор. 
Для проверки работы можно создать пару экземпляров кошек и вывести информацию о них.
*/
DateTime FluffyBirth = new DateTime(2018, 10, 15);
PetShopCat Fluffy = new PetShopCat("Fluffy", "Birman", Gender.Male, "White", FluffyBirth, 15600.00);

DateTime MeatballBirth = new DateTime(2020, 05, 8);
PetShopCat Meatball = new PetShopCat("Meatball", "Bobtail", Gender.Female, "Red", MeatballBirth, 14200.00);

Fluffy.ShowCharacteristics();
Meatball.ShowCharacteristics();

Fluffy.Eat("fish");
Fluffy.Meow();
Fluffy.Scratch();

Meatball.ShowFoodPreferences();
Meatball.Eat("meatball");
Meatball.Sleep();

enum Gender
{
	Male,
	Female
};