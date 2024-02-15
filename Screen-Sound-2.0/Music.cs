class Music
{
    public string Name { get; }
    public Band Artist { get; }
    public int Duration { get; }
    public bool Available { get; set; }
    public string NameArtist => $"{this.Name} by {this.Artist}";

    public Music(string name, Band artist, int duration)
    {
        this.Name = name;
        this.Artist = artist;
        this.Duration = duration;
    }

    public void ShowMusicInfo()
    {
        Console.WriteLine($"Music's Name: {this.Name}");
        Console.WriteLine($"Music's Artist: {this.Artist.Name}");
        Console.WriteLine($"Music's Duration: {this.Duration}");
        if (Available) Console.WriteLine($"Music's Available: Disponível");
        else Console.WriteLine($"Music's Available: Não está disponível");
    }
} 