using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.CustomRoles.API.Features;
using PlayerRoles;

namespace MoreFacilityRoles.Roles.Chaos;

public class Crazy : CustomRole
{
    public override uint Id { get; set; } = 14585;
    public override int MaxHealth { get; set; } = 120;
    public override string Name { get; set; } =  "Crazy";
    public override string Description { get; set; } = "you have bad weapons but 120 hp and 20Ahp";
    public override string CustomInfo { get; set; } = "Crazy";
    public override RoleTypeId Role { get; set; } =  RoleTypeId.ChaosConscript;
    public override float SpawnChance { get; set; } = 100f;
    public override void AddRole(Player player)
    {
        player.Health = MaxHealth;
        Log.Debug("Role Added");
        base.AddRole(player);
    }

    public override Dictionary<AmmoType, ushort> Ammo { get; set; } = new()
    {
        { AmmoType.Nato556, 100 },
    };

    public override List<string> Inventory { get; set; } = new()
    {
        $"{ItemType.KeycardMTFPrivate}",
        $"{ItemType.Jailbird}",
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