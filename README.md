# csharp-htk

A set of convenience utils for C#.


# Features

- Debug via Slack using `HTK.Utils.Debug.Send`.
- Debug via writing to local file using `HTK.Utils.Debug.FileDump`. Certifiably awesome, fast, and secure.


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

[Hacktoolkit](https://github.com/hacktoolkit) and [Jonathan Tsai](https://github.com/jontsai)

# License

MIT. See `LICENSE.md`