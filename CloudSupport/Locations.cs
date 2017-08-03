using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudSupport
{
    public class Locations
    {
        public Locations(String enabledImage, String disabledImage)
        {
            this.enabledImage = enabledImage;
            this.disabledImage = disabledImage;
        }

        public bool this[String key]
        {
            get
            {
                return locations[key];
            }
            set
            {
                locations[key] = value;
            }
        }

        public String GetImage(string key)
        {
            return (locations[key] ? disabledImage : enabledImage);
        }

        // OLD
        /*
        public void Enable(String key)
        {
            locations[key] = true;
        }

        public void Disable(String key)
        {
            locations[key] = false;
        }

        public String this[String key]
        {
            get
            {
                return (locations[key] ? disabledImage : enabledImage);
            }
        }*/

        public String[] Keys
        {
            get
            {
                return locations.Keys.ToArray<String>();
            }
        }

        /*public Dictionary<string, bool>.Enumerator Enumerator
        {
            get { return locations.GetEnumerator(); }
        }*/


        private String enabledImage;
        private String disabledImage;
        private Dictionary<String, Boolean> locations = new Dictionary<String, Boolean>();
    }
}