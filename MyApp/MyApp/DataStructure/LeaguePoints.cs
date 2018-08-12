using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.DataStructure
{
    public enum LeaguePoints
    {
        [Display(Name = "0-20 LP")]
        _0to20,

        [Display(Name = "21-40 LP")]
        _21to40,

        [Display(Name = "41-60 LP")]
        _41to60,

        [Display(Name = "61-80 LP")]
        _61to80,

        [Display(Name = "81-100 LP")]
        _81to100,
    }
}
