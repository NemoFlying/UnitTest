using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityTest.IBLL;

namespace UnityTest.BLL
{
    public class UserAppService : IUserAppService
    {
        public string GetUser(string userName)
        {
            return "BLL User";
        }
    }
}
