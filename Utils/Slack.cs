using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Htk.Utils
{
    public class Slack
    {
        /// <summary>
        /// Slack Webhook URL.
        /// See: <see href="https://api.slack.com/messaging/webhooks"/>
        /// </summary>
        public Uri WebhookUrl
        {
            private get;
            set;
        }

        /// <summary>
        /// Sends message using slack Apps with new webhooks
        /// </summary>
        /// <param name="webhook">Your slack App webhook URL. See: <see href="https://api.slack.com/messaging/webhooks"/></param>
        public Slack(string webhook)
        {
            WebhookUrl = new Uri(webhook);
        }

        /// <summary>
        /// Sends message to Slack.
        /// </summary>
        /// <param name="text">Text to send</param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="WebException"></exception>
        public void Send(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentException($"'{nameof(text)}' cannot be null or empty.", nameof(text));
            }

            using (WebClient client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                var response = client.UploadString(WebhookUrl, "POST", $@"{{""text"": '{ text.Replace(@"""", @"\""") }'}}");
            }
        }

        /// <summary>
        /// Sends message to Slack.
        /// </summary>
        /// <param name="webhook">webhook uri</param>
        /// <param name="text">Text to send</param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="WebException"></exception>
        public static Slack Send(string webhook, string text)
        {
            Slack obj = new Slack(webhook);

            obj.Send(text);

            return obj;
        }
    }
}
