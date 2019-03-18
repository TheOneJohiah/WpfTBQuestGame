using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEndOfAnAge_S1.Models
{
    class Map
    {
        private Locations _locations;
        private Locations _currentLocation;
        private ObservableCollection<Locations> _accessibleLocations;

        public ObservableCollection<Locations> AccessibleLocations
        {
            get
            {
                ObservableCollection<Locations> _accessibleLocations = new ObservableCollection<Locations>();
                foreach (var location in _locations)
                {
                    if (location.Accessible == true)
                    {
                        _accessibleLocations.Add(location);
                    }
                    return _accessibleLocations;
                }
            }
        }

        public Locations CurrentLocation
        {
            get { return _currentLocation; }
            set { _currentLocation = value; }
        }

        public Locations Location
        {
            get { return _locations; }
            set { _locations = value; }
        }

        public void Move(Locations location)
        {
            _currentLocation = location;
        }
    }
}
