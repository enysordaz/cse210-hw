using System;

class Program
{
    static void Main(string[] args)
    {
        //Scripture 1
        string scriptureMessage1 = "Wherefore, ye must press forward with a steadfastness in Christ, having a perfect brightness of hope, and a love of God and of all men. Wherefore, if ye shall press forward, feasting upon the word of Christ, and endure to the end, behold, thus saith the Father: Ye shall have eternal life.";
        Reference referenceObject1 = new Reference("2 Nephi", "31", "20"); 
        string reference1 = referenceObject1.GetReference();

        Scripture scripture1 = new Scripture(reference1, scriptureMessage1);
        scripture1.DisplayScripture();

        //Scripture 2
        string scriptureMessage2 = "Come unto me, all ye that labour and are heavy laden, and I will give you rest. Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls.For my yoke is easy, and my burden is light.";

        Reference referenceObject2 = new Reference("Matthew", "11", "28", "30");
        string reference2 = referenceObject2.GetReference();

        Scripture scripture2 = new Scripture(reference2, scriptureMessage2);
        scripture2.DisplayScripture();
    }
}