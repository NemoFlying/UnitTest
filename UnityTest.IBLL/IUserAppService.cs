using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityTest.IBLL
{
    public interface IUserAppService
    {
        string GetUser(string userName);
    }
}
