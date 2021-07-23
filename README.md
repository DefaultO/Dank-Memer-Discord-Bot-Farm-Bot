# Dank-Memer-Discord-Bot-Farm-Bot
Using the [Anarchy Framework](https://github.com/not-ilinked/Anarchy) for Discord Selfbots, I've coded a simple logic together that farms you some bot currency. The more alt accounts you have, the more you will profit from it. In something like 5 hours I've made **700.000+ ⏣** with 1 Account only. Note that I have donator privilege and thus have to wait 10 seconds less than you between commands uses.

This here abused Bot can be found here: https://dankmemer.lol/

In case you want to compile the Anarchy Library yourself, you will have to put this here before the used ``HttpClient()`` gets created (found [**HERE**](https://github.com/not-ilinked/Anarchy/blob/231c41aeb4955e8c0d63ee3bf38e6638cd9b778b/Anarchy/REST/SuperProperties.cs#L16)), Discord only allows up-to-date security connections.
```csharp
ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
```
