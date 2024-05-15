using System;

class Program
{
    static void Main(string[] args)
    {
        string scriptureMessage1 = "Wherefore, ye must press forward with a steadfastness in Christ, having a perfect brightness of hope, and a love of God and of all men. Wherefore, if ye shall press forward, feasting upon the word of Christ, and endure to the end, behold, thus saith the Father: Ye shall have eternal life.";

        Reference referenceObject1 = new Reference(2 Nephi, 31, 20);
        string reference1 = referenceObject1.GetReference();

        Scripture scripture1 = new Scripture(reference1, scriptureMessage1);
        scripture1.DisplayScripture();
    }
}