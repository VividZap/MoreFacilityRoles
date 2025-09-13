using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.CustomRoles.API.Features;
using PlayerRoles;

namespace MoreFacilityRoles.Roles;

public class GuardSupporter : CustomRole
{
    public override uint Id { get; set; } = 9650;
    public override int MaxHealth { get; set; } = 100;
    public override string Name { get; set; } = "Guard Supporter";
    public override string Description { get; set; } = "We have good weapons for attack SCPs";
    public override string CustomInfo { get; set; } =  "Guard Supporter";
    public override RoleTypeId Role { get; set; } = RoleTypeId.FacilityGuard;
    public override float SpawnChance { get; set; } = 100f;

    public override Dictionary<AmmoType, ushort> Ammo { get; set; } = new()
    {
        { AmmoType.Nato556, 100 },
    };

    public override List<string> Inventory { get; set; } = new()
    {
        $"{ItemType.KeycardMTFPrivate}",
        $"{ItemType.ArmorCombat}",
        $"{ItemType.GunE11SR}",
        $"{ItemType.GrenadeFlash}",
        $"{ItemType.Radio}",
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