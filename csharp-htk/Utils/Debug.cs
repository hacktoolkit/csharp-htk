using Newtonsoft.Json;
using System;
using System.IO;

namespace HTK.Utils
{
    public class Debugers
    {
        private const string DEFAULT_FILE_PATH = "fdebug.log";
        /// <summary>
        /// Counter of how many times the debug used. Can be set to any integer you want, anytime you want.
        /// </summary>
        public static int Counter { get; set; } = 0;

        /// <summary>
        /// Filepath for the debug
        /// </summary>
        public static string FilePath { get; set; } = DEFAULT_FILE_PATH;

        /// <summary>
        /// Set the webhook URL
        /// </summary>
        public static string SlackWebhookUrl { get; set; }

        /// <summary>
        /// Writes given string to file.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="filename"></param>
        public static void fdebug(string text, string filename = null)
        {
            string time = $"{DateTime.Now.ToString("s")}";

            using (StreamWriter sw = new StreamWriter(filename ?? FilePath))
            {
                sw.WriteLine($">>>>>>>>>> FDEBUG {time} {++Counter} <<<<<<<<<<");
                sw.WriteLine(text);
                sw.WriteLine($">>>>>>>>>> FDEBUG {time} {Counter} <<<<<<<<<<");
            }
        }

        /// <summary>
        /// Serializes given object and write the result to a file.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="filename"></param>
        public static void fdebug(object obj, string filename = null)
        {
            string serialized = JsonConvert.SerializeObject(obj);

            fdebug(serialized, filename);
        }

        /// <summary>
        /// Sends given text to Slack.
        /// </summary>
        /// <param name="text">Text to send</param>
        /// <param name="label">Label for the text.</param>
        public static void ToSlack(string text, string label)
        {
            Slack.Send(SlackWebhookUrl, $"{label}: {text}");
        }

        /// <summary>
        /// Sends given text to Slack.
        /// </summary>
        /// <param name="text">Text to send</param>
        public static void ToSlack(string text)
        {
            Slack.Send(SlackWebhookUrl, text);
        }

        /// <summary>
        /// Sends given object to Slack as json string.
        /// </summary>
        /// <param name="obj"></param>
        public static void ToSlack(object obj)
        {
            string serialized = JsonConvert.SerializeObject(obj);
            Slack.Send(SlackWebhookUrl, serialized);
        }
    }
}
