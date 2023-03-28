using System.Diagnostics;

public class SayaTubeVideo
{
    private int id;
    private String title;
    public int playCount;

    public SayaTubeVideo(String title)
    {
        Debug.Assert(title != "" && title.Length <= 200, "Batas maksimal karakter 100 dan tidak boleh kosong");
        this.id = new Random().Next(1000,99999);
        this.title = title;
        this.playCount = 0;
    }

    public void incrasePlayCount(int count)
    {
        Debug.Assert(count <= 25000000 && count > 0, "Input playCount maksimal 25 juta per panggilan method dam bukan bilangan negatif");
        try
        {
            checked { this.playCount += count; }
        }
        catch (OverflowException err)
        {
            Console.WriteLine(err.Message);
        }
    }

    public void printVideoDetail()
    {
        Console.WriteLine("<===============================================>");
        Console.WriteLine("DETAIL VIDEO");
        Console.WriteLine("ID Video: " + this.id);
        Console.WriteLine("Judul: " + this.title);
        Console.WriteLine("Viewer: " + this.playCount);
    }
}

public class sayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public String username;

    public sayaTubeUser(string username)
    {
        Debug.Assert(username.Length <= 100 && username != "", "Batas karakter maksimal 100 dan tidak boleh kosong");
        this.id = new Random().Next(1000, 99999);
        this.uploadedVideos = new List<SayaTubeVideo>();
        this.username = username;
    }

    public int GetTotalVideoCount()
    {
        return this.uploadedVideos.Count;
    }

    public void addVideo(SayaTubeVideo video)
    {
        this.uploadedVideos.Add(video);
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine("<===============================================>");
        Console.WriteLine("Username: " + this.username);
        int j = 1;
        for(int i  = 0; i < this.uploadedVideos.Count(); i++)
        {
            Console.WriteLine("Video " + j++ + " Judul" + this.uploadedVideos);
        }
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        SayaTubeVideo video1 = new SayaTubeVideo("Review Film Mission:Impossible oleh Fariz");
        video1.incrasePlayCount(25000000);
        video1.printVideoDetail();

        SayaTubeVideo video2 = new SayaTubeVideo("Review Film Transformer oleh Fariz");
        video2.incrasePlayCount(17500000);
        video2.printVideoDetail();

        SayaTubeVideo video3 = new SayaTubeVideo("Review Film Fast & Furrious oleh Fariz");
        video3.incrasePlayCount(17600000);
        video3.printVideoDetail();

        SayaTubeVideo video4 = new SayaTubeVideo("Review Film Angry Bird oleh Fariz");
        video4.incrasePlayCount(800000);
        video4.printVideoDetail();

        SayaTubeVideo video5 = new SayaTubeVideo("Review Film A Quiet Place 1 oleh Fariz");
        video5.incrasePlayCount(14300000);
        video5.printVideoDetail();

        SayaTubeVideo video6 = new SayaTubeVideo("Review Film A Quiet Place 2 oleh Fariz");
        video6.incrasePlayCount(10000000);
        video6.printVideoDetail();

        SayaTubeVideo video7 = new SayaTubeVideo("Review Film The Nun oleh Fariz");
        video7.incrasePlayCount(12300000);
        video7.printVideoDetail();

        SayaTubeVideo video8 = new SayaTubeVideo("Review Film The Conjuring 2 oleh Fariz");
        video8.incrasePlayCount(17700000);
        video8.printVideoDetail();

        SayaTubeVideo video9 = new SayaTubeVideo("Review Film The Texas Chain Saw Massacre oleh Fariz");
        video9.incrasePlayCount(16660000);
        video9.printVideoDetail();

        SayaTubeVideo video10 = new SayaTubeVideo("Review Film The Curse of La Llorona oleh Fariz");
        video10.incrasePlayCount(21200000);
        video10.printVideoDetail();

        sayaTubeUser user = new sayaTubeUser("");
        user.addVideo(video1);
        user.addVideo(video2);
        user.addVideo(video3);
        user.addVideo(video4);
        user.addVideo(video5);
        user.addVideo(video6);
        user.addVideo(video7);
        user.addVideo(video8);
        user.addVideo(video9);
        user.addVideo(video10);
        user.PrintAllVideoPlaycount();
    }
}
