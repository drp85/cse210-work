using System;

public class Reference
{
    private Dictionary<int, Scripture> reference;

    public Reference()
    {
        reference = new Dictionary<int, Scripture>();
        reference[1] = new Scripture("1 Nephi 1:1", new List<string> {"1. I, Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father; and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days."});
        reference[2] = new Scripture("1 Nephi 11:16-17", new List<string> {"16. And he said unto me: Knowest thou the condescension of God?", "17. And I said unto him: I know that he lovest his children; nevertheless, I do not know the meaning of all things."});
        reference[3] = new Scripture("Exodus 20:12", new List<string> {"12. Honour thy father, and thy mother, that thy days may be long upon the land which the lord thy god giveth thee."});
        reference[4] = new Scripture("D&C 130:18-19", new List<string> {"Whatever principle of intelligence we attain unto in this life, it will rise with us in the ressurrection.","And if a person gains more knowledge and intelligence in this life through his diligence and obedience than another, he will have so much advantage in the world to come."});
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