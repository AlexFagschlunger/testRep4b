using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkedList.models
{
    class Car
    {
        public string brand { get; set; }
        public string colour { get; set; }


        private decimal _price;

        public decimal price
        {
            get { return this._price; }
            set
            {
                if(value >= 0.0m)
                {
                    this._price = value;
                }
            }
        }

        public Car() : this("", "", 0.0m) { }

        public Car(string brand, string colour, decimal price)
        {
            this.brand = brand;
            this.colour = colour;
            this.price = price;
        }

        public override string ToString()
        {
            return this.brand + " " + this.colour + " " + this.price;
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as Car);
        }
        public bool Equals(Car obj)
        {
            if(obj == null)
            {
                return false;
            }

            if((obj.brand == this.brand) && (obj.colour == this.colour) && (obj.price == this.price))
            {
                return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            // Startwert ist eine Primzahl
            var hashCode = -1786895991;

            // die 2. Zahl ist ebenfalls eine Primzahl
            // es müssen die gleichen Felder (Firstname, Lastname, Birthdate) wie in Equals() verwendet werden 
            hashCode = hashCode * -1521134295 + EqualityComparer<String>.Default.GetHashCode(brand);

            hashCode = hashCode * -1521134295 + EqualityComparer<String>.Default.GetHashCode(colour);

            hashCode = hashCode * -1521134295 + EqualityComparer<decimal>.Default.GetHashCode(price);

            return hashCode;
        }

    }
}
