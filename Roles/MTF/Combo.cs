using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.CustomRoles.API.Features;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;

namespace MoreFacilityRoles.Roles.MTF;

public class Combo : CustomRole
{
    public override uint Id { get; set; } = 1545;
    public override int MaxHealth { get; set; } = 110;
    public override string Name { get; set; } = "Combo-Solder";
    public override string Description { get; set; } = "Ntf solder we have a 110hp and so cool weapons";
    public override string CustomInfo { get; set; } = "Combo";
    public override RoleTypeId Role { get; set; } = RoleTypeId.NtfSergeant;
    public override float SpawnChance { get; set; } = 100f;

    public override Dictionary<AmmoType, ushort> Ammo { get; set; } = new()
    {
        { AmmoType.Nato556, 100 },
        { AmmoType.Nato762, 100 },
        { AmmoType.Ammo12Gauge, 100 },
    };

    public override List<string> Inventory { get; set; } = new()
    {
        $"{ItemType.KeycardMTFOperative}",
        $"{ItemType.ArmorCombat}",
        $"{ItemType.GunA7}",
        $"{ItemType.GrenadeFlash}",
        $"{ItemType.Lantern}",
        $"{ItemType.Medkit}"
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
