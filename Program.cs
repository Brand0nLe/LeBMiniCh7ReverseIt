//Cuong Brandon Le
//10-20-22
//Mini Challenge 7 - Reverse It
//Project will take users input and print it back into the terminal in reverse.
//Play again option available also and the play again option. There's data validation for when the user inputs
//letters instead of numbers, it will prompt them to input numbers.
//Also has data validation until the user properly enters in yes or no at the end.



string playAgain = "YES";


while (playAgain == "YES")
{
    int validNum = 0;
    string userInput = "";
    string reversedOutput = "";
    bool canParse;

    Console.WriteLine("--------------------------------------------------------------");
    Console.WriteLine("Hi there! Let's do something fun today! Let's reverse some numbers!");
    Console.WriteLine("--------------------------------------------------------------");

    Console.WriteLine("Please enter some numbers:");
    userInput = Console.ReadLine();
    canParse = Int32.TryParse(userInput, out validNum);
    while (canParse == false)
    {
        Console.WriteLine("INVALID ENTRY! Please enter numbers:");
        userInput = Console.ReadLine();
        canParse = Int32.TryParse(userInput, out validNum);
    }

    for (int i = userInput.Length - 1; i >= 0; i--)
    {
        reversedOutput = reversedOutput + userInput[i];
    }

    Console.WriteLine("--------------------------------------------------------------");
    Console.WriteLine("Okay let's get to reversing!");
    Console.WriteLine($"{userInput} = {reversedOutput}");
    Console.WriteLine("--------------------------------------------------------------");
    Console.WriteLine("Do you want to play again? (YES/NO)");
    playAgain = Console.ReadLine().ToUpper();


    if (playAgain == "NO")
    {
        Console.WriteLine("That was fun! Come back any time.");
    }
    while (playAgain != "YES" && playAgain != "NO")
    {
        Console.WriteLine("INVALID ENTRY! Please enter YES or NO.");
        playAgain = Console.ReadLine().ToUpper();
    }
}