using System;
using System.Collections.Generic;

class PromptGenerator
{
  public static string GetRandomPrompt()
  {
      List<string> _prompts = new List<string>
      { //Added more prompts to list
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What are the places I went to today?",
        "What was the most inspiring idea I had today?",
        "What 3 things are you thankful for today and why?",
        "What is one thing new that you learnt today?",
        "What did you eat today?",
        "Name one thing today that left you feeling humbled:",
        "Name one thing you overcame today and how that made you feel:",
        "Name one thing that made you smile today:",
        "Name two things you would like to remember from today:",
        "What progress have you made towards achieving a goal you are currently working on:",
        "What preparation are you doing today for tomorrow?",
        "What are your highlights for today?",
        "How did you serve someone today?If not,how can you serve someone this week?",
        "What was a challenge you faced today and how did you overcome it?",
        "Would you change any decisions you made today?",
        "If you had more time today, how would you have spent it?",
        "Reflecting on today, how are you feeling?"
    };
    
    Random random = new Random();
    int index = random.Next(_prompts.Count);
    return _prompts[index];
  }
}