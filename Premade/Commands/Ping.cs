﻿using DNet.Structures;
using ForgeSharp.Commands;
using ForgeSharp.Core;
using System.Diagnostics;

namespace ForgeSharp.Premade.Commands
{
    public class Ping : PremadeCommand
    {
        public override string Name => "ping";

        public override string Description => "Displays the bot's latency";

        public override string Version => "1.0.0";

        // TODO: Measure time
        public override async void Run(Context context)
        {
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();

            Message msg = await context.Reply("Ping?");

            if (msg != null)
            {
                stopWatch.Stop();
                await msg.Edit($":ping_pong: Pong! ~{stopWatch.ElapsedMilliseconds}ms");
            }
        }
    }
}
