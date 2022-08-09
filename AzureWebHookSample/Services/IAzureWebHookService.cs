using AzureWebHookSample.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureWebHookSample.Services
{
    public interface IAzureWebHookService
    {

        public string SendMail(string request);
        public string SendMailWithModal(AzureResponseModals request);


    }
}
