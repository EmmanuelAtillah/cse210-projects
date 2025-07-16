
public class Entry
{
    public string _time;
    public string _date;
    public string _prompt;
    public string _response;

    public Entry(string time,string date, string prompt, string response)
    {
        _time = time;
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public void Display()
    {
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine();
    }

    public string ToFileFormat()
    {
        return $"{_time}|{_date}|{_prompt}|{_response}";
    }

    public static Entry FromFileFormat(string line)
    {
        string[] parts = line.Split('|');
        return new Entry(parts[0], parts[1], parts[2], parts[3]);
    }
}
