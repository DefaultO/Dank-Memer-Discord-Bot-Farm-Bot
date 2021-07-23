using System;
using System.Collections.Generic;
using System.Threading;
using Discord;
using Discord.Gateway;

namespace MessageLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            DiscordSocketClient client = new DiscordSocketClient();
            client.OnLoggedIn += OnLoggedIn;
            client.OnMessageReceived += OnMessageReceived;
			
            // Console.Write("Token: ");
            // client.Login(Console.ReadLine());
            client.Login("PUT YOUR DISCORD TOKEN HERE");
            Thread.Sleep(-1);
        }


        private static void OnLoggedIn(DiscordSocketClient client, LoginEventArgs args)
        {
            Console.WriteLine($"Logged into {args.User}");
        }

        private static void OnMessageReceived(DiscordSocketClient client, MessageEventArgs args)
        {
            DiscordChannel channel = client.GetChannel(args.Message.Channel.Id);

            if (channel.Id != 620603662968029205)
                return;

            string message = args.Message.Content;
            if (args.Message.ReferencedMessage == null)
                return;

            if (args.Message.Author.User.Id == 270904126974590976 && args.Message.ReferencedMessage.Author.User.Id == client.User.Id)
            {
                if (!message.Contains("`"))
                    return;

                if (!message.Contains("Where do you want to search?"))
                    return;

                string[] split = args.Message.Content.Split('`');
                List<string> options = new List<string>() { split[1], split[3], split[5] };

                List<string> chancesOfDeath = new List<string>()
                {
                    "air",
                    "area51",
                    "attic",
                    "bank",
                    "basement",
                    "bed",
                    "bushes",
                    "car",
                    "couch",
                    "crawlspace",
                    "discord",
                    "dog",
                    "dumpster",
                    "glovebox",
                    "hospital",
                    "mels room",
                    "purse",
                    "sewer",
                    "street",
                    "tree",
                    "uber",
                    "van"
                };

                string safeOption = "";
                foreach (string option in options)
                {
                    if (chancesOfDeath.Contains(option))
                        continue;

                    safeOption = option;
                }

                if (!string.IsNullOrEmpty(safeOption))
                {
                    Console.WriteLine($"Selected '{safeOption}' because it's the lowest with 0%");
                    client.SendMessageAsync(channel.Id, safeOption);
                }
                else
                {
					/*
					Air - 10% | forget to breath
					Area 51 - 50% | shot by Government
					Attic - 2.5% | killed by hobo or insulation
					Bank - 40% | shot by bank robber
					Basement - 0.5 | drowning
					Bed - 2% | killed by hooker
					Bushes - 1.5% | prickled to death
					Car - 1% | shot by Police
					Couch - ?% | peanut butter stuffed in couch cushions and you were allergic to peanuts
					Crawlspace - 1% | killed by mutant spider
					Discord - 2% | catfished by discord
					Dog - 1% | infected by dog disease OR getting bitten
					Dumpster - 5% | killed by given sandwich
					Glovebox - 1% | caught by your mom
					Hospital - 15% | infected by dog disease
					Mels Room - 1% | eaten by Dauntless
					Purse - 40% | murdered by old woman
					Sewer - 15% | drowning in pss and sht
					Street - 7% | hit by car
					Tree - 4% | fell from tree
					Uber - 1.5% | murdered by taxi driver
					Van - 1% | killed by van driver
					*/
                    Dictionary<string, float> propability = new Dictionary<string, float>()
                    {
                        { "air", 10f },
                        { "area51", 50f },
                        { "attic", 2.5f },
                        { "bank", 40f },
                        { "basement", 0.5f },
                        { "bed", 2f },
                        { "bushes", 1.5f },
                        { "car", 1f },
                        { "couch", 1.5f },
                        { "crawlspace", 1f },
                        { "discord", 2f },
                        { "dog", 1f },
                        { "dumpster", 5f },
                        { "glovebox", 1f },
                        { "hospital", 15f },
                        { "mels room", 1f },
                        { "purse", 40f },
                        { "sewer", 15f },
                        { "street", 7f },
                        { "tree", 4f },
                        { "uber", 1.5f },
                        { "van", 1f }
                    };

                    float smallestChance = 100.0f;
                    string choice = "";
                    foreach (string option in options)
                    {
                        float chance = propability[option];
                        if (chance < smallestChance)
                        {
                            choice = option;
                            smallestChance = chance;
                        }
                    }

                    Console.WriteLine($"Selected '{choice}' because it's the lowest with {smallestChance}%");
                    client.SendMessageAsync(channel.Id, choice);
                }

                Thread.Sleep(20000);
                client.SendMessageAsync(channel.Id, "pls scout");
            }
        }
    }
}
