using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address ("21 N Main Street", "Kaysville", "UT", "84037", "USA");
        string lectureA1 = a1.GetAddress();
        Lectures lecture = new Lectures("History of Film", "Lecture on the History of Film.", "June 9, 2024", "7:00pm-9:00pm", $"{lectureA1}", "Lecture", "Bill Call", 274);

        lecture.DisplayShortDescription();
        Console.WriteLine();
        lecture.DisplayStandardDetails();
        Console.WriteLine();
        lecture.DisplayLectureFullDetails();
        Console.WriteLine();

        Address a2 = new Address ("2452 E 6700 S Unit C", "Uintah", "UT", "84405", "USA");
        string receptionA2 = a2.GetAddress();
        Receptions reception = new Receptions("Hayden Call & Laura Simonsen", "Hayden Call & Laura Simonsen invite you to join them at their wedding reception.", "June 4, 2022", "6:00 pm - 9:00 pm", $"{receptionA2}", "Reception", "haydenc0293@gmail.com" );

        reception.DisplayShortDescription();
        Console.WriteLine();
        reception.DisplayStandardDetails();
        Console.WriteLine();
        reception.DisplayReceptionsFullDetails();
        Console.WriteLine();

        Address a3 = new Address ("950 W 200N", "Kaysville", "UT", "84037", "USA");
        string outdoorA3 = a3.GetAddress();
        Outdoor outdoor = new Outdoor ("4th of July Movie in the Park", "Viewing of Top Gun: Maverick at Barnes Park", "July 4, 2024", "9:00 pm", $"{outdoorA3}", "Outdoor", "Partly Cloudy");

        outdoor.DisplayShortDescription();
        Console.WriteLine();
        outdoor.DisplayStandardDetails();
        Console.WriteLine();
        outdoor.DisplayOutdoorFullDetails();
        Console.WriteLine();
    }
}