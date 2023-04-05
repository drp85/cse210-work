public class Video
{
    public Dictionary<int, List<string>> video;

    public Video()
    {
        video = new Dictionary<int, List<string>>();
        video[1] = new List<string>{"SampleTitle","SampleAuthor", "100"};
        video[2] = new List<string>{"NotATitle","NotAName","200"};
    }

    public int getKeyTotal()
    {
        return video.Keys.Count;
    }

    public void display(int key)
    {
        Console.WriteLine($"{key} Data: {video[key][0]} by {video[key][1]} (Length: {video[key][2]} seconds)");
    }
}
