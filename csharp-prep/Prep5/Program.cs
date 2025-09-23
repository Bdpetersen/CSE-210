using System;

class Program
{
    static void displayWelcome(){
        Console.WriteLine("Welcome to the Program!");
    }
    static string promptUserName()
    {
        Console.Write("Please Enter Your Name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int promptUserNumber()
    {
        Console.Write("Please Enter Your Favorite Number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static void promptUserBirthYear(out int birth)
    {
        Console.Write("Please Enter The Year You Were Born: ");
        birth = int.Parse(Console.ReadLine());
    }
    static int squareNumber(int i)
    {
        return i * i;
    }
    static void Main(string[] args)
    {
        displayWelcome();
        string name = promptUserName();
        int userNumber = promptUserNumber();
        int year;
        promptUserBirthYear(out year);
        int square = squareNumber(userNumber);
        Console.WriteLine($"{name}, the square of your number is {square}.");
        Console.WriteLine($"{name}, you will turn {2025 - year} this year.");
    
    }
}