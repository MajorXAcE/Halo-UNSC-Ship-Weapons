using static Scripts.Structure;
using static Scripts.Structure.WeaponDefinition;
using static Scripts.Structure.WeaponDefinition.ModelAssignmentsDef;
using static Scripts.Structure.WeaponDefinition.HardPointDef;
using static Scripts.Structure.WeaponDefinition.HardPointDef.Prediction;
using static Scripts.Structure.WeaponDefinition.TargetingDef.BlockTypes;
using static Scripts.Structure.WeaponDefinition.TargetingDef.Threat;
using static Scripts.Structure.WeaponDefinition.HardPointDef.HardwareDef.HardwareType;
namespace Scripts {   
    partial class Parts {  // If you don't understand this file, Visit the discord.
        // Don't edit above this line
        WeaponDefinition MXA_M58ArcherPods => new WeaponDefinition // Weapon Class ID Goes Here.
        {

            Assignments = new ModelAssignmentsDef
            {
                MountPoints = new[] {
                    new MountPointDef {
                        SubtypeId = "MXA_M58ArcherPods",
                        SpinPartId = "None",
                        MuzzlePartId = "None",
                        AzimuthPartId = "None",
                        ElevationPartId = "None",
                        DurabilityMod = 0.5f,
                        IconName = ""
                    },
                  },
                 Muzzles = new [] {
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
                Threats = new[] { // Targeting List; Valid are Grids, Projectiles, Characters, Meteors, 
                    Grids,
                },
                SubSystems = new[] { // Subsystem Basic priority system, leave only "any" to disable. Decoys are in Utility.
                    Thrust, Utility, Offense, Power, Production, Any,
                },
                ClosestFirst = false, // tries to pick closest targets first (blocks on grids, projectiles, etc...).
                IgnoreDumbProjectiles = false, // Don't fire at non-smart projectiles.
                LockedSmartOnly = false, // Only fire at smart projectiles that are locked on to parent grid.
                MinimumDiameter = 1, // 0 = unlimited, Minimum radius of threat to engage.
                MaximumDiameter = 0, // 0 = unlimited, Maximum radius of threat to engage.
                MaxTargetDistance =10000, // 0 = unlimited, Maximum target distance that targets will be automatically shot at.
                MinTargetDistance = 0, // 0 = unlimited, Min target distance that targets will be automatically shot at.
                TopTargets = 0, // 0 = unlimited, max number of top targets to randomize between.
                TopBlocks = 0, // 0 = unlimited, max number of blocks to randomize between
                StopTrackingSpeed = 1000, // do not track target threats traveling faster than this speed
            },
            HardPoint = new HardPointDef
            {
                PartName = "M58 Archer Missile Pods", // name of weapon in terminal , Accepts Spaces , Avoid Special Characters if possible.
                DeviateShotAngle = 1f, // Measured in Degrees, for highest degree of inaccuracy applied to weaponsfire
                AimingTolerance = 0, // 0 - 180 firing angle , How off-Target the Weapon can fire, if AI Controlled.
                AimLeadingPrediction = Off, // Off, Basic, Accurate, Advanced -- Targeting Effectiveness, higher levels improves Turret Intelligence in leading their shots.
                DelayCeaseFire = 0, // Measured in game ticks (6 = 100ms, 60 = 1 seconds, etc..). , How long after you or the Turret stops holding the fire trigger, that the weapon keeps on firing.
                AddToleranceToTracking = false,
                CanShootSubmerged = false,

                Ui = new UiDef // User Terminal Menu Options.
                {
                    RateOfFire = false, // True, if Users can lower RPM in-Game.
                    DamageModifier = false,
                    ToggleGuidance = true,
                    EnableOverload = false,
                },
                Ai = new AiDef
                { // Turret Systems. All but LockOnFocus is used by Turrets. If not Turret, set to False , outside of Specific Usage.
                    TrackTargets = false,
                    TurretAttached = false,
                    TurretController = false,
                    PrimaryTracking = true,
                    LockOnFocus = false, // System targets your Grid's locked-on target, Used  by both Turrets & other weapons.
                    SuppressFire = false, // Disables automatic fire of Turrets, useful for Gimbals.
                },
                HardWare = new HardwareDef {
                    RotateRate = 0f,
                    ElevateRate = 0f,
                    MinAzimuth = 0,
                    MaxAzimuth = 0,
                    MinElevation = 0,
                    MaxElevation = 0,
                    FixedOffset = false,
                    InventorySize = 1.25f, // Your inventory size modifier.
                    Offset = Vector(x: 0, y: 0, z: 0), // Offset to aim focus.
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
                    Debug = false, //  Used for Debugging Turrets, Please leave on False for Live Mods, this generates extra data & visual lines on all Weapons set to True.
                    RestrictionRadius = 0, // Meters, radius of sphere, will disable this gun if another is present inside this listed radius.
                    CheckInflatedBox = false, // if true, the bounding box of the gun is expanded by the RestrictionRadius
                    CheckForAnyWeapon = false, // if true, the check will fail if ANY gun is present, false only looks for this subtype
                },
                Loading = new LoadingDef
                {
                    RateOfFire = 480, // RPM of Weapon. Used by Barrel Spin, if used.
                    BarrelsPerShot = 1, //  Number of Barrels fired per Trigger Pull.
                    TrajectilesPerBarrel = 1, // Number of Trajectiles per barrel per fire event.
                    SkipBarrels = 0, // If Skips set number of barrels per, this is not Barrel specific.
                    ReloadTime = 1200, // Measured in game ticks (6 = 100ms, 60 = 1 seconds, etc..).
                    DelayUntilFire = 0, // Measured in game ticks (6 = 100ms, 60 = 1 seconds, etc..).
                    HeatPerShot = 0, //heat generated per shot
                    MaxHeat = 0, //max heat before weapon enters cooldown (70% of max heat)
                    Cooldown = 0f, //percent of max heat to be under to start firing again after overheat accepts .2-.95
                    HeatSinkRate = 0, //amount of heat lost per second
                    DegradeRof = false, // progressively lower rate of fire after 80% heat threshold (80% of max heat)
                    ShotsInBurst = 10, // Shots before Burst Delay is triggered - BarrelsPerShot Values above 1 still only cost 1 shot from BurstCount. Independent from Magazine Size.
                    DelayAfterBurst = 480, // Measured in game ticks (6 = 100ms, 60 = 1 seconds, etc..).
                    FireFullBurst = false, // If Weapon is forced to fire the entire Burst count.
                    GiveUpAfterBurst = false, //  If Turret disengages Target after firing full Burst.
                    BarrelSpinRate = 0, // visual only, 0 disables and uses RateOfFire. Use to set a fixed rate of spin, indepdendent of ROF, to allow more flexible RPM without losing visual.
                    DeterministicSpin = false, // Spin barrel position will always be relative to initial / starting positions (spin will not be as smooth).
                    SpinFree = true, // Spin while not firing
                    StayCharged = false, // Will start recharging whenever power cap is not full
                },
                Audio = new HardPointAudioDef
                {
                    PreFiringSound = "", // Sound used while Charging.
                    FiringSound = "MXA_Archer_Fire", // WepShipGatlingShot is example. Audio triggered per Shot.
                    FiringSoundPerShot = true, //  if False, use Looping Audio, suggested for Beam Weapons.
                    ReloadSound = "", //  Triggered when Reloading
                    NoAmmoSound = "", // Triggered when unable to reload.
                    HardPointRotationSound = "WepTurretGatlingRotate", // Used when Turret Rotates
                    BarrelRotationSound = "WepShipGatlingRotation", // Sound used by Natural Barrel Rotation Trigger
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
                            Scale = .75f, // This is a setting that works slightly. Please use SBC, for the rest, and more ensured results.
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
                            MaxDistance = 150,
                            MaxDuration = 0,
                            Scale = 1f,
                        },
                    },
                },
            },
            Ammos = new [] {
                MXA_M58ArcherPods_Ammo,
				MXA_M58ArcherPods_AccelStage,
				MXA_M58ArcherPods_Stage,
				MXA_M58ArcherPods_Shrapnel,
            },
            Animations = MXA_M58ArcherPods_Animation,
            //Upgrades = UpgradeModules,
            // Don't edit below this line
        };
    }
}