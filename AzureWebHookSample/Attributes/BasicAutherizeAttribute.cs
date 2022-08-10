using AzureWebHookSample.Services;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;


namespace AzureWebHookSample.Attributes
{
    public class BasicAutherizeAttribute : AuthorizeAttribute
    {
        public BasicAutherizeAttribute()
        {
            Policy = "BasicAuthentication";
        }
    }
}
