float distance = 0;
float averageFuelConsumption = 0;
float fuelCost = 0;
Calc_Fuel_Console.Fuel_Consumption_Eviction FuelConsumptionEviction = new Calc_Fuel_Console.Fuel_Consumption_Eviction();

Console.WriteLine("Hello. Enter Distance");

string input = Console.ReadLine();
distance = FuelConsumptionEviction.FilterInput(input);

Console.WriteLine("\nEnter Average Fuel Consumption");

input = Console.ReadLine();
averageFuelConsumption = FuelConsumptionEviction.FilterInput(input);

Console.WriteLine("\nEnter Fuel Cost");

input = Console.ReadLine();
fuelCost = FuelConsumptionEviction.FilterInput(input);

Console.WriteLine($"Travel Cost: {FuelConsumptionEviction.Cost_Travel(distance, averageFuelConsumption, fuelCost)}\nRequired Amount of Fuel: " +
    $"{FuelConsumptionEviction.Must_Amount_Fuel(distance, averageFuelConsumption)}");