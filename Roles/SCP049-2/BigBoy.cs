using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.CustomRoles.API.Features;
using PlayerRoles;
using UnityEngine;

namespace MoreFacilityRoles.Roles.SCP049_2;

public class BigBoy : CustomRole
{
    public override uint Id { get; set; } = 55858;
    public override int MaxHealth { get; set; } = 850;
    public override string Name { get; set; } =  "BigBoy";
    public override string Description { get; set; } = "Big zombie and we have good Hp";
    public override string CustomInfo { get; set; } = "BigBoy";
    public override RoleTypeId Role { get; set; } =  RoleTypeId.Scp0492;
    public override Vector3 Scale { get; set; } = new (1f, 2.2f, 1f);
    public override float SpawnChance { get; set; } = 100f;
    public override void AddRole(Player player)
    {
        player.Health = MaxHealth;
        Log.Debug("Role Added");
        base.AddRole(player);
    }
    
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