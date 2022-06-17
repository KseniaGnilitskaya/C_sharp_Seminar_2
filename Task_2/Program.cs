
int number = new Random().Next(100, 1000);
Console.WriteLine($"Random number is {number}");

int FirstDigit = number / 100;
int LastDigit = number % 10;

Console.WriteLine($"Three-digit number without middle one {FirstDigit}{LastDigit}");

