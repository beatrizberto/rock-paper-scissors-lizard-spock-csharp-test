using Microsoft.AspNetCore.Mvc;
using System;

namespace GameRockPaperScissorsLizardSpockAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        [HttpGet("Play/{playerChoice}")]
        public ActionResult<string> Play(int playerChoice)
        {
             if (playerChoice < 1 || playerChoice > 5)
            {
                return BadRequest("Uh-Oh! Invalid move. Please choose rock, paper, scissors, lizard or Spock. ò__ó");
            }
            
            
            int computerChoice = GenerateComputerChoice();
            string result = DetermineResult(playerChoice, computerChoice);

            return $"{TranslateChoice(playerChoice)} vs {TranslateChoice(computerChoice)} - {result.ToString()}";
        }

        private int GenerateComputerChoice()
        {
            Random random = new Random();
            return random.Next(1, 6);
        }

        private string DetermineResult(int playerChoice, int computerChoice)
        {
            if (playerChoice == computerChoice)
            {
                return "Oh, it's a draw. Try again!";
            }
            else if ((playerChoice == 1 && (computerChoice == 3 || computerChoice == 4))
                    || (playerChoice == 2 && (computerChoice == 1 || computerChoice == 5))
                    || (playerChoice == 3 && (computerChoice == 2 || computerChoice == 4))
                    || (playerChoice == 4 && (computerChoice == 2 || computerChoice == 5))
                    || (playerChoice == 5 && (computerChoice == 1 || computerChoice == 3)))
            {
                return "You win!";
            }
            else
            {
                return "You loose...";
            }
        }

        private string TranslateChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    return "Rock";
                case 2:
                    return "Paper";
                case 3:
                    return "Scissors";
                case 4:
                    return "Lizard";
                case 5:
                    return "Spock";
                default:
                    return "Ivalid move";
            }
        }
    }

    
}
