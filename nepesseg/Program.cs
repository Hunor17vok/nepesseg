namespace nepesseg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Orszag> Orszagok = new();
            
            foreach (var sor in File.ReadAllLines("atatok-utf8.txt").Skip(1))
            {
                foreach (var d in Orszagok)
                {
                    if (d.Nepesseg.EndsWith)
                    {

                    }
                }
                Orszagok.Add(new Orszag(sor));  
            }
            Console.WriteLine($"3.feladat:A beolvasot Országok adatainak szßma: {Orszagok.Count()}");
        }
    }
}
