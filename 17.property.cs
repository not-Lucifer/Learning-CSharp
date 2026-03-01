private static string _playername;

private static string PlayerName
{
    get
    {
        return _playername;
    }
    set
    {
        _playername = value;
    }
}

PlayerName = "Not-Lucifer";
Console.WriteLine(PlayerName);