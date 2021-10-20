# csharp-htk

A set of convenience utils for C#.


# Features

- Debug via Slack using `Htk.Utils.Debuggers.SlackDebug`.
- Debug via writing to local file using `Htk.Utils.Debuggers.FileDebug`. Certifiably awesome, fast, and secure.


# Setters & Methods
- `Htk.Utils.Debuggers.FilePath` You can set a default file path for `FileDebug` method.
- `Htk.Utils.Debuggers.SlackWebhookUrl` Set yout Slack Webhook URL. `SlackDebug` method uses this URL.
- `Htk.Utils.Debuggers.FileDebug(string text, string fileName = DEFALT_FILE_PATH)` uses `FilePath` if `fileName` is omited.
- `Htk.Utils.Debuggers.FileDebug(object obj, string fileName = DEFALT_FILE_PATH)` dumps given object to file using JSON Serialization. uses `FilePath` if `fileName` is omited.
- `Htk.Utils.Debuggers.SlackDebug(string text)` Sends the given string to Slack.
- `Htk.Utils.Debuggers.SlackDebug(string text, string label)` Sends the given string to Slack. Format: label: text
- `Htk.Utils.Debuggers.SlackDebug(object obj)` Sends the given object as JSON to Slack.
- `Htk.Utils.Debuggers.SlackDebug(object obj, string label)` Sends the given object as JSON to Slack. Format: label: JSON Dump of object

**NOTE:** `FileDebug` has `fdebug` alias and `SlackDebug` has `slack_debug` alias for easy usage.

# How To Use This Awesome?

1. Install via nuget.
1. (**Alternative install via clone**) Install via local clone: clone this repository into a directory named `htk`  
    SSH: `git clone git@github.com:hacktoolkit/csharp-htk.git htk`  
    HTTPS: `git clone https://github.com/hacktoolkit/csharp-htk.git`
1. Add your [Slack incoming webhook](https://slack.com/apps/A0F7XDUAZ-incoming-webhooks) URL.
1. Check your Slack to verify that the message was posted. If not, perhaps your token was wrong, or the Slack integration was disabled.
    ![image](https://user-images.githubusercontent.com/422501/61013274-e65e1e00-a336-11e9-90aa-44a6fd1e217c.png)  
    (Alternative link to screenshot above: https://cl.ly/436cfb4383a2)
1. Profit!

# Authors and Maintainers

- [Hacktoolkit](https://github.com/hacktoolkit)
- [Jonathan Tsai](https://github.com/jontsai)
- [Gökhan Öztürk](https://github.com/Quanthir)

# License

MIT. See `LICENSE.md`
