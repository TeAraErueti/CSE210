public class Comment
{
    public string _name;
    public string _comText;

    public void DisplayComment()
    {
        Console.WriteLine($" - {_name}: {_comText}");
    }
}