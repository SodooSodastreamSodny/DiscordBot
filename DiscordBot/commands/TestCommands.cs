    using DSharpPlus.CommandsNext;
    using DSharpPlus.CommandsNext.Attributes;
    using DSharpPlus.Entities;

    namespace DiscordBot.commands
    {
        public class TestCommands : BaseCommandModule
        {
            [Command("test")]
            public async Task MyFirstCommand(CommandContext ctx)
            {
                await ctx.Channel.SendMessageAsync($"CAu {ctx.User.Username}");
            }


            [Command("add")]
            public async Task Add(CommandContext ctx, int number1, int number2)
            {
                await ctx.Channel.SendMessageAsync($"Soucet je {number1 + number2}");
            }

            [Command("embed")]
            public async Task EmbedMessage(CommandContext ctx)
            {
                var msg = new DiscordEmbedBuilder()
                {
                    Title = "This is my first Discord Embed",
                    Description = $"This command was executed by {ctx.User.Username}",
                    Color = DiscordColor.HotPink
                };
                    
                await ctx.Channel.SendMessageAsync(embed: msg);
            }

            [Command("playCards")]
            public async Task PlayCards(CommandContext ctx)
            {
                var symbols = new string[] {"clubs", "Spades", "Diamonds", "Hearts"};
                
            }
            
        }
    }
