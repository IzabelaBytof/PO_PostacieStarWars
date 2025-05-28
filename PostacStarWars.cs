public class PostacStarWars
{
    private string imie;
    public string Imie
    {
        get { return imie; }
        set { imie = value; }
    }
    private string gatunek;
    public string Gatunek
    {
        get { return gatunek; }
        set { gatunek = value; }
    }
    private string plec;
    public string Plec
    {
        get { return plec; }
        set { plec = value; }
    }
    private Planeta planetaMacierzysta;
    public Planeta PlanetaMacierzysta
    {
        get { return planetaMacierzysta; }
        set { planetaMacierzysta = value; }
    }
    private StronaKonfliktu stronaKonfliktu;
    public StronaKonfliktu _StronaKonfliktu
    {
        get { return stronaKonfliktu; }
        set { stronaKonfliktu = value; }
    }
    public enum StronaKonfliktu
    {
        IMPERIUM,
        REPUBLIKA
    }
    public PostacStarWars(string imie, string gatunek, string plec, Planeta planetaMacierzysta, StronaKonfliktu stronaKonfliktu)
    {
        this.imie = imie;
        this.gatunek = gatunek;
        this.plec = plec;
        this.planetaMacierzysta = planetaMacierzysta;
        this.stronaKonfliktu = stronaKonfliktu;
    }
    public PostacStarWars(PostacStarWars postac)
    {
        this.imie = postac.imie;
        this.gatunek = postac.gatunek;
        this.plec = postac.plec;
        this.planetaMacierzysta = postac.planetaMacierzysta;
        this.stronaKonfliktu = postac.stronaKonfliktu;
    }
    public override string ToString()
    {
        return $"{imie} ({gatunek}, {plec}) z planety {planetaMacierzysta} - {stronaKonfliktu}";
    }
}