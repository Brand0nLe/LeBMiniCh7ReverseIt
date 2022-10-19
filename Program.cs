//Cuong Brandon Le
//10-18-22
//Mini Challenge 7 - Reverse It

//Need data validation


string playAgain = "YES";
string userInput = "";
string reversedOutput = "";


while (playAgain == "YES")
{
    Console.WriteLine("--------------------------------------------------------------");
    Console.WriteLine("Hi there! Let's do something fun today! Let's reverse stuff!");
    Console.WriteLine("--------------------------------------------------------------");

    Console.WriteLine("Please type something:");
    userInput = Console.ReadLine();

    reversedOutput = string.Empty;

    for (int i = userInput.Length -1; i>=0; i--)
    {
        reversedOutput = reversedOutput + userInput [i];
    }

    Console.WriteLine("--------------------------------------------------------------");
    Console.WriteLine($"{userInput.ToUpper()} = {reversedOutput.ToUpper()}");
    Console.WriteLine("--------------------------------------------------------------");

    Console.WriteLine("Do you want to play again? (YES/NO)");
    playAgain = Console.ReadLine().ToUpper();

    if (playAgain == "NO")
    {
        Console.WriteLine("That was fun! Come back any time.");
    }
}