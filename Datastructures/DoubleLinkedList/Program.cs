using System;
using DoubleLinkedList.models;

namespace DoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Audi", "Green", 15000.0m);
            Car car2 = new Car("VW", "Black", 20000.1m);
            Car car3 = new Car("Porsche", "Orange", 150000.9m);
            Car car4 = new Car("Fiat", "Pink", 5000.4m);
            Car car5 = new Car("Lambo", "Blue", 200000.8m);

            DoubleLinkedList<Car> dll = new DoubleLinkedList<Car>();

            dll.Add(car1);
            dll.Add(car2);
            dll.Add(car3);
            dll.Add(car4);
            dll.AddAfter(car5, car4);
            // dll.AddBefore(car5, car4);

            // dll.Remove(car3);

            Car data = new Car("Opel", "White", 1500.0m);

            dll.Change(car5, data);

            Console.WriteLine(dll);

            DoubleLinkedListItem<Car> findItem = new DoubleLinkedListItem<Car>();
            findItem = dll.Find(car1);
            Console.WriteLine(findItem);

            Console.ReadKey();
        }
    }
}
