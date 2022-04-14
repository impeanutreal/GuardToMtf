using Exiled.API.Features;
using Exiled.API.Enums;
using System;

using Server = Exiled.Events.Handlers.Server;

namespace GuardToMtf
{
    public class Main : Plugin<Config>
    {
        private static readonly Lazy<Main> LazyInstance = new Lazy<Main>(() => new Main());
        public static Main Instance => LazyInstance.Value;


        public override PluginPriority Priority { get; } = PluginPriority.Low;


        private Start start;

        public override void OnEnabled()
        {
            RegisterEvents();
        }

        public override void OnDisabled()
        {
            UnregisterEvents();
        }

        public void RegisterEvents()
        {
            start = new Start();

            Server.RoundStarted += start.OnRoundStarted;
        }

        public void UnregisterEvents()
        {
            Server.RoundStarted -= start.OnRoundStarted;
        }
        }
}
