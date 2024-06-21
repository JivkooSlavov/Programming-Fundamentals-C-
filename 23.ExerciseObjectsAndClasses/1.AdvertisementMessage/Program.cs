using _23.ExerciseObjectsAndClasses;

namespace _23.ExerciseObjectsAndClasses
{
    class Advertisement
    {
        public string[] Phrases =
         {
            "Excellent product.",
            "Such a great product.",
            "I always use that product.",
            "Best product of its category.",
            "Exceptional product.",
            "I can't live without this product."
        };
        public string[] Events =
        {   "Now I feel good.",
            "I have succeeded with this product.",
            "Makes miracles.I am happy of the results!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.",
            "I feel great!"
        };
        public string[] Authors = 
        { 
            "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
        };
        public string[] Cities = 
        {
            "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" 
        };
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Advertisement ad = new Advertisement();

        Random random = new Random();

        for (int i = 0; i < n; i++)
        {
            int index = random.Next(ad.Phrases.Length);
            string phrase = ad.Phrases[index];

            index = random.Next(ad.Events.Length);
            string events = ad.Events[index];

            index = random.Next(ad.Authors.Length);
            string authors = ad.Authors[index];

            index = random.Next(ad.Cities.Length);
            string cities = ad.Cities[index];

            Console.WriteLine($"{phrase} {events} {authors} – {cities}");
        }

    }
}
