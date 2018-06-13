public class Utility
{
    public static string Pluralize(int n, string word, string suffix = "s")
    {
        return word + (n == 1 ? "" : suffix);
    }
}
