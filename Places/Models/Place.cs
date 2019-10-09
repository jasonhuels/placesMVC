using System;
using System.Collections.Generic;

namespace Places.Models
{
    public class Place
    {
        public string CityName {get; set;}
        private static List<Place> _myPlaces = new List<Place>();
        public int ID {get; set;}

        public Place(string cityName)
        {
            CityName = cityName;
            _myPlaces.Add(this);
            ID = _myPlaces.Count;
        }

        public static List<Place> GetAll()
        {
            return _myPlaces;
        }

        public static void ClearAll()
        {
            _myPlaces.Clear();
        }

        public static Place Find(int id)
        {
            return _myPlaces[id-1];
        }
    }

}