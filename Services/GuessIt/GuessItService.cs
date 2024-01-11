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
                return $"{inputNum} is GREATER than the actual number.";
            }

            if (inputNum < easyNum)
            {
                return $"{inputNum} is LESS than the actual number.";
            }

            return $"{inputNum} is EQUAL to the actual number!";
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
                return $"{inputNum} is GREATER than the actual number.";
            }

            if (inputNum < mediumNum)
            {
                return $"{inputNum} is LESS than the actual number.";
            }

            return $"{inputNum} is EQUAL to the actual number!";
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
                return $"{inputNum} is GREATER than the actual number.";
            }

            if (inputNum < hardNum)
            {
                return $"{inputNum} is LESS than the actual number.";
            }

            return $"{inputNum} is EQUAL to the actual number!";
        }
        else
        {
            return "Error: You must enter an integer number.";
        }
    }
}
