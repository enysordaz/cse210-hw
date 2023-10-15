using System;

public class PromptGenerator 
{
    public List<string> Prompts {get;set;}

    public PromptGenerator(){
        // List of prompts to select from
        Prompts = new List<string>{
            "What was the best part of the day? ",
            "What did you learn today? ",
            "Write about a spiritual experience you had today: ",
            "What are you grateful for today? ",
            "If there was one thing you could do over today, what would it be? ",
            "What is the song that was stuck in your head today? ",
            "Write about an act of service you did or saw someone else do: ",
            "Write about a positive interaction you had with someone different or that you don't know very well: ",
            "Which hobby did you excercise today? ",
            "What is your favorite food to share with friends? ",
            "Write about what you thought of Jesus Christ today: ",
            "Write about an experience that allowed you to teach today: ",
            "What was your main emotion today? ",
            "Who is someone you admired today and why? ",
            "What was your most recent dream about? ",
            "What is your favorite memory from Childhood? ",
            "Write about the most intersting person you interacted with today: "
        };
    }
    // This generates a random prompt from the List
    public string GenerateRandomPrompt() {
        Random random = new Random();
        int _index = random.Next(Prompts.Count);
        return Prompts[_index];
    }
}