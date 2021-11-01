namespace Scripts
{
    partial class Parts
    {
        internal Parts()
        {
            // naming convention: WeaponDefinition Name
            //
            // Enable your definitions using the follow syntax:
            // PartDefinitions(Your1stDefinition, Your2ndDefinition, Your3rdDefinition);
            // PartDefinitions includes both weapons and phantoms
            PartDefinitions
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
            //ArmorDefinitions(Armor1, Armor2);
            //SupportDefinitions(ArmorEnhancer1A);
            //UpgradeDefinitions(Upgrade75a, Upgrade75b);
        }
    }
}
