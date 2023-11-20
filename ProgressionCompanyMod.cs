using BepInEx;
using HarmonyLib;
using System;
using static UnityEngine.UIElements.GenericDropdownMenu;
using UnityEngine.UIElements;
using ShadowUtilityLIB.logging;

namespace LCPC
{
    sealed public class ModInfo
    {
        public const string ModID = "com.shadowdev.lcpc";
        public const string ModName = "progressioncompany";
        public const string ModVersion = "0.0.1";
    }
    [BepInPlugin(ModInfo.ModID, ModInfo.ModName, ModInfo.ModVersion)]
    public class ProgressionCompanyMod : BaseUnityPlugin
    {
        void Awake()
        {
            Awake();
        }
    }
    public static class ProgressionCompany
    {
        private static Logger logger = new Logger(ModInfo.ModID, ModInfo.ModVersion);
        public static void Awake()
        {
            logger.Log("Starting");
            Harmony.CreateAndPatchAll(typeof(ProgressionCompanyPatchers));
            logger.Log("Patched");
            logger.Log("finished init");
        }
        public static void SetupGame()
        {
            logger.Log("Starting game setup");
        }
    }
    public static class ProgressionCompanyPatchers
    {
        [HarmonyPatch(typeof(MenuManager))]
        [HarmonyPatch("ConfirmHostButton")]
        [HarmonyPostfix]
        public static void MenuManager_ConfirmHostButton()
        {
            ProgressionCompany.SetupGame();
        }
    }
}
