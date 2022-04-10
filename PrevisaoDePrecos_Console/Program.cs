
using System;

namespace PrevisaoDePrecos_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            PrevisaoDePrecos.ModelInput sampleData = new PrevisaoDePrecos.ModelInput()
            {
                Bedrooms = 3F,
                Bathrooms = 1F,
                Sqft_lot = 5650F,
                Floors = 1F,
            };

            var predictionResult = PrevisaoDePrecos.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Price with predicted Price from sample data...\n\n");

            Console.WriteLine($"Price: {221900F}");
            Console.WriteLine($"Bedrooms: {3F}");
            Console.WriteLine($"Bathrooms: {1F}");
            Console.WriteLine($"Sqft_lot: {5650F}");
            Console.WriteLine($"Floors: {1F}");


            Console.WriteLine($"\n\nPredicted Price: {predictionResult.Score}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
