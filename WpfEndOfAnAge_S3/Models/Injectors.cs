using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEndOfAnAge_S3.Models
{
    public class Injectors : GameItem
    {
        public int HealthChange { get; set; }
        public int EnergyChange { get; set; }

        public Injectors(int id, string name, int value, int healthChange, int energyChange, string description, int experiencePoints)
            : base(id, name, value, description, experiencePoints)
        {
            HealthChange = healthChange;
            EnergyChange = energyChange;
        }
        public override string InformationString()
        {
            if (HealthChange != 0)
            {
                return $"{Name}: {Description}\nHealth: {HealthChange}";
            }
            else if(EnergyChange != 0)
            {
                return $"{Name}: {Description}\nEnergy: {EnergyChange}";
            }
            else
            {
                return $"{Name}: {Description}";
            }
        }

    }
}
