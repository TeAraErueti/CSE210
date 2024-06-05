public class Lecture:Event
{
    private string _speaker;
    private int _capacity;

    public Lecture()
    {
        SetEventType("Lecture");
    }
    private void SetSpeaker()
    {
        Console.Write("Please enter your name: ");
        _speaker = Console.ReadLine();
    }

    public string GetSpeaker()
    {
        return _speaker;
    }

    private void SetCapacity()
    {
        Console.Write("Please enter the number of attendees: ");
        _capacity = int.Parse(Console.ReadLine());
    }

    public int GetCapacity()
    {
        return _capacity;
    }

    public void BookLectureEvent()
    {
        SetSpeaker();
        SetCapacity();
        BookEvent();
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine($"\nSpeaker: {GetSpeaker()}\nEvent capacity: {GetCapacity()}");
        DisplayStandardDetails();
    }

}