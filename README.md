# Dank-Memer-Discord-Bot-Farm-Bot
Using the [Anarchy Framework](https://github.com/not-ilinked/Anarchy) for Discord Selfbots, I've coded a simple logic together that farms you some bot currency. The more alt accounts you have, the more you will profit from it. In something like 5 hours I've made **700.000+ "⏣"** with 1 Account only. Note that I have donator privilege and thus have to wait 10 seconds less than you between commands uses.

This here abused Bot can be found here: https://dankmemer.lol/

I hardcoded a specific channel in this bot which you gotta have to edit to your desired channel instead in which you want to farm. In order to start the Bot then, all you have to do is provide the Bot with your discord account token and type "pls scout" or "pls search" and send it into the channel, so that the bot replies with the available options. **Optional:** use items that prevent you from dying and losing "⏣" such as the life-saver and an apple. You will get the "⏣" back you spent buying these. And it makes all options impossible to hurt the bot's progress.

In case you want to compile the Anarchy Library yourself, you will have to put this here before the used ``HttpClient()`` gets created ([**HERE**](https://github.com/not-ilinked/Anarchy/blob/231c41aeb4955e8c0d63ee3bf38e6638cd9b778b/Anarchy/REST/SuperProperties.cs#L16)), Discord only allows up-to-date security connections.
```csharp
ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
```
