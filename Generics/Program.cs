using System;
using System.IO;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        //Generics
        //TODO Create a class called "Storage" that has a generic Type "T".
        //TODO In your class create a property List called "Bin". Set the list type to "T".
        //TODO Create two more classes. One class called "Equipment". The second class called "Food".
        //TODO create two instances of type Storage in the Main method. First Instance will hold type "<Equipment>". The second instance will hold "<food>".
        //TODO create some instanes of type Food and Equipment and Add them the correct storage bins.

        //TODO In the program class Create a static void method called CountToNum that has a generic type called "T".
        //TODO Give the method a T paramter called "n".
        //TODO In the method scope make the method print all the numbers from 0 to "n".
        //TODO Call the method in the Main first by giving it a float number. Then call it again by giving it a double number.




        static void Main(string[] args)
        {

            var numbers = new int[] { 1, 2, 3, 4, 5, 6 };

            Storage<Equipment> store1 = new Storage<Equipment>();
            Storage<Food> store2 = new Storage<Food>();

            Equipment equip1 = new Equipment();
            store1.Bin.Add(equip1);
            Equipment equip2 = new Equipment();
            store1.Bin.Add(equip2);
            Equipment equip3 = new Equipment();
            store1.Bin.Add(equip3);

            Food food1 = new Food();
            store2.Bin.Add(food1);
            Food food2 = new Food();
            store2.Bin.Add(food2);
            Food food3 = new Food();
            store2.Bin.Add(food3);

            CountToNum(1.001f);
            CountToNum(5.6);

            
            var newArr = numbers.SortArray();
            //newArr = newArr.FindOdds();

            foreach(var n in newArr)
            {
                Console.WriteLine(n);
            }
        }

        static void CountToNum<T>(T n)
        {
            for (int i = 0; i < Convert.ToInt32(n); i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(n);
        }
        


        //ExtensionMethods
        //TODO Create a static class called "ExtensionMethods"
        //TODO in your new class create an extension method called "FindOdds" this method should take an IEnumerable of type integers and return a new IEnumerable of only the odd integers. Use linq in the scope to find odd numbers.

        //TODO Create an extension method called "SortArray". This method will take an array of type T. Then it will use a LINQ statement
        //TODO call both extension methods in the Main. Use the method on the numbers Array.


    }
}
