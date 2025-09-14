using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Spawn;
using Exiled.CustomItems.API.Features;
using Exiled.CustomRoles.API.Features;
using PlayerRoles;

namespace MoreFacilityRoles.Roles;

public class GuardCaptin : CustomRole
{
    public override uint Id { get; set; } = 1003;
    public override int MaxHealth { get; set; } = 100;
    public override string Name { get; set; } =  "Guard Captin";
    public override string Description { get; set; } = "Guard Captin You have good Weapons and good card so you strong now XD";
    public override string CustomInfo { get; set; } =  "Guard Captin";
    public override List<string> Inventory { get; set; } = new()
    {
        $"{ItemType.KeycardMTFOperative}",
        $"{ItemType.ArmorCombat}",
        $"{ItemType.GunCrossvec}",
        $"{ItemType.GrenadeHE}",
        $"{ItemType.Radio}",
        $"{ItemType.Adrenaline}"
    };

    public override RoleTypeId Role { get; set; } = RoleTypeId.FacilityGuard;
    
    public override float SpawnChance { get; set; } = 100f;

    public override SpawnProperties? SpawnProperties { get; set; } = new()
    {
        Limit = 1,
        DynamicSpawnPoints = new List<DynamicSpawnPoint>
        {
            new()
            {
                Chance = 100,
                Location = SpawnLocationType.InsideGateB,
                
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
