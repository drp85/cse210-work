
public class Comment
{
    public Dictionary<int, List<string>> comments;

    public Comment()
    {
        comments = new Dictionary<int, List<string>>();
        comments[1] = new List<string>{"Hi","Hello","Nyanpasu"};
        comments[2] = new List<string>{"Yosh","Nani!!?"};
    }

    public string getList(int key)
    {
        if (comments.ContainsKey(key))
        {
            List<string> commentList = comments[key];
            return string.Join(" | ", commentList);
        }
        return "";
    }

    public void display(int key)
    {
        string strComments = getList(key);
        Console.WriteLine($"{key} Comments: {strComments}");
    }
}
