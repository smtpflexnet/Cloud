using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CloudSupport
{
    public partial class Customers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Outage outage = (Outage)Session["Outage"];
            if (outage == null)
                return;

            //if (!IsPostBack)
           // {
                OutageHeader = outage.OutageHeader;
                PlatformHeader = outage.Platform;
                OpeningStatement = outage.OpeningStatement;
                TopLeftIcon = outage.Icon;
                ReturnTimeHeader = outage.ReturnTimeHeader;
                StartTime = outage.Start.ToString("MM/dd/yy H:mm tt");
                ReturnTime = outage.Return.ToString("MM/dd/yy H:mm tt");
                ServiceImpactedHeader = String.Empty;
                ServiceImpactedBody = outage.ServiceImpacted;
                ProblemSummaryHeader = String.Empty;
                ProblemSummaryBody = outage.ProblemSummary;
                Platform = outage.Platform;

                Europe = outage.Locations.GetImage("Europe");
                China = outage.Locations.GetImage("China");
                HongKong = outage.Locations.GetImage("Hong-Kong");
                Singapore = outage.Locations.GetImage("Singapore");
                Korea = outage.Locations.GetImage("Korea");
                Tokyo = outage.Locations.GetImage("Tokyo");
                USWest = outage.Locations.GetImage("US-West");
                USEast = outage.Locations.GetImage("US-East");
            //}
        }

        public String OutageHeader;
        public String PlatformHeader;
        public String OpeningStatement;
        public String TopLeftIcon;
        public String ReturnTimeHeader;
        public String ServiceImpactedHeader;
        public String ServiceImpactedBody;
        public String ProblemSummaryHeader;
        public String ProblemSummaryBody;
        public String StartTime;
        public String ReturnTime;
        public String Platform;

        public String Europe;
        public String China;
        public String HongKong;
        public String Singapore;
        public String Korea;
        public String Tokyo;
        public String USWest;
        public String USEast;
    }
}