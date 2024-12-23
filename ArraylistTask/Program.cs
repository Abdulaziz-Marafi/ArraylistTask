using System.Collections;

// Create arraylist, add fruits, display arraylist
ArrayList fruits = new ArrayList() {"cherry", "apple", "banana" };

foreach (string fruit in fruits)
{
    Console.WriteLine($"{fruit} is in stored in the arraylist.");
}
Console.WriteLine("\n");

// Arraylist methods
fruits.Insert(2, "orange");
fruits.RemoveAt(1);

Console.WriteLine("Please enter a fruit to check: ");
Console.WriteLine("------------------------------ ");
string food = Console.ReadLine();
Console.WriteLine("\n");

// Check if food entered is in the list
if (fruits.Contains(food.ToLower()))
{
    Console.WriteLine($"The item {food} can be found in the list at index {food.IndexOf(food)}.");
}else
{
    Console.WriteLine("The item entered cannot be found in the list.");
}
Console.WriteLine($"\nThe number of items in the list is {fruits.Count}");

// Initialize array with integers 
ArrayList numbers = new ArrayList() {20, 15, 43, 98, 56, 40, 85, 75, 122, 98, 34, 52, 11, 5, 37};

// Function used to compare items in arraylist and threshold, then return arraylist with the lagrer number
ArrayList returnLargerList (ArrayList list , int threshold)
{
    ArrayList newNums = new ArrayList();
    
    foreach(int num in list)
    {
        if (num > threshold)
        {
            newNums.Add(num);
        }
    }
    // Returing the arraylist with larger numbers
    return newNums;
}

// Calling the arraylist comparison function 
ArrayList largerNumbers = returnLargerList(numbers, 39);


// Print out new arraylist
Console.WriteLine("The numbers in the list of lagrer number include: ");
foreach (int num in largerNumbers)
{
    Console.WriteLine(num);
}

