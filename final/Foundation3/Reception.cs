public class Reception:Event
{
    private string _rsvp;
    private int _attendees;

    public Reception()
    {
        SetEventType("Reception");
    }

    private void SetRSVP()
    {
        Console.Write("Please enter your name: ");
        _rsvp = Console.ReadLine();
    }
    
    public string GetRSVP()
    {
        return _rsvp;
    }

    private void SetAttendees()
    {
        Console.Write("Please enter the number of attendees: ");
        _attendees = int.Parse(Console.ReadLine());
    }

    public int GetAttendees()
    {
        return _attendees;
    }

    public void BookReceptionEvent()
    {
        SetRSVP();
        SetAttendees();
        BookEvent();
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine($"RSVP: {GetRSVP()}\nNumber of attendees: {GetAttendees()}");
        DisplayStandardDetails();
    }

}