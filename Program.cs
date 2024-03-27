internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo a = new SayaTubeVideo("Review Film Tutorial Design By Contract-{DAFA_RAIMI_SUANDI}");
        SayaTubeVideo b = new SayaTubeVideo("Review Film John Wick-{DAFA_RAIMI_SUANDI}");
        SayaTubeVideo c = new SayaTubeVideo("Review Film John Wick 2-{DAFA_RAIMI_SUANDI}");
        SayaTubeVideo d = new SayaTubeVideo("Review Film John Wick 3-{DAFA_RAIMI_SUANDI}");
        SayaTubeVideo e = new SayaTubeVideo("Review Film John Wick 4-{DAFA_RAIMI_SUANDI}");
        SayaTubeVideo f = new SayaTubeVideo("Review Film Breaking bad-{DAFA_RAIMI_SUANDI}");
        SayaTubeVideo g = new SayaTubeVideo("Review Film Kimetsu No yaiba-{DAFA_RAIMI_SUANDI}");
        SayaTubeVideo h = new SayaTubeVideo("Review Film Avatar-{DAFA_RAIMI_SUANDI}");
        SayaTubeVideo i = new SayaTubeVideo("Review Film ex Machina-{DAFA_RAIMI_SUANDI}");
        SayaTubeVideo j = new SayaTubeVideo("Review Film Marmut merah jambu-{DAFA_RAIMI_SUANDI}");
        a.increasePlayCount(9999999);
        b.increasePlayCount(9999999);
        c.increasePlayCount(9999999);
        d.increasePlayCount(9999999);
        e.increasePlayCount(9999999);
        f.increasePlayCount(9999999);
        g.increasePlayCount(9999999);
        h.increasePlayCount(9999999);
        i.increasePlayCount(9999999);
        j.increasePlayCount(9999999);

        g.PrintVideoDetails();
        SayaTubeUser Dafa = new SayaTubeUser("Dafa Raimi Suandi");
        Dafa.addVideo(a);
        Dafa.addVideo(b);
        Dafa.addVideo(c);
        Dafa.addVideo(d);
        Dafa.addVideo(e);
        Dafa.addVideo(f);
        Dafa.addVideo(g);
        Dafa.addVideo(h);
        Dafa.addVideo(i);
        Dafa.addVideo(j);
        Dafa.PrintAllVideoPlayCount();
        Dafa.GetTotalVideoPlayCount();
    }
}