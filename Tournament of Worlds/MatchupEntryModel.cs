using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_of_Worlds
{
    class MatchupEntryModel
    {
     
        public TeamModel TeamCompeting { get; set; }
      
        public double Score { get; set; }
      
        public MatchupModel ParentMatchup { get; set; }
    }
}
