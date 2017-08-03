using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace CloudSupport
{
    public class Outage
    {
        public Outage(String Platform, String OutageType)
        {
            this.Platform = Platform;
            this.EmailHeader =
                String.Format("{0} Outage {1} -- 3DEXPERIENCE platform Public Cloud", Platform, OutageType);
            Locations = new Locations("images/green.png", "images/red.png");
        }

        public String OutageType { protected set; get; }
        public String EmailHeader { private set; get; }
        public String Platform { protected set; get; }
        public String ReturnTimeHeader { protected set; get; }
        public DateTime Start { set; get; }
        public DateTime Return { set; get; }
        public String ServiceImpacted { set; get; }
        public String ProblemSummary { set; get; }
        [Description("Optional")]
        public String OpeningStatement { set; get; }
        [Description("Optional")]
        public String OutageHeader { set; get; }
        [Description("Optional")]
        public String Icon { set; get; }
        public Locations Locations { set; get; }

        public DateTime InfoReceived { set; get; }
        public DateTime MailSent { set; get; }
        public DateTime BlogPosted { set; get; }

        public Outage _Outage { set; get; }
        /*
        public enum Sites
        {
            EUROPE = 0,
            CHINA = 0,
            HONG_KONG = 0,
            SINGAPORE = 0,
            KOREA = 0,
            TOKYO = 0,
            US_WEST = 0,
            US_EAST = 0
        }
        public Sites AffectedSites { set; get; } 
        */
    } 
}