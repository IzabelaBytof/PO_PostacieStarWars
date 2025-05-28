using System.Text;

public class PostacieStarWars
{
    private List<PostacStarWars> postacie = new List<PostacStarWars>();
    public void Dodaj(PostacStarWars postac)
    {
        postacie.Add(postac);
    }
    
    [Obsolete("Ta metoda jest przestarzała! Użyj ZwrocPostaciPo(Wybierz wybierz, string wartosc)", false)]
    public List<PostacStarWars> ZwrocPostaciPoPlci(string plec)
    {
        List<PostacStarWars> wynik = new List<PostacStarWars>();
        foreach (PostacStarWars p in postacie)
        {
            if (p.Plec == plec)
            {
                wynik.Add(new PostacStarWars(p));
            }
        }return wynik;
    }
    public delegate string Wybierz(PostacStarWars c);
    public List<PostacStarWars> ZwrocPostaciPo(Wybierz wybierz, string wartosc)
    {
        List<PostacStarWars> wynik = new List<PostacStarWars>();
        foreach (PostacStarWars p in postacie)
        {
            if (wybierz(p) == wartosc)
            {
                wynik.Add(new PostacStarWars(p));
            }
        }
        return wynik;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        foreach (PostacStarWars p in postacie)
        {
            sb.AppendLine(p.ToString());
        }
        return sb.ToString();
    }
}