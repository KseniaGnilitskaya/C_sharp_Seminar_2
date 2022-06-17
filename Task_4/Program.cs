Console.Write("Enter the number: ");
int number = int.Parse(Console.ReadLine());

if (number%7==0 & number%23==0){
    Console.Write($"{number} is a multiple of 7 and 23");
}
else{
    Console.Write($"{number} is not a multiple of 7 and 23");
}
