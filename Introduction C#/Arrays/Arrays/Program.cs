// See https://aka.ms/new-console-template for more information
string[] coffeTypes;
float[] coffePrices;
coffeTypes = new string[] { "Expresso", "Largo", "Filtrado" };
coffePrices = new float[] { 1.2f, 1.5f, 5.0f };
for (int i = 0; i < coffeTypes.Length; i++)
    Console.WriteLine(coffeTypes[i] + "Coffe $" + coffePrices[i]);
