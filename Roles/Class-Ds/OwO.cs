using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Spawn;
using Exiled.CustomRoles.API.Features;
using PlayerRoles;
using UnityEngine;
using Color = System.Drawing.Color;

namespace MoreFacilityRoles.Roles;

public class OwO : CustomRole
{
    public override uint Id { get; set; } = 121;
    public override int MaxHealth { get; set; } = 100;
    public override string Name { get; set; } = "OwO";
    public override string Description { get; set; } = "So cute :) we have silent walk";
    public override string CustomInfo { get; set; } = "OwO";
    public override List<string> Inventory { get; set; } = new()
    {
        $"{ItemType.KeycardScientist}",
        $"{ItemType.Flashlight}",
        $"{ItemType.GunCOM15}"
    };

    public override RoleTypeId Role { get; set; } = RoleTypeId.ClassD;
    public override float SpawnChance { get; set; } = 100f;
    public override void AddRole(Player player)
    {
        player.RankColor = nameof(Color);
        {
            Color32 color = new Color32(255, 0, 255, 255);
        }
        player.EnableEffect(EffectType.SilentWalk);
        base.AddRole(player);
    }

    public override SpawnProperties? SpawnProperties { get; set; } = new()
    {
        Limit = 1,
        DynamicSpawnPoints = new List<DynamicSpawnPoint>
        {
            new()
            {
                Chance = 100,
                Location = SpawnLocationType.InsideGr18Glass,
                
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
