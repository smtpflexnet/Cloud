using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudSupport
{
    public class OutageUpdate : Outage
    {
        public OutageUpdate(String Platform) : this(Platform, null) { }

        public OutageUpdate(String Platform, Outage Ongoing) : base(Platform, "Update")
        {
            OutageHeader = "Information update for outage on";
            OpeningStatement = "Hello, please be aware of the following update information:";
            ReturnTimeHeader = "New Est. <br>Return Time";
            Icon = "images/smallIconRed.png";
            this._Outage = Ongoing;
            if (Ongoing != null)
            {
                base.Start = Ongoing.Start;
                base.ServiceImpacted = Ongoing.ServiceImpacted;
                base.ProblemSummary = Ongoing.ServiceImpacted;
               // base.AffectedSites = Ongoing.AffectedSites;
            }
        }

        public String Update { set; get; }
        ///public Outage Ongoing { private set; get; }
    }
}