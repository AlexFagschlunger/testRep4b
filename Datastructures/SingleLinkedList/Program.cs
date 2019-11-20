using System;
using SingleLinkedList.models;

namespace SingleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klasse Person testen
            
            Person p = new Person("Fabo", "Eggo", new DateTime(2020, 6, 4));
            Person p2 = new Person("Christian", "Hölbling", new DateTime(2000, 4, 24));
            Person p3 = new Person("Tobias", "Flöckinger", new DateTime(2000, 4, 24));
            Person p4 = new Person("Thomas", "Mairer", new DateTime(2000, 4, 24));
            Person p5 = new Person("Thomas", "Mairer", new DateTime(2000, 4, 24));

            SingleLinkedList<Person> sll = new SingleLinkedList<Person>();

            sll.Add(p);
            sll.Add(p2);
            sll.Add(p3);
            sll.Add(p4);
            sll.AddAfter(p5, p);

            sll.ChangeItem(p2, new Person("Marcl", "Penzo", new DateTime(2002, 1, 25)));
            Console.WriteLine(sll);

            /*
        
            SingleLinkedListItem<Person> foundPerson = new SingleLinkedListItem<Person>();
            foundPerson = sll.Find(p3);
            if(foundPerson == null)
            {
                Console.WriteLine("Nicht gefunden.");
            }else { Console.WriteLine(foundPerson); }

            bool isStartItem;
            SingleLinkedListItem<Person> beforPerson = sll.FindItemBeforeItemToFind(p3, out isStartItem);
            if (isStartItem)
            {
                Console.WriteLine("Es existiert kein Eintrag vor dem gesuchten Eintrag.");
                Console.WriteLine("Die gesuchte Person ist im Starteintrag enthalten.");
            }
            else if (beforPerson != null)
            {
                Console.WriteLine("Item vor gesuchter Person existiert.");
                Console.WriteLine("Person vor der gesuchten Person lautet.");
                Console.WriteLine(beforPerson);
            }
            else
            {
                Console.WriteLine("gesuchte Person ist in dieser Liste nicht enthalten.");
            }
            */
            /*
            if(sll.Remove(null))
            {
                Console.WriteLine("Person wurde entfernt");
            }
            else
            {
                Console.WriteLine("Person wurde nicht entfernt - Parameter = null");
            }
            if (sll.Remove(p))
            {
                Console.WriteLine("Person wurde entfernt");
            }
            else
            {
                Console.WriteLine("Person wurde nicht entfernt - Liste ist leer");
            }
            sll.Add(p);
            sll.Add(p2);
            sll.Add(p3);
            sll.Add(p4);
            // 1. Fall
            if (sll.Remove(p3))
            {
                Console.WriteLine("Person wurde entfernt - Eintrag dazwischen wurde entfernt");
            }
            else
            {
                Console.WriteLine("Person wurde nicht entfernt - Eintrag dazwischen");
            }
            Console.WriteLine(sll); */

            // Console.WriteLine(p);
            /*
            Person p2 = new Person("Elias", "Rist", new DateTime(2000, 4, 24));
            Person p3 = new Person("Tobias", "Flöckinger", new DateTime(2000, 4, 24));

            if (p == p2)
            {
                Console.WriteLine("p und p2 sind gleich: ==");
            }
            else
            {
                Console.WriteLine("p und p2 sind nicht gleich: ==");
            }
            if (p.Equals(p2))
            {
                Console.WriteLine("p und p2 sind gleich: Equals");
            }
            else
            {
                Console.WriteLine("p und p2 sind nicht gleich: Equals");
            }
            if (p == p3)
            {
                Console.WriteLine("p und p3 sind gleich: == ");
            }
            else
            {
                Console.WriteLine("p und p3 sind nicht gleich: ==");
            }
            if (p.Equals(p3))
            {
                Console.WriteLine("p und p3 sind gleich: Equals");
            }
            else
            {
                Console.WriteLine("p und p3 sind nicht gleich: Equals");
            }

            Console.ReadKey();
            */
            /*
            // Klasse SingleLinkedListItem testen
            // generische Klasse verwenden
            SingleLinkedListItem<Person> item = new SingleLinkedListItem<Person>(p, null);
            // Console.WriteLine(item);

            // Klasse SLLI testen
            // Methode Add() testen
            SingleLinkedList<Person> singleLL = new SingleLinkedList<Person>();
            if (singleLL.Add(p))
            {
                Console.WriteLine("Person wurde hinzugefügt!");
            }
            else
            {
                Console.WriteLine("Person konnte nicht hinzugefügt werden!");
            }
            if (singleLL.Add(new Person("Tobias", "Flöckinger", new DateTime(2000, 8, 12))))
            {
                Console.WriteLine("Person wurde hinzugefügt!");
            }
            else
            {
                Console.WriteLine("Person konnte nicht hinzugefügt werden!");
            }

            /*
            string lastname = "";
            Console.WriteLine("Nachname eingeben: ");
            lastname = Console.ReadLine();
            singleLL.AddAfter(new Person("Alex", "Fagschlunger", new DateTime(2001, 12, 1)), lastname);
            */
            /*
            Console.WriteLine("komplette SLL ausgeben!");
            Console.WriteLine(singleLL);
            */

            Console.ReadKey();
        }
    }
}
