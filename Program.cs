List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!
 

//1. Use LINQ to find the first eruption that is in Chile and print the result.
IEnumerable<Eruption> firstEruptionInChile = eruptions.Where(c => c.Location == "Chile").OrderBy(c => c.Year).Take(1);
PrintEach(firstEruptionInChile,"The First Eruption in Chile:");
Console.WriteLine("===============");

//2. Find the first eruption from the "Hawaiian Is" location and print it. If none is found, print "No Hawaiian Is Eruption found."
IEnumerable <Eruption> firstHawaiianIs = eruptions.Where(c => c.Location == "Hawaiian Is").OrderBy(c => c.Year).Take(1).ToList();
if (firstHawaiianIs.Count() < 1)
{
    Console.WriteLine("No Hawaiian Is Eruption found");
}
else
{
    PrintEach(firstHawaiianIs, "The First Hawaiian Eruption:");
}
Console.WriteLine("===============");

//3. Find the first eruption that is after the year 1900 AND in "New Zealand", then print it.
IEnumerable<Eruption> newZealandAfter1900 = eruptions.Where(c => c.Location == "New Zealand").OrderBy(y => y.Year > 1900).Take(1);
PrintEach(newZealandAfter1900, "First Eruption in New Zealand after 1900:");
Console.WriteLine("===============");

//4. Find all eruptions where the volcano's elevation is over 2000m and print them.
IEnumerable<Eruption> elevationOver2000 = eruptions.Where(e => e.ElevationInMeters > 2000).ToList();
PrintEach(elevationOver2000, "Eruptions over 2000m above sea level");
Console.WriteLine("===============");

//5. Find all eruptions where the volcano's name starts with "L" and print them. Also print the number of eruptions found.
IEnumerable<Eruption> startsWithZ = eruptions.Where( c => c.Volcano.ToLower().StartsWith( "l" ) );
PrintEach( startsWithZ, "Volcano eruption's that start with L" );
Console.WriteLine("===============");

//6. Find the highest elevation, and print only that integer (Hint: Look up how to use LINQ to find the max!)
int highestElevation = eruptions.Max(e => e.ElevationInMeters);
Console.WriteLine($"Highest elevations is {highestElevation}");
Console.WriteLine("===============");

//7. Use the highest elevation variable to find a print the name of the Volcano with that elevation.
IEnumerable<Eruption> highestElevationVolcano = eruptions.Where( c => c.ElevationInMeters == highestElevation );
PrintEach( highestElevationVolcano, "Volcano eruption with the highest elevation" );
Console.WriteLine("===============");

//8. Print all Volcano names alphabetically.
List<Eruption> volcanoNames = eruptions.OrderBy(n => n.Volcano).ToList();

foreach (var item in volcanoNames)
{
    Console.WriteLine(item.Volcano);
}
Console.WriteLine("===============");

//9. Print all the eruptions that happened before the year 1000 CE alphabetically according to Volcano name.
IEnumerable<Eruption> before1000 = eruptions.Where(n => n.Year < 1000).OrderBy(n => n.Volcano);
PrintEach(before1000, "Eruptions before 1000 CE");
Console.WriteLine("===============");

//10. BONUS: Redo the last query, but this time use LINQ to only select the volcano's name so that only the names are printed.

// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}
