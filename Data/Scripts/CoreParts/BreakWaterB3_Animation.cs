using System.Collections.Generic;
using static Scripts.Structure.WeaponDefinition;
using static Scripts.Structure.WeaponDefinition.AnimationDef;
using static Scripts.Structure.WeaponDefinition.AnimationDef.PartAnimationSetDef.EventTriggers;
using static Scripts.Structure.WeaponDefinition.AnimationDef.RelMove.MoveType;
using static Scripts.Structure.WeaponDefinition.AnimationDef.RelMove;

namespace Scripts
{ // Don't edit above this line
    partial class Parts
    {
        /// Possible Events ///

        //Reloading,
        //Firing,
        //Tracking,
        //Overheated,
        //TurnOn,
        //TurnOff,
        //BurstReload,
        //OutOfAmmo,
        //PreFire,
        //EmptyOnGameLoad,
        //StopFiring,
        //StopTracking

        private AnimationDef MXA_BreakWaterB3_Animation => new AnimationDef
        {
            AnimationSets = new[]
            {
                new PartAnimationSetDef()
                {
                    SubpartId = Names("Recoil3"),
                    BarrelId = "muzzle_projectile_3", //only used for firing, use "Any" for all muzzles
                    StartupFireDelay = 0,
                    AnimationDelays = Delays(firingDelay : 0, reloadingDelay: 0, overheatedDelay: 0, trackingDelay: 0, lockedDelay: 0, onDelay: 0, offDelay: 0, burstReloadDelay: 0, outOfAmmoDelay: 0, preFireDelay: 0),//Delay before animation starts
                    Reverse = Events(),
                    TriggerOnce = Events(),
                    Loop = Events(),
                    ResetEmissives = Events(),
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {



                        [Firing] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {
                                new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 30, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = ExpoDecay, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                     EmissiveName = "TurnOn",//name of defined emissive
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, 1), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },

                                new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 10, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Linear, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                     EmissiveName = "TurnOn",//name of defined emissive
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0, -1), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                            },

                    }
                },
            }

        };
    }
}
