using System;
using System.Collections.Generic;
using System.Text;

namespace PenProject
{
    public class Pen
    {
        //Properties
        public string Name;
        public string Color;
        public bool HasCap;
        public bool IsEmpty;
        public float Length;
        public float Price;
        public int NumberInBox;
        public float InkLevelPercent;

        //Constructor


        public Pen(string name, string color, bool hasCap, bool isEmpty, float length, float price, int numberInBox, float inkLevelPercent)
        {
            Name = name;
            Color = color;
            HasCap = hasCap;
            IsEmpty = isEmpty;
            Length = length;
            Price = price;
            NumberInBox = numberInBox;
            InkLevelPercent = inkLevelPercent;
        }

        public void Uncap()
        {
            HasCap = false;
            Console.WriteLine("{0} has been uncapped!, Name");
        }

        public void Cap()
        {
            HasCap = true;
            Console.WriteLine("The cap has been put on {0}!", Name);
        }

        public void Throw()
        {
            Console.WriteLine("You threw {0} and {1} ink is on the floor now!!!", Name, Color);
        }
        public void CheckInkLevel()
        {
            Console.WriteLine("{0} has {1}% ink remaining.", Name, InkLevelPercent);
        }
        public void Write()
        {
            if(HasCap == true)
            {
                Console.Write("You cannot with {0}. The cap is stil on!!!", Name);
            }
            if(InkLevelPercent < 0)
            {

            }

            Console.WriteLine("{0} has {1}% ink remaining.", Name, InkLevelPercent);
        }

    }
}
