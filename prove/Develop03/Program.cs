using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--------- Welcome to the Scripture Memorizer --------\n");

        Reference theReference = new(book:"", chapter:0, verse_s:0);

        Console.Write("Please enter the scripture in the format - (Book, Chapter, Verse/s) seperated by a comma , ): "); 
        string[] listRef = Console.ReadLine().Split(",");

        if (listRef.Count() == 4)
        {
            theReference = new Reference(book:listRef[0], chapter:int.Parse(listRef[1]), verse_s:int.Parse(listRef[2]), verse_e:int.Parse(listRef[3]));

        }
        
        if (listRef.Count() == 3)
        {
            theReference = new Reference(book:listRef[0], chapter:int.Parse(listRef[1]), verse_s:int.Parse(listRef[2])); 
        }
        
        Console.WriteLine("Please enter the scripture verse:\n");
        theReference.setVerse();
        Scripture scripture = new(theReference);
        Console.Clear();
        scripture.DisplayText();
        Console.WriteLine("Please press Enter to continue or type 'quit' to leave the program: ");

        while(Console.ReadLine() != "quit")
        {

            if(scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Thank you for playing\n");
                break;
            }

            Console.Clear();
            scripture.HideRandomWords(5);
            Console.Clear();
            scripture.DisplayText();

            Console.WriteLine("Please press Enter to continue or type 'quit' to leave the program: ");
            
        }
        
        Console.Write("Good bye");
    }
}