public class Planeta
{
    private string nazwa;
    private uint? liczbaKsiezycow;
    public uint? LiczbaKsiezycow
    {
        get { return liczbaKsiezycow; }
        set { liczbaKsiezycow = value; }
    }
    public Planeta(string nazwa, uint? liczbaKsiezycow = null)
    {
        this.nazwa = nazwa;
        this.liczbaKsiezycow = liczbaKsiezycow;
    }
    public Planeta(Planeta planeta)
    {
        this.nazwa = planeta.nazwa;
        this.liczbaKsiezycow = planeta.liczbaKsiezycow;
    }
    public override string ToString()
    {
        return $"{nazwa} ({(liczbaKsiezycow.HasValue ? liczbaKsiezycow.Value.ToString() : "brak")} księżyców)";
    }
}