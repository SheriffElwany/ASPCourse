using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
   public class MuneItemsRepo
    {
        public static List<MuneItem> GetMuneItems()
        {
            return new List<MuneItem>
            {
                new MuneItem(){Title="burger",Price=5.0F},
                new MuneItem(){Title="beef",Price=7.5F},
                new MuneItem(){Title="chickn",Price=10.00F},
                new MuneItem(){Title="pizza",Price=15.00F}
            };

        }
    }
}
