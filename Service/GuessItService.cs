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
        public string EasyMode(string guess)
        {
            if (!int.TryParse(guess, out int convertedGuess))
            {
                return "Invalid guess. Please enter a valid number.";
            }

            int rng = new Random().Next(1, 11);
            if (convertedGuess == rng)
            {
                reply = "Correct!" + " The number was " + rng;
            }
            else if (convertedGuess > rng)
            {
                reply = "Lower!" + " The number was " + rng;
            }
            else if (convertedGuess < rng)
            {
                reply = "Higher!" + " The number was " + rng;
            }
            return reply;
        }

        public string MediumMode(string guess)
        {
            if (!int.TryParse(guess, out int convertedGuess))
            {
                return "Invalid guess. Please enter a valid number.";
            }

            int rng = new Random().Next(1, 51);
            if (convertedGuess == rng)
            {
                reply = "Correct!" + " The number was " + rng;
            }
            else if (convertedGuess > rng)
            {
                reply = "Lower!" + " The number was " + rng;
            }
            else if (convertedGuess < rng)
            {
                reply = "Higher!" + " The number was " + rng;
            }
            return reply;
        }

        public string HardMode(string guess)
        {
            if (!int.TryParse(guess, out int convertedGuess))
            {
                return "Invalid guess. Please enter a valid number.";
            }

            int rng = new Random().Next(1, 101);
            if (convertedGuess == rng)
            {
                reply = "Correct!" + " The number was " + rng;
            }
            else if (convertedGuess > rng)
            {
                reply = "Lower!" + " The number was " + rng;
            }
            else if (convertedGuess < rng)
            {
                reply = "Higher!" + " The number was " + rng;
            }
            return reply;
        }
    }
}