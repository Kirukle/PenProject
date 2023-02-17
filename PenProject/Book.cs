using System;
using System.Collections.Generic;
using System.Text;

namespace PenProject
{
    public class Book
    {
        //Properties
        public string Name;
        public string Cover;
        public bool HasBookMark;
        public bool IsOpen;
        public float Length;
        public float Price;
        public int AmountOfPages;
        public int CurrentPage;

        //Constructor


        public Book(string name, string cover, bool hasBookMark, bool isOpen, float length, float price, int amountOfPages, int currentPage)
        {
            Name = name;
            Cover = cover;
            HasBookMark = hasBookMark;
            IsOpen = isOpen;
            Length = length;
            Price = price;
            AmountOfPages = amountOfPages;
            CurrentPage = currentPage;
        }
        public void Open()
        {
            IsOpen = true;
            Console.WriteLine("You have opened {0}. You are on page {1}.", Name, );
        }

        public void Read()
        {
            if(IsOpen == true)
            {
                if(HasBookMark == true)
                {
                    Console.WriteLine("You mark",)
                }
                else
                {

                }
            }

            {
                Console.WriteLine("You read the cover of {0}, it says {1} and has the price of {2}.", Name, Cover, Price);
            }
        }

        public void BookMark()
        {

        }

     
    }
}
