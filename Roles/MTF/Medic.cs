using System.Collections.Generic;
using Exiled.API.Features;
using Exiled.CustomRoles.API.Features;
using PlayerRoles;

namespace MoreFacilityRoles.Roles.MTF;

public class Medic : CustomRole
{
    public override uint Id { get; set; } = 54;
    public override int MaxHealth { get; set; } = 100;
    public override string Name { get; set; } = "Medic";
    public override string Description { get; set; } = "You have lot medical somthings So help your Team";
    public override string CustomInfo { get; set; } = "Medic";
    public override RoleTypeId Role { get; set; } = RoleTypeId.NtfPrivate;
    public override float SpawnChance { get; set; } = 100f;
    public override List<string> Inventory { get; set; } = new()
    {
        $"{ItemType.GunFSP9}",
        $"{ItemType.ArmorCombat}",
        $"{ItemType.Adrenaline,2}",
        $"{ItemType.SCP500,2}",
        $"{ItemType.Medkit}",
        $"{ItemType.KeycardMTFOperative}"
    };

    public override void AddRole(Player player)
    {
        player.Health = MaxHealth;
        player.Stamina = Main.Instance.Config.Stamina;
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

