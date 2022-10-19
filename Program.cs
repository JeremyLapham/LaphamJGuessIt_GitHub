//Jeremy Lapham
//10-18-22
//Guess It
//This program will ask the user if they want to play easy med. or hard or custom to play a guess it game
//Peer Review:

Console.Clear();
bool endGame = true;
int num = 0;
string guessNumOne;
string guessNumTwo;
int num1 = 0;
int num2 = 0;
bool ownLoop = true;

while(endGame==true)
{
Console.WriteLine("The game we are going to play is called Guess It");
Console.WriteLine("I want you to choose a difficulty that you want to play. Easy, Medium, Hard, or type 'Own' if you want to set your own boundaries");
string difficult = Console.ReadLine().ToLower();

int easyNumberGuesses = 0;
int mediumNumberGuesses = 0;
int hardNumberGuesses = 0;
int ownNumberGuesses = 0;
while (difficult != "easy" && difficult != "medium" && difficult != "hard" && difficult != "own")
{
    Console.WriteLine("");
    Console.WriteLine("You did not enter a valid difficulty level.");
    break;
}
if(difficult == "easy")
    {
    Random rndNum = new Random();
    int rndNum2 = rndNum.Next(1,10);
    Console.WriteLine("You selected the Easy difficulty ");
    Console.WriteLine("");
    Console.WriteLine("Now you will have to guess what number the computer has within a 1-10 range.");
    while(num != rndNum2)
    {
    easyNumberGuesses ++;
    string guessRight = Console.ReadLine();
    bool trueG = Int32.TryParse(guessRight, out num);
    if(trueG == false)
    {
        Console.WriteLine("Next time put an actual number");
        break;
    }
        if(num > rndNum2)
    {
        Console.WriteLine("Your guess was above. Guess Again.");
    }
        if(num < rndNum2)
    {
        Console.WriteLine("Your guess was below. Guess Again");
    }
        else if(num==rndNum2)
    {
        Console.WriteLine("Congrats! You got it right!");
        Console.WriteLine("It took you " + easyNumberGuesses + " guesses to get it right!");
    }
    }
}
else if(difficult == "medium")
    {
    Random rndNum = new Random();
    int rndNum2 = rndNum.Next(1,50);
    Console.WriteLine("You selected the Medium difficulty ");
    Console.WriteLine("");
    Console.WriteLine("Now you will have to guess what number the computer has within a 1-50 range.");
    while(num != rndNum2)
    {
    mediumNumberGuesses ++;
    string guessRight = Console.ReadLine();

    bool trueG = Int32.TryParse(guessRight, out num);
        if(trueG == false)
    {
        Console.WriteLine("Next time put an actual number");
        break;
    }
        if(num > rndNum2)
    {
        Console.WriteLine("Your guess was above. Guess Again.");
    }
        if(num < rndNum2)
    {
        Console.WriteLine("Your guess was below. Guess Again");
    }
        else if(num==rndNum2)
    {
        Console.WriteLine("Congrats! You got it right!");
        Console.WriteLine("It took you " + mediumNumberGuesses + " guesses to get it right!");
    }
    }
}
else if(difficult == "hard")
    {
    Random rndNum = new Random();
    int rndNum2 = rndNum.Next(1,100);
    Console.WriteLine("You selected the Hard difficulty ");
    Console.WriteLine("");
    Console.WriteLine("Now you will have to guess what number the computer has within a 1-100 range.");
    while(num != rndNum2)
    {
    hardNumberGuesses ++;
    string guessRight = Console.ReadLine();
    bool trueG = Int32.TryParse(guessRight, out num);
        if(trueG == false)
    {
        Console.WriteLine("Next time put an actual number");
        break;
    }
        if(num > rndNum2)
    {
        Console.WriteLine("Your guess was above. Guess Again.");
    }
        if(num < rndNum2)
    {
        Console.WriteLine("Your guess was below. Guess Again");
    }
        else if(num==rndNum2)
    {
        Console.WriteLine("Congrats! You got it right!");
        Console.WriteLine("It took you " + hardNumberGuesses + " guesses to get it right!");
    }
    }
}
else if(difficult == "own")
{
    Random rndNum = new Random();

    Console.WriteLine("You've decided to make your own boundaries");
    Console.WriteLine("");
    Console.WriteLine("Give me a number to set your bounderies.");
    guessNumOne = Console.ReadLine();
    bool trueG = Int32.TryParse(guessNumOne, out num1);

    Console.WriteLine("Give me a second number that is greater than the first number.");
    guessNumTwo = Console.ReadLine();
    bool trueG2 = Int32.TryParse(guessNumTwo, out num2);

    if(trueG == false && trueG2==false)
    {
        Console.WriteLine("");
        Console.WriteLine("Play the game right next time!");
        break;
    }
    if(num2<num1)
    {
        Console.WriteLine("I said a number GREATER THAN the first number NOT less than!");
        ownLoop=false;
    }
    if(ownLoop==true)
    {
    int rndNum2 = rndNum.Next(num1,num2);
    Console.WriteLine($"Now guess a number between {num1} and {num2}.");
    while(num != rndNum2)
    {
    ownNumberGuesses ++;
    string guessRight = Console.ReadLine();
    bool trueG3 = Int32.TryParse(guessRight, out num);
    if(trueG3 == false)
    {
        Console.WriteLine("Wrong that is not a number you now have to restart");
        break;
    }
        if(num > rndNum2)
    {
        Console.WriteLine("Your guess was above. Guess Again.");
    }
        if(num < rndNum2)
    {
        Console.WriteLine("Your guess was below. Guess Again");
    }
        else if(num==rndNum2)
    {
        Console.WriteLine("Congrats! You got it right!");
        Console.WriteLine("It took you " + ownNumberGuesses + " guesses to get it right!");
    }
    }
    }
}
Console.WriteLine();
Console.WriteLine("Would you like to play again?");
Console.WriteLine("Type anything to play again. Type end to stop playing");
string stopGame = Console.ReadLine().ToLower();
if(stopGame == "end")
{
    endGame=false;
}
}