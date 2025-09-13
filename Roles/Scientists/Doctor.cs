using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Spawn;
using Exiled.CustomRoles.API.Features;
using PlayerRoles;

namespace MoreFacilityRoles.Roles;

public class Doctor : CustomRole
{
    public override uint Id { get; set; } = 1002;
    public override int MaxHealth { get; set; } = 110;
    public override string Name { get; set; } = "Doctor";
    public override string Description { get; set; } =  "Doctor You have lot Medical Items and good Health";
    public override string CustomInfo { get; set; } = "Doctor";
    public override List<string> Inventory { get; set; } = new()
    {
        $"{ItemType.KeycardContainmentEngineer}",
        $"{ItemType.Flashlight}",
        $"{ItemType.Adrenaline}",
        $"{ItemType.SCP500,2}"
    };

    public override RoleTypeId Role { get; set; } = RoleTypeId.Scientist;
    public override float SpawnChance { get; set; } = 100f;

    public override SpawnProperties? SpawnProperties { get; set; } = new()
    {
        Limit = 1,
        DynamicSpawnPoints = new List<DynamicSpawnPoint>
        {
            new()
            {
                Chance = 100,
                Location = SpawnLocationType.Inside330,
                
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

