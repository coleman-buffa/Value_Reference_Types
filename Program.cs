// Value types
var firstNumber = 10;
Console.WriteLine($"firstNumber: {firstNumber}"); // 10
var secondNumber = firstNumber;
Console.WriteLine($"secondNumber: {secondNumber}"); // 10
firstNumber = 20;
Console.WriteLine($"firstNumber: {firstNumber}"); // 20
Console.WriteLine($"secondNumber: {secondNumber}"); // 10

// Reference types
var numbersArray = new int[] { 1, 2, 3, 4, 5 };
Console.WriteLine(numbersArray); // System.Int32[]
Console.WriteLine(string.Join(",", numbersArray)); // 1,2,3,4,5

var numbersArray2 = numbersArray;
Console.WriteLine(string.Join(",", numbersArray2)); // 1,2,3,4,5

numbersArray[0] = 100;
Console.WriteLine(string.Join(",", numbersArray)); // 100,2,3,4,5
Console.WriteLine(string.Join(",", numbersArray)); // 100,2,3,4,5
