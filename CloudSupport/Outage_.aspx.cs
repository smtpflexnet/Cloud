using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CloudSupport
{
    public partial class Outage1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Outage outage = (Outage) Session["Outage"];
            if (outage != null)
            {
                Init(outage);
            }
            
        }

        private void Init(Outage outage)
        {
            int platformCount = platformSelect.Items.Count;
            for (int i=0; i < platformCount; ++i)
            {
                if(platformSelect.Items[i].Text == outage.Platform)
                {
                    platformSelect.Items[i].Selected = true;
                    break;
                }
            }
            this.startTime.Value = outage.Start.ToString("yyyy-MM-ddTHH:mm:ss");//Helper.ToDatetimeLocal(outage.Start);
            this.returnTime.Value = outage.Return.ToString("yyyy-MM-ddTHH:mm:ss");//Helper.ToDatetimeLocal(outage.Return);
            //String[] keys = outage.Locations.Keys;
            int locationsCount = this.locationsCheckbox.Items.Count;
            for (int i = 0; i < locationsCount; ++i)
            {
                String key = locationsCheckbox.Items[i].Text;
                bool status = outage.Locations[key];
                locationsCheckbox.Items[i].Selected = status;
            }

            this.servicesImpacted.Value = outage.ServiceImpacted;
            this.problemSummary.Value = outage.ProblemSummary;
        }


        private void OnChangeSave()
        {

        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
           // Response.Write("alert(\'LoadComplete\')");
        }
    }
}