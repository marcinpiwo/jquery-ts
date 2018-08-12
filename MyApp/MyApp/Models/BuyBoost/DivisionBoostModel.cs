using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MyApp.DataStructure;

namespace MyApp.Models.BuyBoost
{
    public class DivisionBoostModel
    {
        [Required]
        public League StartingLeague { get; set; }

        [Required]
        public Division StartingDivision { get; set; }

        [Required]
        public League DesiredLeague { get; set; }

        [Required]
        public Division DesiredDivision { get; set; }

        [Required]
        public LeaguePoints LeaguePoints { get; set; }
    }
}
