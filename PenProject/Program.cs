using System;

namespace PenProject
{
    class Program
    {
       static void Main(String[] args)
        {
            Book divGradCurlAndAllThat = new Book();
            divGradCurlAndAllThat.Name = "DIV, GRAD, CURL, AND ALL THAT";
            divGradCurlAndAllThat.Cover = "DIV, GRAD, CURL, AND ALL THAT By H.M SCHEY,  An Informal Text on Vector Calculus";
            divGradCurlAndAllThat.HasBookMark = false;
            divGradCurlAndAllThat.AmountOfPages = 162;
            divGradCurlAndAllThat.Length = 13.5f;
            divGradCurlAndAllThat.CurrentPage = 1;
            divGradCurlAndAllThat.Price = 6.99f;
            divGradCurlAndAllThat.IsOpen = false;

            //Book divGradCurlAndAllThat = new Book("DIV, GRAD, CURL, AND ALL THAT", "DIV, GRAD, CURL, AND ALL THAT By H.M SCHEY,  An Informal Text on Vector Calculus",
            //    false, 162, 13.5f, 1, 6.99f, false);
            
            
            
        }


    }
}
