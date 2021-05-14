namespace WeaponThread
{
    partial class Weapons
    {
        internal Weapons()
        {
            // Filename convention:
            // Name.cs - See Gatling.cs file for weapon property details.
            //
            // Enable your config files using the following syntax, don't include the ".cs" extension:
            // ConfigFiles(Your1stConfigFile, Your2ndConfigFile, Your3rdConfigFile);

            ConfigFiles
            (
                //Coilguns
                MXA_CoilgunH, MXA_CoilgunL, MXA_CoilgunPD, MXA_Rampart2, MXA_BreakWater, MXA_BreakWaterB2, MXA_BreakWaterB3,
                MXA_Sabre_Coilgun, MXA_SoFCoilgun,
                //MACs
                MXA_MACL, MXA_MACL_S, MXA_SMAC, MXA_M2MAC, MXA_M2MAC_S,
                //Missiles
                MXA_ArcherPods, MXA_M58ArcherPods, MXA_M58ArcherPods_S, MXA_Shiva,
                //Mines
                MXA_Moray
            );

            // To register block subtypes as armor you can use these functions below
            // LightArmorSubtypes("LightArmorSubtypeIdB", "LightArmorSubtypeIdB");
            // HeavyArmorSubtypes("HeavyArmorSubtypeIdA", "HeavyArmorSubtypeIdB");
        }
    }
}