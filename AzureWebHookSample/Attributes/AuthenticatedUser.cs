using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace AzureWebHookSample.Attributes
{
    public class AuthenticatedUser : IIdentity
    {

        public AuthenticatedUser(string authenticateType,bool isAuthenticated,string name)
        {

            AuthenticationType = authenticateType;
            IsAuthenticated = isAuthenticated;
            Name = name;
        }




        public string AuthenticationType { get; }

        public bool IsAuthenticated { get; }

        public string Name { get; }
    }
}
