using Rocket.API.DependencyInjection;
using Rocket.API.Eventing;
using Rocket.Core.Eventing;
using Rocket.Core.Player.Events;
using Rocket.Core.Plugins;
using Rocket.Core.User;
using System;
using System.IO;

namespace AdvancedLogger
{
     public class Main : Plugin<Config>
    {

        public string AdvancedLogFile = System.IO.Directory.GetCurrentDirectory() + @"\Plugins\AdvancedLogger\CommandLog.txt";
        public string ChatLogFile = System.IO.Directory.GetCurrentDirectory() + @"\Plugins\AdvancedLogger\ChatLog.txt";


        public Main(IDependencyContainer container) : base("AdvancedLogger", container)
        {
        }
        protected override void OnLoad(bool isFromReload)
        {
            if (!File.Exists(AdvancedLogFile))
            {
                Logger.Log("[AdvancedLogger] Log.txt Not Found! Creating new file...");
                System.IO.File.Create(AdvancedLogFile).Close();
            }
            if (!File.Exists(ChatLogFile))
            {
                Logger.Log("[AdvancedLogger] Log.txt Not Found! Creating new file...");
                System.IO.File.Create(ChatLogFile).Close();
            }
            else
            {
                Logger.Log("[AdvancedLogger] Commands Log File Exists, Skipping Creation Process!");
                Logger.Log("[AdvancedLogger] Chat Log File Exists, Skipping Creation Process!");
            }
            Logger.Log("[AdvancedLogger] Made by: Jonnyfencing1");
            Logger.Log("[AdvancedLogger] Check out my personal plugin website https://tridentplugins.me");
            Logger.Log("----------------------------------------------");
            Logger.Log("[AdvancedLogger] Log Vanish Command: " + ConfigurationInstance.LogVanish);
            Logger.Log("[AdvancedLogger] Log Item Command: " + ConfigurationInstance.LogI);
            Logger.Log("[AdvancedLogger] Log God Command: " + ConfigurationInstance.LogGod);
            Logger.Log("[AdvancedLogger] Log V Command: " + ConfigurationInstance.LogV);
            Logger.Log("[AdvancedLogger] Log Teleport Commands: " + ConfigurationInstance.LogTP);
            Logger.Log("[AdvancedLogger] Log Spy Command: " + ConfigurationInstance.LogSpy);
            Logger.Log("[AdvancedLogger] Log Kill Command: " + ConfigurationInstance.LogKill);
            Logger.Log("[AdvancedLogger] Log Ban Command: " + ConfigurationInstance.LogBan);
            Logger.Log("[AdvancedLogger] Log Kick Command: " + ConfigurationInstance.LogKick);
            Logger.Log("[AdvancedLogger] Log Admin Command:" + ConfigurationInstance.LogAdmin);
            Logger.Log("[AdvancedLogger] Successfully Loaded! Thanks for downloading!");
        }
    }
    public class Config
    {
        public bool LogVanish = true;
        public bool LogGod = true;
        public bool LogI = true;
        public bool LogV = true;
        public bool LogBan = true;
        public bool LogKick = true;
        public bool LogTP = true;
        public bool LogSpy = true;
        public bool LogKill = true;
        public bool LogAdmin = true;
    }
    public class EventListener : IEventListener<PlayerChatEvent>
    {
        private Config config;

        public EventListener(Config config)
        {
            this.config = config;
        }

        [Rocket.Core.Eventing.EventHandler]
        public void HandleEvent(IEventEmitter emitter, PlayerChatEvent @event)
        {
            string message = @event.Message;
            if (@event.Message.StartsWith("/vanish") && config.LogVanish == true)
            {
                File.AppendAllText(System.IO.Directory.GetCurrentDirectory() + @"\Plugins\AdvancedLogger\CommandLog.txt", "[" + DateTime.Now + "] " + @event.Player.Name + " (" + @event.Player.Id + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if(@event.Message.StartsWith("/god") && config.LogGod == true)
            {
                File.AppendAllText(System.IO.Directory.GetCurrentDirectory() + @"\Plugins\AdvancedLogger\CommandLog.txt", "[" + DateTime.Now + "] " + @event.Player.Name + " (" + @event.Player.Id + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if(@event.Message.StartsWith("/v") && config.LogV == true)
            {
                File.AppendAllText(System.IO.Directory.GetCurrentDirectory() + @"\Plugins\AdvancedLogger\CommandLog.txt", "[" + DateTime.Now + "] " + @event.Player.Name + " (" + @event.Player.Id + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if(@event.Message.StartsWith("/vehicle") && config.LogV == true)
            {
                File.AppendAllText(System.IO.Directory.GetCurrentDirectory() + @"\Plugins\AdvancedLogger\CommandLog.txt", "[" + DateTime.Now + "] " + @event.Player.Name + " (" + @event.Player.Id + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (@event.Message.StartsWith("/ban") && config.LogBan == true)
            {
                File.AppendAllText(System.IO.Directory.GetCurrentDirectory() + @"\Plugins\AdvancedLogger\CommandLog.txt", "[" + DateTime.Now + "] " + @event.Player.Name + " (" + @event.Player.Id + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (@event.Message.StartsWith("/kick") && config.LogKick == true)
            {
                File.AppendAllText(System.IO.Directory.GetCurrentDirectory() + @"\Plugins\AdvancedLogger\CommandLog.txt", "[" + DateTime.Now + "] " + @event.Player.Name + " (" + @event.Player.Id + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (@event.Message.StartsWith("/i") && config.LogI == true)
            {
                File.AppendAllText(System.IO.Directory.GetCurrentDirectory() + @"\Plugins\AdvancedLogger\CommandLog.txt", "[" + DateTime.Now + "] " + @event.Player.Name + " (" + @event.Player.Id + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (@event.Message.StartsWith("/tp") && config.LogTP == true)
            {
                File.AppendAllText(System.IO.Directory.GetCurrentDirectory() + @"\Plugins\AdvancedLogger\CommandLog.txt", "[" + DateTime.Now + "] " + @event.Player.Name + " (" + @event.Player.Id + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (@event.Message.StartsWith("/teleport") && config.LogTP == true)
            {
                File.AppendAllText(System.IO.Directory.GetCurrentDirectory() + @"\Plugins\AdvancedLogger\CommandLog.txt", "[" + DateTime.Now + "] " + @event.Player.Name + " (" + @event.Player.Id + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (@event.Message.StartsWith("/tphere") && config.LogTP == true)
            {
                File.AppendAllText(System.IO.Directory.GetCurrentDirectory() + @"\Plugins\AdvancedLogger\CommandLog.txt", "[" + DateTime.Now + "] " + @event.Player.Name + " (" + @event.Player.Id + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (@event.Message.StartsWith("/spy") && config.LogSpy == true)
            {
                File.AppendAllText(System.IO.Directory.GetCurrentDirectory() + @"\Plugins\AdvancedLogger\CommandLog.txt", "[" + DateTime.Now + "] " + @event.Player.Name + " (" + @event.Player.Id + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            if (@event.Message.StartsWith("/admin") && config.LogAdmin == true)
            {
                File.AppendAllText(System.IO.Directory.GetCurrentDirectory() + @"\Plugins\AdvancedLogger\CommandLog.txt", "[" + DateTime.Now + "] " + @event.Player.Name + " (" + @event.Player.Id + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
            else
            {
                File.AppendAllText(System.IO.Directory.GetCurrentDirectory() + @"\Plugins\AdvancedLogger\ChatLog.txt", "[" + DateTime.Now + "] " + @event.Player.Name + " (" + @event.Player.Id + ")" + ": \"" + message + "\"" + System.Environment.NewLine);
            }
        }
    }
}
