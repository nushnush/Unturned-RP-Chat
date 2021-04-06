using Rocket.API;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System.Collections.Generic;
using UnityEngine;

namespace RPMessages
{
    public class TwtCommand : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;
        public string Name => "twt";
        public string Help => "Twitter message.";
        public string Syntax => "<>";
        public List<string> Aliases => new List<string>();
        public List<string> Permissions => new List<string>() { "perm.twt" };

        public void Execute(IRocketPlayer caller, string[] command)
        {
            UnturnedPlayer player = caller as UnturnedPlayer;
            string img = player.SteamProfile.AvatarIcon.ToString();
            ChatManager.serverSendMessage($"[Twitter] {player.CharacterName}: {command[0]}", Color.white, default, default, EChatMode.GLOBAL, img);
        }
    }
}
