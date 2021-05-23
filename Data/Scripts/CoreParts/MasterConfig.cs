namespace Scripts
{
    partial class Parts
    {
        internal Parts()
        {
            // file convention: Name.cs - See Example.cs file for PART property details.
            //
            // Enable your config files using the follow syntax, don't include the ".cs" extension:
            // PartFiles(Your1stConfigFile, Your2ndConfigFile, Your3rdConfigFile);
            PartFiles
            (
                //Coilguns
                MXA_CoilgunH, MXA_CoilgunL, MXA_CoilgunPD, MXA_Rampart2, MXA_BreakWater, MXA_BreakWaterB1, MXA_BreakWaterB2, MXA_BreakWaterB3,
                MXA_Sabre_Coilgun, MXA_SoFCoilgun,
                //MACs
                MXA_MACL, MXA_MACL_S, MXA_SMAC, MXA_M2MAC, MXA_M2MAC_S,
                //Missiles
                MXA_ArcherPods, MXA_M58ArcherPods, MXA_M58ArcherPods_S, MXA_Shiva,
                //Mines
                MXA_Moray
            );
            //ArmorFiles(Armor1, Armor2);
            //SupportFiles(ArmorEnhancer1A);
            //UpgradeFiles(Upgrade75a, Upgrade75b);
        }
    }
}
