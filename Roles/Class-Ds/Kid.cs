using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.CustomRoles.API.Features;
using InventorySystem.Items.Usables.Scp330;
using PlayerRoles;
using PlayerStatsSystem;
using UnityEngine;

namespace MoreFacilityRoles.Roles;

public class Kid : CustomRole
{
    public override uint Id { get; set; } = 1005;
    public override int MaxHealth { get; set; } = 75;
    public override string Name { get; set; } = "Kid-Boy";
    public override string Description { get; set; } = "Its Small classD we have Bad HP but its small and simple speed";
    public override string CustomInfo { get; set; } = "Kid";
    public override RoleTypeId Role { get; set; } = RoleTypeId.ClassD;
    public override float SpawnChance { get; set; } = 100f;
    public override Vector3 Scale { get; set; } = new(0.5f, 0.5f, 0.5f);
    public override List<string> Inventory { get; set; } = new()
    {
        $"{ItemType.Flashlight}",
        $"{ItemType.Coin}"
    };

    public override void AddRole(Player player)
    {
        player.Health = 75;
        player.EnableEffect(EffectType.MovementBoost, 50,50);
        player.DisplayNickname = "Im Kid";
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