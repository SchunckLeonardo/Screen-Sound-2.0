class Band
{
    public string Name { get; set; }
    private List<Album> albums = new();

    public Band(string name)
    {
        this.Name = name;
    }
    
    public void AddAlbum(Album album)
    {
        this.albums.Add(album);
    }

    public void ShowDiscography()
    {
        Console.WriteLine($"{this.Name} Band's Discography\n");
        foreach(Album album in this.albums)
        {
            Console.WriteLine($"Album: {album.Name} - {album.TotalDuration}");
        }
    }
}