using System.Text;

public static class ListExtension{
    public static string ZwrocInfoOLiscie<T>(this List<T> lista)
    {
        StringBuilder sb = new StringBuilder();
        foreach (T element in lista)
        {
            sb.AppendLine(element.ToString());
        }return sb.ToString();   
    }
}