using Apps.Supertext.Callbacks.Payload;
using Blackbird.Applications.Sdk.Common.Webhooks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Supertext.Callbacks
{
    [WebhookList]
    public class CallbackList
    {
        [Webhook("On file translated", Description = "On file translated")]
        public async Task<WebhookResponse<FileTranslatedEvent>> ProjectCreation(WebhookRequest webhookRequest)
        {
            var data = JsonConvert.DeserializeObject<FileTranslatedEvent>(webhookRequest.Body.ToString());
            if (data is null)
            {
                throw new InvalidCastException(nameof(webhookRequest.Body));
            }
            return new WebhookResponse<FileTranslatedEvent>
            {
                HttpResponseMessage = null,
                Result = data
            };
        }
    }
}
