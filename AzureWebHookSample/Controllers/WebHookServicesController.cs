using AzureWebHookSample.Attributes;
using AzureWebHookSample.Modals;
using AzureWebHookSample.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace AzureWebHookSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebHookServicesController : ControllerBase
    {
        private readonly IAzureWebHookService _azureWebHookService;
        public WebHookServicesController(IAzureWebHookService azureWebHookService)
        {
            _azureWebHookService = azureWebHookService;
        }

        [BasicAutherize]
        [HttpPost]
        public IActionResult AzureWebHookSampleNoModal([FromBody] JsonElement jsonElement)
        {
            string request = jsonElement.ToString();
            var response = _azureWebHookService.SendMail(request);
            return Ok(response);

        }

        [HttpPost("AzureWebHookSampleWithModal")]
        public IActionResult AzureWebHookSampleWithModal([FromBody] AzureResponseModals content)
        {
            string request = content.ToString();
            var response = _azureWebHookService.SendMailWithModal(content);
            return Ok(response);

        }



    }
}
