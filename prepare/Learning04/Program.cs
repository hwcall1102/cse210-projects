using System;
using homework;
using library_demo;

class Program
{
    static void Main(string[] args)
    {

        Assignment test1 = new Assignment("Samuel Bennett", "Multiplication");

        Console.WriteLine(test1.GetSummary());

        MathAssignment math1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");

        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        WritingAssignment write1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        Console.WriteLine(write1.GetSummary());
        Console.WriteLine(write1.GetWritingInformation());

        /*Book book1 = new Book();
        book1.SetAuthor("Smith");
        book1.SetTitle("A Great Book");

        Console.WriteLine(book1.GetBookInfo());

        PictureBook book2 = new PictureBook();
        book2.SetAuthor("Anderson");
        book2.SetTitle("The Little Mermaid");
        book2.SetIllustrator("Hayden Call");

        Console.WriteLine(book2.GetPictureBookInfo());

        Book book3 = new Book("Edwards", "new book");
        Console.WriteLine(book3.GetBookInfo());

        PictureBook book4 = new PictureBook("Suess", "Oh the PLaces You'll Go", "Suess");
        Console.WriteLine(book4.GetPictureBookInfo());*/




    }
}