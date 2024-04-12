using BadmintonModelLib;

namespace BadmintonModelProj



{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose a badminton racket brand to see its specifications:");
            Console.WriteLine("1. Yonex");
            Console.WriteLine("2. Victor");
            Console.WriteLine("3. Li-Ning");

            string brandChoice = Console.ReadLine();

            Console.WriteLine("Choose a racket model:");
            string[] models;
            switch (brandChoice)
            {
                case "1":
                    models = new string[] { "Astrox 99", "Voltric Z-Force II", "Nanoflare 800" };
                    break;
                case "2":
                    models = new string[] { "Thruster K Falcon", "Jetspeed S 12", "Auraspeed 90K" };
                    break;
                case "3":
                    models = new string[] { "Turbo Charging 75D", "Windstorm 72", "N9 II" };
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            for (int i = 0; i < models.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {models[i]}");
            }

            string modelChoice = Console.ReadLine();

            RacketManager manager = new RacketManager();
            BadmintonRacket racket = manager.GetRacket(brandChoice == "1" ? "Yonex" : brandChoice == "2" ? "Victor" : "Li-Ning", models[int.Parse(modelChoice) - 1]);

            if (racket != null)
            {
                Console.WriteLine("\nSpecifications of selected racket:");
                Console.WriteLine($"Brand: {racket.Brand}");
                Console.WriteLine($"Model: {racket.Model}");
                Console.WriteLine($"Material: {racket.Material}");
                Console.WriteLine($"Weight: {racket.Weight} grams");
                Console.WriteLine($"Flexibility: {racket.Flexibility}");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}
