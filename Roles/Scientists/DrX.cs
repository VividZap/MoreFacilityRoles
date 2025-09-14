using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Spawn;
using Exiled.CustomRoles.API.Features;
using PlayerRoles;

namespace MoreFacilityRoles.Roles;

public class DrX : CustomRole
{
    public override uint Id { get; set; } = 9600;
    public override int MaxHealth { get; set; }  = 120;
    public override string Name { get; set; } = "Dr-X";
    public override string Description { get; set; } = "We can see player like use SCP-1344 and we have good HP";
    public override string CustomInfo { get; set; } = "DrX";
    public override List<string> Inventory { get; set; } = new()
    {
        $"{ItemType.KeycardResearchCoordinator}",
        $"{ItemType.Flashlight}",
        $"{ItemType.Adrenaline}",
        $"{ItemType.Medkit}"
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
                Location = SpawnLocationType.Inside106Secondary,
                
            },
        },
    };

    public override void AddRole(Player player)
    {
        player.EnableEffect(EffectType.Scp1344);
        Log.Info($"Adding {Name}");
        base.AddRole(player);
    }
}