using System;
using Exiled.API.Features;
using Exiled.CustomRoles.API;
using Exiled.CustomRoles.API.Features;
using MoreFacilityRoles.Roles;
using MoreFacilityRoles.Roles.Chaos;
using MoreFacilityRoles.Roles.MTF;
using MoreFacilityRoles.Roles.SCP049_2;

namespace MoreFacilityRoles
{
    public class Main : Plugin<Config>
    {
        public override string Name { get; } =  "MoreFacilityRoles";
        public override string Author { get; } = "VividZap";
        public override Version Version { get; } =  new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } =   new Version(9, 8, 1);
        public static Main Instance { get; set; }
        
        public override void OnEnabled()
        {
            new BigBoy().Register();
            new Medic().Register();
            new OwO().Register();
            new Rombo().Register();
            new Doctor().Register();
            new Crazy().Register();
            new Combo().Register();
            new DrX().Register();
            new GuardSupporter().Register();
            new Kid().Register();
            new GuardCaptin().Register();
            new Janitor().Register();
            Log.Debug("Plugin Loaded");
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Log.Debug("Plugin Disabled");
            base.OnDisabled();
        }
    }
}