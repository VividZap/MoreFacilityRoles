using System.Collections.Generic;
using Exiled.API.Features;
using Exiled.CustomRoles.API.Features;
using PlayerRoles;

namespace MoreFacilityRoles.Roles.Chaos;

public class Rombo : CustomRole
{
    public override uint Id { get; set; } = 52524;
    public override int MaxHealth { get; set; } = 115;
    public override string Name { get; set; } = "Rombo";
    public override string Description { get; set; } = "Like Real rombo we have havy weapons and bombs";
    public override string CustomInfo { get; set; } = "Rombo";
    public override RoleTypeId Role { get; set; } = RoleTypeId.ChaosMarauder;
    public override float SpawnChance { get; set; } = 100f;
    public override List<string> Inventory { get; set; } = new()
    {
        $"{ItemType.GunLogicer}",
        $"{ItemType.ArmorHeavy}",
        $"{ItemType.GrenadeHE,2}",
        $"{ItemType.SCP500}",
        $"{ItemType.KeycardFacilityManager}"
    };

    public override void AddRole(Player player)
    {
        player.Health = MaxHealth;
        Log.Info($"Adding {Name}");
        base.AddRole(player);
    }

    protected override void SubscribeEvents()
    {
        Log.Debug("SubscribeEvents");
        base.SubscribeEvents();
    }

    protected override void UnsubscribeEvents()
    {
        Log.Debug("UnsubscribeEvents");
        base.UnsubscribeEvents();
    }
}
