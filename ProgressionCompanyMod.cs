using BepInEx;
using System;

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

    }
}
