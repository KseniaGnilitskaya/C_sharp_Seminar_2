Console.Write("Enter the first number: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Enter the second number: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 % number2 == 0){
    Console.Write($"{number1} is a multiple of {number2}");
}
else{
    Console.WriteLine($"{number1} is not a multiple of {number2}");
    Console.WriteLine(number1 % number2);
}
