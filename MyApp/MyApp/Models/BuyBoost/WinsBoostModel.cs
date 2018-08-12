using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MyApp.DataStructure;

namespace MyApp.Models.BuyBoost
{
    public class WinsBoostModel
    {
        [Required]
        public League StartingLeague { get; set; }

        [Required]
        public Division StartingDivision { get; set; }

        [Required]
        [Range(1, 10, ErrorMessage = "You can only choose value from 0 to 10")]
        public int WinsCount { get; set; }
    }
}
