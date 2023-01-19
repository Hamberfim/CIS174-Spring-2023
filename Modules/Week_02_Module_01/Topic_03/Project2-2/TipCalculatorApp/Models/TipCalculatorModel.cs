using System.ComponentModel.DataAnnotations;

namespace TipCalculatorApp.Models
{
    public class TipCalculatorModel
    {
        [Required(ErrorMessage = "Please enter a numeric meal cost greater than zero.")]
        [Range(1, 1000, ErrorMessage = "Please enter a numeric meal cost greater than zero.")]
        public decimal? CostOfMeal { get; set; }


        public (decimal? tip15, decimal? tip20, decimal? tip25) CaclulateTip()
        {

            // constants
            const decimal FifteenPercent = 0.15m;
            const decimal TwentyPercent = 0.20m;
            const decimal TwentyFivePercent = 0.25m;

            decimal? tip15 = CostOfMeal * FifteenPercent;
            decimal? tip20 = CostOfMeal * TwentyPercent;
            decimal? tip25 = CostOfMeal * TwentyFivePercent;

            // return tuple
            return (tip15, tip20, tip25);
        }

    }
}
