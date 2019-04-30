using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEndOfAnAge_S3.Models
{
    public class Attachments : GameItem
    {
        public enum PartLocationName
        {
            HEAD,
            LEFTARM,
            RIGHTARM,
            LEFTLEG,
            RIGHTLEG
        }

        public int Cohesion { get; set; }
        public int MaxCohesion { get; set; }
        public int Energy { get; set; }
        public int MaxEnergy { get; set; }
        public int Damage { get; set; }
        public PartLocationName PartLocation { get; set; }

        public Attachments(int id, string name, int value, int cohesion, int maxCohesion, int energy, int maxEnergy, int damage, string description, int experiencePoints, PartLocationName partLocation)
            : base(id, name, value, description, experiencePoints)
        {
            Cohesion = cohesion;
            MaxCohesion = maxCohesion;
            Energy = energy;
            MaxEnergy = maxEnergy;
            PartLocation = partLocation;
            Damage = damage;
        }

        //TODO: Rewrite the item description
        public override string InformationString()
        {
            if (Cohesion != 0)
            {
                return $"{Name}: {Description}\nCohesion: {Cohesion}";
            }
            else if (Energy != 0)
            {
                return $"{Name}: {Description}\nEnergy: {Energy}";
            }
            else if (Damage != 0)
            {
                return $"{Name}: {Description}\nDamage: {Damage}";
            }
            else
            {
                return $"{Name}: {Description}";
            }
        }
    }
}
