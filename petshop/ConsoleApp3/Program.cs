using ConsoleApp3;
using System;

Cathouse cathouse1=new();
Cat cat1 = new Cat(3, false, "mestan", 15, 10, 20);
Cat cat2 = new Cat(6, true, "garfield", 20, 20, 30);
Cat cat3 = new Cat(15, false, "mestan2", 15, 10, 20);
Cat cat4 = new Cat(6, true, "garfield2", 20, 20, 30);
Cat cat5 = new Cat(15, false, "mestan3", 15, 10, 20);
Cat cat6 = new Cat(6, true, "garfield3", 20, 20, 30);
cathouse1.AddCat(cat1);
cathouse1.AddCat(cat2);
Cathouse cathouse2=new();
cathouse2.AddCat(cat3);
cathouse2.AddCat(cat4);
Cathouse cathouse3 = new();
cathouse3.AddCat(cat5);
cathouse3.AddCat(cat6);
Petshop petshop= new();

petshop.Addhouse(cathouse1);
petshop.Addhouse(cathouse2);
petshop.Addhouse(cathouse3);
int chs1;
string nname;
int age;
bool gender;
int Energy;
double Price;
int mealQuantitiy;
int bc=0;
double allpr = 0;
while (true)
{
    Console.Clear();
    Console.WriteLine("Welcome Cat Petshop");
    Console.WriteLine("1.See all cats.");
    Console.WriteLine("2.Add cat.");
    Console.WriteLine("3.Buy cat(by nickname)");
    Console.WriteLine("4.Let the cats play");
    Console.WriteLine("5.All cats prices;");
    Console.WriteLine("0.Quit");
    Console.WriteLine("Enter your choice: ");
    chs1 = int.Parse(Console.ReadLine());
    if (chs1 == 1)
    {
        Console.Clear();
        foreach (var item in petshop.cathause)
        {
            foreach (var item1 in item.cats)
            {
                Console.WriteLine($"Name:{item1.nickname}");
                Console.WriteLine($"Age:{item1.age}");
                Console.WriteLine($"Energy:{item1.Energy}");
                if (item1.gender == false) Console.WriteLine("Gender: Female");
                else Console.WriteLine("Gender: Male");
                Console.WriteLine($"Price:{item1.Price}");
                Console.WriteLine($"Meal Quantitiy: {item1.mealQuantitiy}");
                Console.WriteLine("\n");
            }
        }
        Console.ReadLine();
    }
    else if (chs1 == 2)
    {
        Console.Clear();
        Console.WriteLine("Enter Nickname");
        nname = Console.ReadLine();
        Console.WriteLine("Enter age");
        age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Energy");
        Energy = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Gender");
        gender = Console.ReadLine() == "Male" ? true : false;
        Console.WriteLine("Enter Price");
        Price = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Meal Quantitiy");
        mealQuantitiy = int.Parse(Console.ReadLine());
        Console.WriteLine("Added");
        Console.ReadLine();
    }
    else if (chs1 == 3)
    {
        Console.Clear();
        Console.WriteLine("Enter Nickname");
        nname = Console.ReadLine();
        foreach (var item in petshop.cathause)
        {
            foreach (var item1 in item.cats)
            {
                if (item1.nickname == nname)
                {
                    item.RemoveByNickname(nname);
                    bc = 1;
                }
            }
        }
        if (bc == 1) Console.WriteLine("Tebrikler");
        else Console.WriteLine("Bele bir pishik yoxdur");
        Console.ReadLine();
    }
    else if (chs1 == 4)
    {
        Console.Clear();
        foreach (var item in petshop.cathause)
        {
            foreach (var item1 in item.cats)
            {
                while (item1.Energy != 0)
                {
                    item1.Play();
                }
                Console.WriteLine($"{item1.nickname} oynadi ve yoruldu yatacaq\n");
                for (int i = 0; i < 10; i++)
                {
                    item1.Sleep();
                }
                Console.WriteLine($"{item1.nickname} yuxudan durdu ve yemek yeyir\n");
                for (int i = 0; i < 10; i++)
                {
                    item1.Eat();
                }
            }
        }
        Console.ReadLine();
    }
    else if (chs1 == 5)
    {
        foreach (var item in petshop.cathause)
        {
            foreach (var item1 in item.cats)
            {
                allpr += item1.Price;
            }
        }
        Console.WriteLine($"Butun pishiklerin deyeri: {allpr}");
        Console.ReadLine();
    }
    else break;
}
