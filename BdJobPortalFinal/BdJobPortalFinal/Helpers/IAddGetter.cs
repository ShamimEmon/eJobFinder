using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BdJobPortalFinal.Helpers
{
    interface IAddGetter
    {
         string GetComapanyName();
         string GetVacancies();
         string GetJobNature();
         string GetLocation();
         string GetSalaries();
        
    }
}
