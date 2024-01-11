namespace EightToTenEndpoints.Services.GuessIt;

public interface IGuessItService
{
    string EasyGuess(string input);
    string MediumGuess(string input);
    string HardGuess(string input);
}
