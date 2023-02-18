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
        public int OriginalPage;

        //Constructor


        public Book(string name, string cover, bool hasBookMark, bool isOpen, float length, float price,
            int amountOfPages, int currentPage, int originalPage)
        {
            Name = name;
            Cover = cover;
            HasBookMark = hasBookMark;
            IsOpen = isOpen;
            Length = length;
            Price = price;
            AmountOfPages = amountOfPages;
            CurrentPage = currentPage;
            OriginalPage = originalPage;
        }

        public Book()
        {
        }

        public void Open()
        {
            IsOpen = true;
            if(HasBookMark == true)
            {
                Console.WriteLine("You have opened {0}. You are on page {1}.", Name, CurrentPage);
            }
            if (HasBookMark == false)
            {
                Console.WriteLine("You have opened {0}. You are on page {1}.", Name, CurrentPage);
            }
        }

        public void Close()
        {
            IsOpen = false;
            if (HasBookMark == true)
            {
                Console.WriteLine("You close the book on page {0}.", CurrentPage);
            }
            if (HasBookMark == false)
            {
                Console.WriteLine("You close the book on page {0}.", CurrentPage);
                CurrentPage = OriginalPage;
            }
        }

        public void Read()
        {
            if(IsOpen == true)
            {
                CurrentPage++;
                Console.WriteLine("You read a page, you are now on page {0}.", CurrentPage);
            }else
            {
                Console.WriteLine("You read the cover of {0}, it says {1} and has the price of ${2}.", Name, Cover, Price);
            }
        }

        public void BookMarkIn()
        {
            HasBookMark = true;
            Console.WriteLine("You have placed your bookmark on page {0}.", CurrentPage);

        }

        public void BookMarkOut()
        {
            Console.WriteLine("You have pulled out your bookmark.");
            HasBookMark = false;
        }



    }
}
