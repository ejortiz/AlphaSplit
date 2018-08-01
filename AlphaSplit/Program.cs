using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlphaSplit.Models;

namespace AlphaSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseName name1 = new CaseName("Barr", "Phil"); // 1
            CaseName name2 = new CaseName("Fernandez", "Antonio"); //2 
            CaseName name3 = new CaseName("Ortiz", "Eliud"); // 3
            CaseName name4 = new CaseName("Zepeda", "Ernesto");  // 4
            CaseName name5 = new CaseName("Ebor", "John"); // 1
            CaseName name6 = new CaseName("Eckhart", "Dennis"); // 2
            CaseName name7 = new CaseName("Lopez", "Jacob"); //2 
            CaseName name8 = new CaseName("Lope", "Jeff");  // 2
            CaseName name9 = new CaseName("Reyes", "Gordon"); // 4
            CaseName name10 = new CaseName("Reyes", "Felipe"); //3


            CaseName name11 = new CaseName("Lopezo", "Jacob"); // 3;            
            CaseName name12 = new CaseName("Reyes-Jarman", "Geronimo"); // 4;
            CaseName name13 = new CaseName("Lopez-Guzman", "Jacob"); // 3;


            Debug.Assert(AlphaSplitDefinition.AssignToTeam(name13) == 3);

            Debug.Assert(AlphaSplitDefinition.AssignToTeam(name1) == 1);

            Debug.Assert(AlphaSplitDefinition.AssignToTeam(name2) == 2);

            Debug.Assert(AlphaSplitDefinition.AssignToTeam(name3) == 3);

            Debug.Assert(AlphaSplitDefinition.AssignToTeam(name4) == 4);

            Debug.Assert(AlphaSplitDefinition.AssignToTeam(name5) == 1);

            Debug.Assert(AlphaSplitDefinition.AssignToTeam(name6) == 2);

            Debug.Assert(AlphaSplitDefinition.AssignToTeam(name7) == 2);

            Debug.Assert(AlphaSplitDefinition.AssignToTeam(name8) == 2);

            Debug.Assert(AlphaSplitDefinition.AssignToTeam(name9) == 4);

            Debug.Assert(AlphaSplitDefinition.AssignToTeam(name10) == 3);

            Debug.Assert(AlphaSplitDefinition.AssignToTeam(name11) == 3);

            Debug.Assert(AlphaSplitDefinition.AssignToTeam(name12) == 4);

            






            Console.WriteLine("Finished running.");
            Console.ReadKey();













        }
    }
}
