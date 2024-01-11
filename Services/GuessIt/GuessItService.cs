namespace EightToTenEndpoints.Services.GuessIt;

public class GuessItService : IGuessItService
{
    public string EasyGuess(string input)
    {
        Random guessNumber = new Random();
        int easyNum = guessNumber.Next(10);

        bool numSuccess = Int32.TryParse(input, out int inputNum);

        if (numSuccess)
        {
            if (inputNum > easyNum)
            {
                return $"{inputNum} was GREATER than the actual number. Sorry!";
            }

            if (inputNum < easyNum)
            {
                return $"{inputNum} was LESS than the actual number. Aw, shucks!";
            }

            return $"{inputNum} was the actual number! Today, will be a lucky day! :)";
        }
        else
        {
            return "Error: You must enter an integer number.";
        }
    }

    public string MediumGuess(string input)
    {
        Random guessNumber = new Random();
        int mediumNum = guessNumber.Next(50);

        bool numSuccess = Int32.TryParse(input, out int inputNum);

        if (numSuccess)
        {
            if (inputNum > mediumNum)
            {
                return $"{inputNum} was GREATER than the actual number. Sorry!";
            }

            if (inputNum < mediumNum)
            {
                return $"{inputNum} was LESS than the actual number. Boo!";
            }

            return $"{inputNum} was the actual number! You are a lucky one! :p";
        }
        else
        {
            return "Error: You must enter an integer number.";
        }
    }

    public string HardGuess(string input)
    {
        Random guessNumber = new Random();
        int hardNum = guessNumber.Next(100);

        bool numSuccess = Int32.TryParse(input, out int inputNum);

        if (numSuccess)
        {
            if (inputNum > hardNum)
            {
                return $"{inputNum} was GREATER than the actual number. Sorry!";
            }

            if (inputNum < hardNum)
            {
                return $"{inputNum} was LESS than the actual number. Oh, well!";
            }

            return $"{inputNum} was the actual number! Luck is on your side, my friend! :o";
        }
        else
        {
            return "Error: You must enter an integer number.";
        }
    }
}
