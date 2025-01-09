// create 3 endpoints (one controller) that takes an input, then outputs if the number is higher or lower than the number guessed.
// Easy Mode 1-10
// Medium Mode 1-50
// Hard Mode 1-100

namespace MiniChallengeEightToTen___Endpoints.Service
{
    public class GuessItService
    {
        public string reply;
        public GuessItService()
        {
            reply = "Error: No number guessed";
        }
        public string GetResponse(string mode, string guess)
        {
            mode = mode.ToLower();
            if (!int.TryParse(guess, out int convertedGuess))
            {
                return "Invalid guess. Please enter a valid number.";
            }

            switch (mode)
            {
                case "easy":
                    int rng = new Random().Next(1, 11);
                    if (convertedGuess == rng)
                    {
                        reply = "Correct!";
                    }
                    else if (convertedGuess > rng)
                    {
                        reply = "Lower!";
                    }
                    else if (convertedGuess < rng)
                    {
                        reply = "Higher!";
                    }
                    break;
                case "medium":
                    int MediumRng = new Random().Next(1, 51);
                    if (convertedGuess == MediumRng)
                    {
                        reply = "Correct!";
                    }
                    else if (convertedGuess > MediumRng)
                    {
                        reply = "Lower!";
                    }
                    else if (convertedGuess < MediumRng)
                    {
                        reply = "Higher!";
                    }
                    break;
                case "hard":
                    int HardRng = new Random().Next(1, 101);
                    if (convertedGuess == HardRng)
                    {
                        reply = "Correct!";
                    }
                    else if (convertedGuess > HardRng)
                    {
                        reply = "Lower!";
                    }
                    else if (convertedGuess < HardRng)
                    {
                        reply = "Higher!";
                    }
                    break;
            }
            return reply;
        }
    }
}