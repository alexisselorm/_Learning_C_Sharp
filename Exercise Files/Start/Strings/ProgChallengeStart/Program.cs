// See https://aka.ms/new-console-template for more information
int answer = new Random().Next(20);
bool keepGoing = true;

Console.WriteLine("Let's Play 'Guess the Number'!");
Console.WriteLine("I'm thinking of a number between 0 and 20");
Console.WriteLine("Enter you guess, or -1 to give up");

int guess = 0;
int guessCount = 0;

do
{

    // Ask the user for their current guess
    Console.WriteLine("What's your guess");
    string theGuess = Console.ReadLine();

    // Use the TryParse method to parse the input into a number
    bool result = Int32.TryParse(theGuess, out guess);

    if (!result)
    {
        Console.WriteLine("Hmm, That doesn't look like a number, please try again");
    }
    else
    {
        if (guess == -1)
        {
            Console.WriteLine($"Oh well, I was thing of {answer}");
            keepGoing = false;
        }
        else
        {
            // Increase the guessCount
            guessCount++;

            // 
            if (guess == answer)
            {
                // If they got right, tell them the guess count and exit.
                Console.WriteLine($"You got it in {guessCount} guesses");
                keepGoing = false;

            }
            else
            {
                // Tell them to either guess lower or higher than the previous guess
                Console.WriteLine("Nope, {0} than that", guess < answer ? "higher" : "lower");
            }
        }
    }
} while (keepGoing);