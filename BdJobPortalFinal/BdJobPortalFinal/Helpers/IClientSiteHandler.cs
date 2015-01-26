using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BdJobPortalFinal.Helpers
{
   public interface IClientSiteHandler
    {
         void GetInput();
         void ClearFields();
         void SetErrMsg();
         bool IsAllFieldsOk();
    }
}
