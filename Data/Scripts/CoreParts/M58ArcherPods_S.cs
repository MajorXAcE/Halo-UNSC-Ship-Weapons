using static Scripts.Structure;
using static Scripts.Structure.WeaponDefinition;
using static Scripts.Structure.WeaponDefinition.ModelAssignmentsDef;
using static Scripts.Structure.WeaponDefinition.HardPointDef;
using static Scripts.Structure.WeaponDefinition.HardPointDef.Prediction;
using static Scripts.Structure.WeaponDefinition.TargetingDef.BlockTypes;
using static Scripts.Structure.WeaponDefinition.TargetingDef.Threat;
using static Scripts.Structure.WeaponDefinition.HardPointDef.HardwareDef.HardwareType;
namespace Scripts
{
    partial class Parts
    {  // If you don't understand this file, Visit the discord.
        // Don't edit above this line
        WeaponDefinition MXA_M58ArcherPods_S => new WeaponDefinition
        {

            Assignments = new ModelAssignmentsDef
            {
                MountPoints = new[] {
                    new MountPointDef {
                        SubtypeId = "MXA_M58ArcherPods_S",
                        SpinPartId = "None",
                        MuzzlePartId = "None",
                        AzimuthPartId = "None",
                        ElevationPartId = "None",
                        DurabilityMod = 0.5f,
                        IconName = ""
                    },
                  },
                Muzzles = new[] {
                    "subpart_ArcherPod1_Missile_1", "subpart_ArcherPod2_Missile_1", "subpart_ArcherPod3_Missile_1", "subpart_ArcherPod4_Missile_1", "subpart_ArcherPod5_Missile_1",
                    "subpart_ArcherPod1_Missile_2", "subpart_ArcherPod2_Missile_2", "subpart_ArcherPod3_Missile_2", "subpart_ArcherPod4_Missile_2", "subpart_ArcherPod5_Missile_2",
                    "subpart_ArcherPod1_Missile_3", "subpart_ArcherPod2_Missile_3", "subpart_ArcherPod3_Missile_3", "subpart_ArcherPod4_Missile_3", "subpart_ArcherPod5_Missile_3",
                    "subpart_ArcherPod1_Missile_4", "subpart_ArcherPod2_Missile_4", "subpart_ArcherPod3_Missile_4", "subpart_ArcherPod4_Missile_4", "subpart_ArcherPod5_Missile_4",
                    "subpart_ArcherPod1_Missile_5", "subpart_ArcherPod2_Missile_5", "subpart_ArcherPod3_Missile_5", "subpart_ArcherPod4_Missile_5", "subpart_ArcherPod5_Missile_5",
                    "subpart_ArcherPod1_Missile_6", "subpart_ArcherPod2_Missile_6", "subpart_ArcherPod3_Missile_6", "subpart_ArcherPod4_Missile_6", "subpart_ArcherPod5_Missile_6",
                    "subpart_ArcherPod1_Missile_7", "subpart_ArcherPod2_Missile_7", "subpart_ArcherPod3_Missile_7", "subpart_ArcherPod4_Missile_7", "subpart_ArcherPod5_Missile_7",
                    "subpart_ArcherPod1_Missile_8", "subpart_ArcherPod2_Missile_8", "subpart_ArcherPod3_Missile_8", "subpart_ArcherPod4_Missile_8", "subpart_ArcherPod5_Missile_8",
                    "subpart_ArcherPod1_Missile_9", "subpart_ArcherPod2_Missile_9", "subpart_ArcherPod3_Missile_9", "subpart_ArcherPod4_Missile_9", "subpart_ArcherPod5_Missile_9",
                    "subpart_ArcherPod1_Missile_10", "subpart_ArcherPod2_Missile_10", "subpart_ArcherPod3_Missile_10", "subpart_ArcherPod4_Missile_10", "subpart_ArcherPod5_Missile_10",
                    "subpart_ArcherPod1_Missile_11", "subpart_ArcherPod2_Missile_11", "subpart_ArcherPod3_Missile_11", "subpart_ArcherPod4_Missile_11", "subpart_ArcherPod5_Missile_11",
                    "subpart_ArcherPod1_Missile_12", "subpart_ArcherPod2_Missile_12", "subpart_ArcherPod3_Missile_12", "subpart_ArcherPod4_Missile_12", "subpart_ArcherPod5_Missile_12",
                    "subpart_ArcherPod1_Missile_13", "subpart_ArcherPod2_Missile_13", "subpart_ArcherPod3_Missile_13", "subpart_ArcherPod4_Missile_13", "subpart_ArcherPod5_Missile_13",
                    "subpart_ArcherPod1_Missile_14", "subpart_ArcherPod2_Missile_14", "subpart_ArcherPod3_Missile_14", "subpart_ArcherPod4_Missile_14", "subpart_ArcherPod5_Missile_14",
                    "subpart_ArcherPod1_Missile_15", "subpart_ArcherPod2_Missile_15", "subpart_ArcherPod3_Missile_15", "subpart_ArcherPod4_Missile_15", "subpart_ArcherPod5_Missile_15",
                    "subpart_ArcherPod1_Missile_16", "subpart_ArcherPod2_Missile_16", "subpart_ArcherPod3_Missile_16", "subpart_ArcherPod4_Missile_16", "subpart_ArcherPod5_Missile_16",
                    "subpart_ArcherPod1_Missile_17", "subpart_ArcherPod2_Missile_17", "subpart_ArcherPod3_Missile_17", "subpart_ArcherPod4_Missile_17", "subpart_ArcherPod5_Missile_17",
                    "subpart_ArcherPod1_Missile_18", "subpart_ArcherPod2_Missile_18", "subpart_ArcherPod3_Missile_18", "subpart_ArcherPod4_Missile_18", "subpart_ArcherPod5_Missile_18",
                    "subpart_ArcherPod1_Missile_19", "subpart_ArcherPod2_Missile_19", "subpart_ArcherPod3_Missile_19", "subpart_ArcherPod4_Missile_19", "subpart_ArcherPod5_Missile_19",
                    "subpart_ArcherPod1_Missile_20", "subpart_ArcherPod2_Missile_20", "subpart_ArcherPod3_Missile_20", "subpart_ArcherPod4_Missile_20", "subpart_ArcherPod5_Missile_20",
                    "subpart_ArcherPod1_Missile_21", "subpart_ArcherPod2_Missile_21", "subpart_ArcherPod3_Missile_21", "subpart_ArcherPod4_Missile_21", "subpart_ArcherPod5_Missile_21",
                    "subpart_ArcherPod1_Missile_22", "subpart_ArcherPod2_Missile_22", "subpart_ArcherPod3_Missile_22", "subpart_ArcherPod4_Missile_22", "subpart_ArcherPod5_Missile_22",
                    "subpart_ArcherPod1_Missile_23", "subpart_ArcherPod2_Missile_23", "subpart_ArcherPod3_Missile_23", "subpart_ArcherPod4_Missile_23", "subpart_ArcherPod5_Missile_23",
                    "subpart_ArcherPod1_Missile_24", "subpart_ArcherPod2_Missile_24", "subpart_ArcherPod3_Missile_24", "subpart_ArcherPod4_Missile_24", "subpart_ArcherPod5_Missile_24",
                    "subpart_ArcherPod1_Missile_25", "subpart_ArcherPod2_Missile_25", "subpart_ArcherPod3_Missile_25", "subpart_ArcherPod4_Missile_25", "subpart_ArcherPod5_Missile_25",
                    "subpart_ArcherPod1_Missile_26", "subpart_ArcherPod2_Missile_26", "subpart_ArcherPod3_Missile_26", "subpart_ArcherPod4_Missile_26", "subpart_ArcherPod5_Missile_26",
                    "subpart_ArcherPod1_Missile_27", "subpart_ArcherPod2_Missile_27", "subpart_ArcherPod3_Missile_27", "subpart_ArcherPod4_Missile_27", "subpart_ArcherPod5_Missile_27",
                    "subpart_ArcherPod1_Missile_28", "subpart_ArcherPod2_Missile_28", "subpart_ArcherPod3_Missile_28", "subpart_ArcherPod4_Missile_28", "subpart_ArcherPod5_Missile_28",
                    "subpart_ArcherPod1_Missile_29", "subpart_ArcherPod2_Missile_29", "subpart_ArcherPod3_Missile_29", "subpart_ArcherPod4_Missile_29", "subpart_ArcherPod5_Missile_29",
                    "subpart_ArcherPod1_Missile_30", "subpart_ArcherPod2_Missile_30", "subpart_ArcherPod3_Missile_30", "subpart_ArcherPod4_Missile_30", "subpart_ArcherPod5_Missile_30",
                },
                Ejector = "", // Used for Advanced Functionality, of ejecting empty shells & particles, on firing.
                Scope = "", //Where line of sight checks are performed from must be clear of block collision
            },
            Targeting = new TargetingDef
            {
                Threats = new[] {
                    Grids,
                },
                SubSystems = new[] {
                    Thrust, Utility, Offense, Power, Production, Any,
                },
                ClosestFirst = false, // tries to pick closest targets first (blocks on grids, projectiles, etc...).
                IgnoreDumbProjectiles = false, // Don't fire at non-smart projectiles.
                LockedSmartOnly = false, // Only fire at smart projectiles that are locked on to parent grid.
                MinimumDiameter = 1, // 0 = unlimited, Minimum radius of threat to engage.
                MaximumDiameter = 0, // 0 = unlimited, Maximum radius of threat to engage.
                MaxTargetDistance = 7500, // 0 = unlimited, Maximum target distance that targets will be automatically shot at.
                MinTargetDistance = 0, // 0 = unlimited, Min target distance that targets will be automatically shot at.
                TopTargets = 6, // 0 = unlimited, max number of top targets to randomize between.
                TopBlocks = 20, // 0 = unlimited, max number of blocks to randomize between
                StopTrackingSpeed = 1000, // do not track target threats traveling faster than this speed
            },
            HardPoint = new HardPointDef
            {
                PartName = "M58 Archer Missile Pods", // name of weapon in terminal
                DeviateShotAngle = 0f,
                AimingTolerance = 0f, // 0 - 180 firing angle
                AimLeadingPrediction = Accurate, // Off, Basic, Accurate, Advanced
                DelayCeaseFire = 0, // Measured in game ticks (6 = 100ms, 60 = 1 seconds, etc..).
                AddToleranceToTracking = true,
                CanShootSubmerged = false,

                Ui = new UiDef
                {
                    RateOfFire = false,
                    DamageModifier = false,
                    ToggleGuidance = true,
                    EnableOverload = false,
                },
                Ai = new AiDef
                {
                    TrackTargets = false,
                    TurretAttached = false,
                    TurretController = false,
                    PrimaryTracking = false,
                    LockOnFocus = false,
                    SuppressFire = false,
                    OverrideLeads = false, // Override default behavior for target leads // System targets your Grid's locked-on target, Used  by both Turrets & other weapons.
                },
                HardWare = new HardwareDef
                {
                    RotateRate = 0f,
                    ElevateRate = 0f,
                    MinAzimuth = 0,
                    MaxAzimuth = 0,
                    MinElevation = 0,
                    MaxElevation = 0,
                    FixedOffset = false,
                    InventorySize = 1.25f,
                    Offset = Vector(x: 0, y: 0, z: 0),
                    Type = BlockWeapon, // Upgrade, BlockWeapon, ActiveArmor, PassiveArmor, RegenArmor, Phantom .  What your Block is configured to be.
                                        //  Upgrade, means this Block ignores non-Upgrade Config Settings, etc etc.
                                        // BlockWeapon , means this is a gun.
                                        // ActiveArmor , means this is an Armor system unit.
                                        // RegenArmor , means this is an Armor system unit.
                                        // PassiveArmor , means this is an Armor system unit.
                                        // Phantom , means this is Error-Data-Missing.
                },
                Other = new OtherDef
                {
                    ConstructPartCap = 0, // Cap per Grid, of this Block. 
                    RotateBarrelAxis = 0, // Axis ( X, Y, Z) of Barrel Spin
                    EnergyPriority = 0, // Energy Priority, over other subsystems on grid, should Power be limited.
                    MuzzleCheck = false,
                    Debug = false,
                    RestrictionRadius = 0, // Meters, radius of sphere disable this gun if another is present
                    CheckInflatedBox = false, // if true, the bounding box of the gun is expanded by the RestrictionRadius
                    CheckForAnyWeapon = false, // if true, the check will fail if ANY gun is present, false only looks for this subtype
                },
                Loading = new LoadingDef
                {
                    RateOfFire = 480, // visual only, 0 disables and uses RateOfFire
                    BarrelsPerShot = 1,
                    TrajectilesPerBarrel = 1, // Number of Trajectiles per barrel per fire event.
                    SkipBarrels = 0,
                    ReloadTime = 1200, //3600 // Measured in game ticks (6 = 100ms, 60 = 1 seconds, etc..).
                    DelayUntilFire = 0, // Measured in game ticks (6 = 100ms, 60 = 1 seconds, etc..).
                    HeatPerShot = 0, //heat generated per shot
                    MaxHeat = 0, //max heat before weapon enters cooldown (70% of max heat)
                    Cooldown = 0, //percent of max heat to be under to start firing again after overheat accepts .2-.95
                    HeatSinkRate = 0, //amount of heat lost per second
                    DegradeRof = false, // progressively lower rate of fire after 80% heat threshold (80% of max heat)
                    ShotsInBurst = 10,
                    DelayAfterBurst = 480, // Measured in game ticks (6 = 100ms, 60 = 1 seconds, etc..).
                    FireFullBurst = false,
                    GiveUpAfterBurst = false,
                    BarrelSpinRate = 0, // visual only, 0 disables and uses RateOfFire
                    DeterministicSpin = false, // Spin barrel position will always be relative to initial / starting positions (spin will not be as smooth).
                    SpinFree = false, // Spin while not firing
                    StayCharged = false, // Will start recharging whenever power cap is not full
                },
                Audio = new HardPointAudioDef
                {
                    PreFiringSound = "",
                    FiringSound = "MXA_Archer_Fire", // WepShipGatlingShot
                    FiringSoundPerShot = true,
                    ReloadSound = "WepTurretGatlingRotate",
                    NoAmmoSound = "",
                    HardPointRotationSound = "", //WepTurretGatlingRotate
                    BarrelRotationSound = "", //WepShipGatlingRotation
                    FireSoundEndDelay = 0, // Measured in game ticks(6 = 100ms, 60 = 1 seconds, etc..).
                },
                Graphics = new HardPointParticleDef
                {

                    Effect1 = new ParticleDef
                    {
                        Name = "", // Smoke_LargeGunShot Example, Particle SubtypeID from particle SBCs, go here.
                        Color = Color(red: .05f, green: .05f, blue: .05f, alpha: 1),
                        Offset = Vector(x: 0, y: 0, z: 0),

                        Extras = new ParticleOptionDef
                        {
                            Restart = false,
                            MaxDistance = 300,
                            MaxDuration = 0,
                            Scale = .75f,
                        },
                    },
                    Effect2 = new ParticleDef
                    {
                        Name = "",//Muzzle_Flash_Large
                        Color = Color(red: 20, green: 20, blue: 20, alpha: 1),
                        Offset = Vector(x: 0, y: 0, z: 0),

                        Extras = new ParticleOptionDef
                        {
                            Restart = false,
                            MaxDistance = 300,
                            MaxDuration = 0,
                            Scale = 10f,
                        },
                    },
                },
            },
            Ammos = new[] {
                //Explosive
                MXA_M58ArcherPods_S_Ammo,
                MXA_M58ArcherPods_S_AccelStage,
                MXA_M58ArcherPods_S_Stage,
                MXA_M58ArcherPods_S_Shrapnel,
                //Kinetic
                MXA_M58ArcherPods_S_KineticAmmo,
                MXA_M58ArcherPods_S_KineticAccelStage,
                MXA_M58ArcherPods_S_KineticStage,
                MXA_M58ArcherPods_S_KineticShrapnel,
            },
            Animations = MXA_M58ArcherPods_S_Animation,
            //Upgrades = UpgradeModules,
            // Don't edit below this line
        };
    }
}