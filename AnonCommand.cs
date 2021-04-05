using Rocket.API;
using SDG.Unturned;
using System.Collections.Generic;
using UnityEngine;

namespace RPMessages
{
    public class AnonCommand : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;
        public string Name => "anontwt";
        public string Help => "Anonymous message.";
        public string Syntax => "<>";
        public List<string> Aliases => new List<string>();
        public List<string> Permissions => new List<string>() { "perm.anontwt" };

        public void Execute(IRocketPlayer caller, string[] command)
        {
            ChatManager.serverSendMessage($"Anonymous: {command[0]}", Color.white, default, default, EChatMode.GLOBAL);
        }
    }
}
