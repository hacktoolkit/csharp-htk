using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Htk.Utils
{
    public static class Debuggers
    {
        private const string DEFAULT_FILE_PATH = "fdebug.log";

        public static int Counter { get; set; } = 0;

        public static string FilePath { get; set; } = DEFAULT_FILE_PATH;

        /// <summary>
        /// Set the Slack webhook URL
        /// </summary>
        public static string SlackWebhookUrl { get; set; }

        /// <summary>
        /// Writes given string to file.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="fileName"></param>
        public static void FileDebug(string text, string fileName = null)
        {
            string time = $"{DateTime.Now.ToString("s")}";

            using (StreamWriter sw = new StreamWriter(fileName ?? FilePath))
            {
                sw.WriteLine($">>>>>>>>>> FDEBUG {time} {++Counter} <<<<<<<<<<");
                sw.WriteLine(text);
                sw.WriteLine($">>>>>>>>>> FDEBUG {time} {Counter} <<<<<<<<<<");
            }
        }

        /// <summary>
        /// Writes given object to file as JSON.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="fileName"></param>
        public static void FileDebug(object obj, string fileName = null)
        {
            FileDebug(JsonConvert.SerializeObject(obj), fileName);
        }

        /// <summary>
        /// Sends given string to Slack.
        /// </summary>
        /// <param name="text">Text to send</param>
        public static Slack SlackDebug(string text)
        {
            return Slack.Send(SlackWebhookUrl, text);
        }

        /// <summary>
        /// Sends given string to Slack.
        /// </summary>
        /// <param name="text">Text to send</param>
        /// <param name="label">Label for the text.</param>
        public static Slack SlackDebug(string text, string label)
        {
            return Slack.Send(SlackWebhookUrl, $"{label}: {text}");
        }

        /// <summary>
        /// Sends given object to Slack as JSON.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Slack Instance</returns>
        public static Slack SlackDebug(object obj)
        {
            return Slack.Send(SlackWebhookUrl, JsonConvert.SerializeObject(obj));
        }

        /// <summary>
        /// Sends given object to Slack as JSON.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="label">Label for the text.</param>
        /// <returns>Slack Instance</returns>
        public static Slack SlackDebug(object obj, string label)
        {
            return Slack.Send(SlackWebhookUrl, $"{label}: {JsonConvert.SerializeObject(obj)}");
        }

        // Aliases

#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// Writes given string to file.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="fileName"></param>
        public static void fdebug(string text, string fileName = null)
        {
            FileDebug(text, fileName);
        }

        /// <summary>
        /// Writes given object to file as JSON.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="fileName"></param>
        public static void fdebug(object obj, string fileName = null)
        {
            FileDebug(JsonConvert.SerializeObject(obj), fileName);
        }

        /// <summary>
        /// Sends given text to Slack.
        /// </summary>
        /// <param name="text"></param>
        /// <returns>Slack Instance</returns>
        public static Slack slack_debug(string text)
        {
            return Slack.Send(SlackWebhookUrl, text);
        }

        /// <summary>
        /// Sends given text to Slack.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="label"></param>
        /// <returns>Slack Instance</returns>
        public static Slack slack_debug(string text, string label)
        {
            return Slack.Send(SlackWebhookUrl, $"{label}: {text}");
        }

        /// <summary>
        /// Sends given object to Slack as JSON.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Slack Instance</returns>
        public static Slack slack_debug(object obj)
        {
            return Slack.Send(SlackWebhookUrl, JsonConvert.SerializeObject(obj));
        }

        /// <summary>
        /// Sends given object to Slack as JSON.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="label"></param>
        /// <returns>Slack Instance</returns>
        public static Slack slack_debug(object obj, string label)
        {
            return Slack.Send(SlackWebhookUrl, $"{label}: {JsonConvert.SerializeObject(obj)}");
        }
#pragma warning restore IDE1006 // Naming Styles
    }
}
