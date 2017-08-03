using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudSupport
{
    public class OutageRecovery : Outage
    {
        public OutageRecovery(String Platform) : this(Platform, null) { }

        public OutageRecovery(String Platform, Outage Update) : base(Platform, "Recovery")
        {
            OutageHeader = "Outage recovered on";
            OpeningStatement = "Hello, please be aware the following incident is now closed:";
            ReturnTimeHeader = "Recovery<br>Time";
            Icon = "images/smallIconGreen.png";
            this._Outage = Update;
            if (Update != null)
            {
                base.Start = Update.Start;
                base.ServiceImpacted = Update.ServiceImpacted;
                base.ProblemSummary = Update.ServiceImpacted;
               // base.AffectedSites = Update.AffectedSites;
            }
        }

        public DateTime Recovery { set; get; }
        public String Description { set; get; }
        ///public Outage Update { private set; get; }
    }
}