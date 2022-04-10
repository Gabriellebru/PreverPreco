using static PreverPreco.PrevisaoDePrecos;

var samples = new List<ModelInput>()
{
    new ModelInput()
    {
        Bedrooms = 2F,
        Bathrooms = 1F,
        Sqft_lot = 10000F,
        Floors = 2F
    },
    new ModelInput()
    {
        Bedrooms = 5F,
        Bathrooms = 2.25F,
        Sqft_lot = 20158F,
        Floors = 1F
    },
    new ModelInput()
    {
        Bedrooms = 6F,
        Bathrooms = 2.5F,
        Sqft_lot = 14034F,
        Floors = 1F
    },
};

var outputs = PredictAll(samples);
foreach (var output in outputs)
{
    Console.WriteLine($"Valor sugerido: {output.Score}");
}
Console.ReadKey();
