using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.DataStructure
{
    public enum Division
    {
        [Display(Name = "Division V")]
        V = 1,

        [Display(Name = "Division IV")]
        IV = 2,

        [Display(Name = "Division III")]
        III = 3,

        [Display(Name = "Division II")]
        II = 4,

        [Display(Name = "Division I")]
        I = 5
    }
}
