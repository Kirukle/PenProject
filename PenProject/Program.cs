using System;

namespace PenProject
{
    public class Program
    {
       static void Main(String[] args)
        {
            Book Crucible = new Book();
            Crucible.Name = "DIV, GRAD, CURL, AND ALL THAT";
            Crucible.Cover = "DIV, GRAD, CURL, AND ALL THAT By H.M SCHEY," +
                "  An Informal Text on Vector Calculus";
            Crucible.HasBookMark = false;
            Crucible.AmountOfPages = 162;
            Crucible.Length = 13.5f;
            Crucible.CurrentPage = 1;
            Crucible.Price = 6.99f;
            Crucible.IsOpen = false;

            Book divGradCurlAndAllThat = new Book("DIV, GRAD, CURL, AND ALL THAT", "DIV, GRAD, CURL, AND ALL THAT By H.M SCHEY,  An Informal Text on Vector Calculus",
               false, false, 13.5f, 6.99f, 162, 1, 1);

            divGradCurlAndAllThat.Read();
            divGradCurlAndAllThat.Open();
            divGradCurlAndAllThat.Read();
            divGradCurlAndAllThat.Read();
            divGradCurlAndAllThat.Read();
            divGradCurlAndAllThat.BookMarkIn();
            divGradCurlAndAllThat.Close();
            divGradCurlAndAllThat.Open();
            divGradCurlAndAllThat.Read();
            divGradCurlAndAllThat.Read();
            divGradCurlAndAllThat.BookMarkOut();
            divGradCurlAndAllThat.Close();
            divGradCurlAndAllThat.Open();
            divGradCurlAndAllThat.Read();
            divGradCurlAndAllThat.Read();



        }

       
    }
}
