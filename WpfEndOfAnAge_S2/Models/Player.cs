﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEndOfAnAge_S1.Models
{
    public class Player : Character
    {
        #region ENUMS


        #endregion

        #region FIELDS
        private int _experiencePoints;
        private List<Location> _locationsVisited;
        //TODO: Figure out individual limb stats, and how to change them when upgrading/in combat
        #endregion

        #region PROPERTIES
        public int ExperiencePoints
        {
            get { return _experiencePoints; }
            set
            {
                _experiencePoints = value;
                OnPropertyChanged(nameof(ExperiencePoints));
            }
        }+

        public List<Location> LocationsVisited
        {
            get { return _locationsVisited; }
            set { _locationsVisited = value; }
        }
        #endregion

        #region CONSTRUCTORS
        public Player()
        {
            _locationsVisited = new List<Location>();
        }
        
        #endregion

        #region METHODS

        /// <summary>
        /// override the default greeting in the Character class to include faction alignment/nonalignment
        /// </summary>
        /// <returns>default greeting</returns>
        public override string DefaultGreeting()
        {
            if (_alignment.ToString() == "Unaligned")
            {
                return $"Hello, my name is {_name}.";
            }
            else if (_alignment.ToString() != "TSOFP")
            {
                return $"Hello, my name is {_name} and I serve {_alignment}.";
            }
            else
            {
                return $"Hello, my name is {_name} and I am a member of The Society of Future Past.";
            }

        }

        public override FactionAlignment ChangeAlignment()
        {
            throw new NotImplementedException();
            //TODO: Make method change player's faction alignment based on output from a popup window for this purpose
        }

        public bool HasVisited(Location location)
        {
            return _locationsVisited.Contains(location);
        }

        #endregion

        #region EVENTS



        #endregion

    }
}
