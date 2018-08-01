using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaSplit.Models
{
    class AlphaSplitDefinition
    {
        public static int AssignToTeam(CaseName caseName)
        {
            if (caseName.InAlphaRange(new CaseName("A", ""), new CaseName("EB", "") ))
            {
                return 1;
            }
            else if (caseName.InAlphaRange(new CaseName("EC", ""), new CaseName("Lopez", "JA"), false, false, true, false))
            {
                return 2;
            }
            else if (caseName.InAlphaRange(new CaseName("Lopez", "JB"), new CaseName("Reyes", "F"), true, false, true, false))
            {
                return 3;
            }
            else if (caseName.InAlphaRange(new CaseName("Reyes", "G"), new CaseName("Z", ""), true, false, false, false))
            {
                return 4;
            }
            else
            {
                return 0;
            }
        }
    }
}
