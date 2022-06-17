
int number = new Random().Next(10, 100);
Console.WriteLine($"Random number from 10 to 99: {number}");

int digit1 = number / 10;
int digit2 = number % 10;

/* if (digit1 > digit2) {
    Console.Write($"Max digit is {digit1}");
}
else {
    Console.Write($"Max digit is {digit2}");
} */

int max = Math.Max(digit1, digit2);
Console.Write($"Max digit is {max}");
