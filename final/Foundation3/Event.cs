public class Event
{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private string _eventType;
    private Address _address = new();

    public Event()
    {

    }

    public void SetEventType (string theEvent)
    {
        _eventType = theEvent;
    }

    private string GetEventType()
    {
        return _eventType;
    }

    private void SetEventTitle()
    {
        Console.Write("Please enter event title: ");
        _eventTitle = Console.ReadLine();
    }

    public string GetEventTitle()
    {
        return _eventTitle;
    }

    private void SetEventDescription()
    {
        Console.Write("Please enter event description: ");
        _description = Console.ReadLine();
    }

    public string GetEventDescription()
    {
        return _description;
    }

    private void SetEventDate()
    {
        Console.Write("Please enter the date of the event (DD-MM-YY): ");
        _date = Console.ReadLine();
    }

    public string GetDate()
    {
        return _date;
    }

    private void SetEventTime()
    {
        Console.Write("Please enter the event time: ");
        _time = Console.ReadLine();
    }

    public string GetEventTime()
    {
        return _time;
    }

    public void BookEvent()
    {
        SetEventTitle();
        SetEventDescription();
        SetEventDate();
        SetEventTime();
        _address.SetAddress();
    }

    public void DisplayStandardDetails()
    {
        Console.WriteLine($"Event name: {GetEventTitle()}\nEvent Description: {GetEventDescription()}\nEvent Date: {GetDate()} Time: {GetEventTime()}\n{_address.DisplayAddressInfo()}");
    }

    public void DisplayShortDetails()
    {
        Console.WriteLine($"Event type: {GetEventType()}\nEvent title: {GetEventTitle()}\nEvent date: {GetDate()}");
    }
}