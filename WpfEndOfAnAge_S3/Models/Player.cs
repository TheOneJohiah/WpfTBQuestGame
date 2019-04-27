﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Data;
using WpfEndOfAnAge_S3.Models;

namespace WpfEndOfAnAge_S1.Models
{
    public class Player : Character
    {
        #region FIELDS
        private int _cohesion;
        private int _wealth;
        private int _experiencePoints;
        private List<Location> _locationsVisited;
        private ObservableCollection<GameItem> _inventory;
        private ObservableCollection<GameItem> _injectors;
        private ObservableCollection<GameItem> _attachments;
        private ObservableCollection<GameItem> _relic;
        private Dictionary<string, Attachments> _equippedAttachments;
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
        }

        public List<Location> LocationsVisited
        {
            get { return _locationsVisited; }
            set { _locationsVisited = value; }
        }

        public int Cohesion
        {
            get { return _cohesion; }
            set { _cohesion = value; }
        }
        public int Wealth
        {
            get { return _wealth; }
            set { _wealth = value; }
        }
        public ObservableCollection<GameItem> Inventory
        {
            get { return _inventory; }
            set { _inventory = value; }
        }
        public ObservableCollection<GameItem> Injectors
        {
            get { return _injectors; }
            set { _injectors = value; }
        }
        public ObservableCollection<GameItem> Attachments
        {
            get { return _attachments; }
            set { _attachments = value; }
        }
        public ObservableCollection<GameItem> Relic
        {
            get { return _relic; }
            set { _relic = value; }
        }
        public Dictionary<string, Attachments> EquippedAttachments
        {
            get { return _equippedAttachments; }
            set { _equippedAttachments = value; }
        }
        #endregion

        #region CONSTRUCTORS
        public Player()
        {
            _locationsVisited = new List<Location>();
            _equippedAttachments = new Dictionary<string, Attachments>();
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
