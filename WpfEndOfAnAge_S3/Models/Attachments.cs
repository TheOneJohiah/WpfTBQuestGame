using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEndOfAnAge_S3.Models
{
    class Attachments : GameItem
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
        public int Energy { get; set; }
        public PartLocationName PartLocation { get; set; }

        public Attachments(int id, string name, int value, int cohesion, int energy, string description, int experiencePoints, PartLocationName partLocation)
            : base(id, name, value, description, experiencePoints)
        {
            Cohesion = cohesion;
            Energy = energy;
            PartLocation = partLocation;
        }

        //TODO: Rewrite the item description
        public override string InformationString()
        {
            if (Cohesion != 0)
            {
                return $"{Name}: {Description}\nHealth: {Cohesion}";
            }
            else if (Energy != 0)
            {
                return $"{Name}: {Description}\nEnergy: {Energy}";
            }
            else
            {
                return $"{Name}: {Description}";
            }
        }
    }
}
