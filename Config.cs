using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Interfaces;
using LiteNetLib4Mirror.Open.Nat;
using MoreFacilityRoles.Roles;

namespace MoreFacilityRoles
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } =  true;
        
        public bool Debug { get; set; } =  false;

        public DrX DrX { get; set; } = new();
        
        public GuardSupporter GuardSupporter { get; set; } = new();

        public Kid Kid { get; set; } = new();
        
        public Doctor Doctor { get; set; } = new();
        
        public GuardCaptin GuardCaptin { get; set; } = new();
        
        public Janitor JanitorRole { get; set; } = new();
        
        public List<Doctor> doctor { get; set; } = new();
        
        public List<DrX> drX { get; set; } = new();
        
        public List<GuardSupporter> guardSupporter { get; set; } = new();
        
        public List<Kid>  kids { get; set; } = new();
        
        public List<GuardCaptin> guard { get; set; } = new();
        
        public List<Janitor> janitor { get; set; } = new();
        
        [Description("Hints")]
        
        public string Janitor { get; set; } = "";
        
        
    }
}