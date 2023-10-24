using System;

class Program
{
    static void Main(string[] args)
    {
        string scriptureText = "Angels speak by the power of the Holy Ghost; wherefore, they speak the words of Christ. Wherefore, I say unto you, feast upon the word of Christ; for behold, the words of Christ will tell you all the things that ye should do.";
        
        // Uses/ calls the reference class
        Reference referenceObj = new Reference("2 Nephi", "32", "3");
        string reference = referenceObj.GetReference();

        // Uses the scripture class
        Scripture scripture = new Scripture(reference, scriptureText);
        scripture.DisplayScripture();
    }
}