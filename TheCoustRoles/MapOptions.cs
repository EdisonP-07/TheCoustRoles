using System.Collections.Generic;
using UnityEngine;

namespace TheCoustRoles{
    static class TCRMapOptions {
        // Set values
        public static int maxNumberOfMeetings = 10;
        public static bool blockSkippingInEmergencyMeetings = false;
        public static bool noVoteIsSelfVote = false;
        public static bool hidePlayerNames = false;
        public static bool ghostsSeeRoles = true;
        public static bool ghostsSeeModifier = true;
        public static bool ghostsSeeInformation = true;
        public static bool ghostsSeeVotes = true;
        public static bool showRoleSummary = true;
        public static bool allowParallelMedBayScans = false;
        public static bool showLighterDarker = true;
        public static bool enableSoundEffects = true;
        public static bool enableHorseMode = false;
        public static bool shieldFirstKill = false;
        public static bool ShowVentsOnMap = true;
        public static bool ShowChatNotifications = true;
        public static CustomGamemodes gameMode = CustomGamemodes.Classic;

        // Updating values
        public static int meetingsCount = 0;
        public static List<SurvCamera> camerasToAdd = new List<SurvCamera>();
        public static List<Vent> ventsToSeal = new List<Vent>();
        public static Dictionary<byte, PoolablePlayer> playerIcons = new Dictionary<byte, PoolablePlayer>();
        public static string firstKillName;
        public static PlayerControl firstKillPlayer;

        public static void clearAndReloadMapOptions() {
            meetingsCount = 0;
            camerasToAdd = new List<SurvCamera>();
            ventsToSeal = new List<Vent>();
            playerIcons = new Dictionary<byte, PoolablePlayer>(); ;

            maxNumberOfMeetings = Mathf.RoundToInt(CustomOptionHolder.maxNumberOfMeetings.getSelection());
            blockSkippingInEmergencyMeetings = CustomOptionHolder.blockSkippingInEmergencyMeetings.getBool();
            noVoteIsSelfVote = CustomOptionHolder.noVoteIsSelfVote.getBool();
            hidePlayerNames = CustomOptionHolder.hidePlayerNames.getBool();
            allowParallelMedBayScans = CustomOptionHolder.allowParallelMedBayScans.getBool();
            shieldFirstKill = CustomOptionHolder.shieldFirstKill.getBool();
            firstKillPlayer = null;
        }

        public static void reloadPluginOptions() {
            ghostsSeeRoles = TheCoustRolesPlugin.GhostsSeeRoles.Value;
            ghostsSeeModifier = TheCoustRolesPlugin.GhostsSeeModifier.Value;
            ghostsSeeInformation = TheCoustRolesPlugin.GhostsSeeInformation.Value;
            ghostsSeeVotes = TheCoustRolesPlugin.GhostsSeeVotes.Value;
            showRoleSummary = TheCoustRolesPlugin.ShowRoleSummary.Value;
            showLighterDarker = TheCoustRolesPlugin.ShowLighterDarker.Value;
            enableSoundEffects = TheCoustRolesPlugin.EnableSoundEffects.Value;
            enableHorseMode = TheCoustRolesPlugin.EnableHorseMode.Value;
            ShowVentsOnMap = TheCoustRolesPlugin.ShowVentsOnMap.Value;
            ShowChatNotifications = TheCoustRolesPlugin.ShowChatNotifications.Value;

            //Patches.ShouldAlwaysHorseAround.isHorseMode = TheCoustRolesPlugin.EnableHorseMode.Value;
        }
    }
}
