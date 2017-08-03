using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CloudSupport
{
    public partial class _Default : Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Outage outage = null;

            if (!IsPostBack)
            {
                outage = new OutageOngoing("Academia")
                {
                    Start = DateTime.Now,
                    Return = DateTime.Now,
                    ProblemSummary = String.Empty,
                    ServiceImpacted = String.Empty
                };

                Locations location = outage.Locations;
                location["Europe"] = false;
                location["China"] = false;
                location["Hong-Kong"] = false;
                location["Singapore"] = false;
                location["Korea"] = false;
                location["Tokyo"] = false;
                location["US-West"] = false;
                location["US-East"] = false;

                SetTabDefaults();

                Session["Outage"] = Session["Ongoing"] = outage;
            }
            else
            {
                outage = (Outage) Session["Outage"];
               // RefreshOutageContent();
               // RefreshPreviewContent();
            }


            RefreshOutageContent();
            RefreshPreviewContent();


            /*
            else
            {
                String tab = GetSelectedTab();
                switch(tab)
                {
                    case "Ongoing":
                        OutageOngoing outage = (OutageOngoing) Session["Outage"];
                        break;
                    case "Update":
                        break;
                    case "Recovery":
                        break;
                        
                }
            }*/
        }

        protected void OutageButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Style["background-color"] = "red";
            Response.Write(b.Text);

        }

        private void SetTabDefaults()
        {
            this.Outage_RadioButtonList.SelectedIndex = 0;
            this.Preview_RadioButtonList.SelectedIndex = 0;
        }

        private void RefreshPreviewContent()
        {
            String value = this.Preview_RadioButtonList.SelectedValue;
            String page = String.Empty;
            switch (value.ToLower())
            {
                case "email": page = "Customers.aspx"; break;
                case "kb": page = "Knowledgebase.aspx"; break;
                case "excel": page = "Excel.aspx"; break;
                default: return;
            }
            this.PreviewFrame.Attributes["src"] = page;
        }

        private void RefreshOutageContent()
        {
            Outage outage = null;
            String value = this.Outage_RadioButtonList.SelectedValue.ToLower();
            switch (value)
            {
                case "ongoing": outage = (OutageOngoing)Session["Ongoing"]; break;
                case "update": outage = (OutageUpdate)Session["Update"]; break;
                case "recovery": outage = (OutageRecovery)Session["Recovery"]; break;
                default: return;
            }
            Session["Outage"] = outage;
            this.OutageFrame.Attributes["src"] = "Outage_.aspx";
        }

        protected void Outage_RadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshOutageContent();
            RefreshPreviewContent();
        }


        protected void Preview_RadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshPreviewContent();
        }

   
        private String OutageHeader;
    }
}