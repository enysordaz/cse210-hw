using System;

class Program
{
    static void Main(string[] args)
    {
        // Event Lecture
        Address addressL = new Address("3111 College Way", "Heber City", "Utah", "USA");

        Lecture lecture = new Lecture("Eternal Belonging and Becoming", "An evening of inspiration with Michelle H. Bennett", "May 14th, 2024", "4pm", addressL, "Michelle H. Bennett", 120);
        Console.WriteLine();

        Console.WriteLine("Event Number: 1");
        Console.WriteLine();
        Console.WriteLine(lecture.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateDetailedLecture());

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateShortLecture());
        Console.WriteLine("___________________________________");

        // Event Reception
        Address addressR = new Address("225 E 200 N", "Orem", "Utah", "USA");

        Reception reception = new Reception("Wedding of Peter and Kayla", "Join the couple in celebrating eternity at their reception", "June 3rd, 2024", "6pm", addressR, "jackson.tim@gmail.com");
        Console.WriteLine();

        Console.WriteLine("Event Number: 2");
        Console.WriteLine();
        Console.WriteLine(reception.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(reception.GenerateDetailedReception());

        Console.WriteLine();
        Console.WriteLine(reception.GenerateShortReception());
        Console.WriteLine("___________________________________");

        // Event OutdoorGathering
        Address addressOG = new Address("1370 Soldier Hollow Ln", "Midway", "Utah", "USA");

        OutdoorGathering outdoorGathering = new OutdoorGathering("Summer Elegance Grill", "Celebrating the beginning of summer!", "June 21st, 2024", "5pm", addressOG, "Sunny");
        Console.WriteLine();

        Console.WriteLine("Event Number: 3");
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateDetailedOutdoorGathering());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateShortOutdoorGathering());
        Console.WriteLine("___________________________________");
    }
}