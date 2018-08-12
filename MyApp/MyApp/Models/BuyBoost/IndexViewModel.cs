using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models.BuyBoost
{
    public class IndexViewModel
    {
        public IndexViewModel()
        {
            DivisionBoostModel = new DivisionBoostModel();
            WinsBoostModel = new WinsBoostModel();
        }

        public DivisionBoostModel DivisionBoostModel { get; set; }

        public WinsBoostModel WinsBoostModel { get; set; }
    }
}
