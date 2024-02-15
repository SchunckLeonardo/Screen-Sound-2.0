class Album
{
    public string Name { get; set; }
    private List<Music> musics = new();
    public int TotalDuration => this.musics.Sum(m => m.Duration);

    public Album(string name)
    {
        this.Name = name;
    }

    public void AddMusic(Music music)
    {
        this.musics.Add(music);
    }

    public void ShowAlbum()
    {
        Console.WriteLine($"{this.Name} - {this.TotalDuration / 60} minutes\n");
        foreach (Music music in this.musics)
        {
            Console.WriteLine($"Music: {music.Name} - {music.Artist.Name}");
        }
    }
}