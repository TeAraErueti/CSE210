using System;

class Entry
{
  public string _prompt { get; set; }
  public string _response { get; set; }
  public DateTime _date { get; set; }

  public Entry(string prompt, string response)
  {  //added time of entry to journal entry as exceeding requirement of saving additional information in journal entry.
    _prompt = prompt;
    _response = response;
    _date = DateTime.Now;
  }

  public override string ToString()
  {
    return ($"Date: {_date}\nPrompt: {_prompt}\nResponse: {_response}\n");
  }
}