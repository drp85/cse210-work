using System;

public class Reference
{
    private Dictionary<int, Scripture> reference;

    public Reference()
    {
        reference = new Dictionary<int, Scripture>();
        reference[1] = new Scripture("1 Nephi 1:1", new List<string> {"1. I, Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father; and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days."});
        reference[2] = new Scripture("1 Nephi 11:16-17", new List<string> {"16. And he said unto me: Knowest thou the condescension of God?", "17. And I said unto him: I know that he lovest his children; nevertheless, I do not know the meaning of all things."});
    
    }

    public Scripture getScripture(int reference)
    {
        return this.reference[reference];
    } 
    
    public void displayReferences()
    {
        foreach(int key in reference.Keys)
        {
            Console.WriteLine($"{key}: {reference[key].getVerse()}");
        }
    }
}