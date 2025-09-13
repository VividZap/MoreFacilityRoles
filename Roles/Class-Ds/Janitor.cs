using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Spawn;
using Exiled.CustomRoles.API.Features;
using JetBrains.Annotations;
using PlayerRoles;

namespace MoreFacilityRoles.Roles
{
    public class Janitor : CustomRole
    {
        public override uint Id { get; set; } = 200;
        public override int MaxHealth { get; set; } = 100;
        public override string Name { get; set; } = "Janitor";
        public override string Description { get; set; } = "Janitor For Facility We have your card and simple tools";
        public override string CustomInfo { get; set; } = "Janitor Man";

        public override List<string> Inventory { get; set; } = new()
        {
            $"{ItemType.KeycardJanitor}",
            $"{ItemType.Flashlight}",
            $"{ItemType.Coin}"
        };

        public override RoleTypeId Role { get; set; } = RoleTypeId.ClassD;
        public override float SpawnChance { get; set; } = 100f;

        public override SpawnProperties? SpawnProperties { get; set; } = new()
        {
            Limit = 1,
            DynamicSpawnPoints = new List<DynamicSpawnPoint>
            {
                new()
                {
                    Chance = 100,
                    Location = SpawnLocationType.InsideLczCafe,
                
                },
            },
        };

        protected override void SubscribeEvents()
        {
            Log.Debug("Subscribed to events");
            base.SubscribeEvents();
        }

        protected override void UnsubscribeEvents()
        {
            Log.Debug("Unsubscribed to events");
            base.UnsubscribeEvents();
        }
    }
}