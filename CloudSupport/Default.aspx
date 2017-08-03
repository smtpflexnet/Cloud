<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CloudSupport._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">   
    <head>
        <link rel="alternate stylesheet" href="Content/apriso.css">
        <link rel="stylesheet" href="Content/style.css">
        <link rel="stylesheet" href="https://code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">

        <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
        <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
        <script src="Scripts/script.js"></script>
    </head>
            
    <!------------------------------------------------------------------------------------------------------------->
    
    <body>
        <div id="page">
        <div id="header">
            <div id="logo"></div>
            <span id="title"><b>DELMIA</b> Apriso | Cloud Support Message Generator</span>
        </div>

        <div id="userInput">

            <!-- testing only, uncomment later-->
            <div class="menuItem">
            <asp:RadioButtonList ID="Outage_RadioButtonList" runat="server" RepeatDirection="Horizontal" OnSelectedIndexChanged="Outage_RadioButtonList_SelectedIndexChanged" EnableViewState="False" AutoPostBack="True">
                <asp:ListItem>Ongoing</asp:ListItem> 
                <asp:ListItem>Update</asp:ListItem> 
                <asp:ListItem>Recovery</asp:ListItem>
            </asp:RadioButtonList>
            </div>
             <!--div class="menuItem">
                <form>
                <label class="blue"><input type="radio" name="toggle" runat="server" id="ongoing_radio" onchange="alert(changed);"><span>Ongoing</span></label>
                <label class="blue"><input type="radio" name="toggle" runat="server" id="update_radio"><span>Update</span></label>
                <label class="blue"><input type="radio" name="toggle" runat="server" id="recovery_radio"><span>Recovery</span></label>
                </form>
            </div-->
            <br />

            <div id="Outage" class="tabcontent active" style="display: block;">
                <br />
                <br />
                <br />
                <br />
                <iframe id="OutageFrame" src="about:blank" runat="server"></iframe>
            </div>
            <!--
            <div id="Ongoing" class="tabcontent active" style="display: block;">
                <h3>Ongoing</h3>
                <iframe src="Outage_.aspx"></iframe>  
            </div>

            <div id="Recovery" class="tabcontent">
                <h3>Recovery</h3>
                <iframe src="Outage_.aspx"></iframe>
            </div>

            <div id="Update" class="tabcontent">
                <h3>Update</h3>
                <iframe src="Outage_.aspx"></iframe>
            </div>
              -->  
        </div>
        <!------------------------------------------------------------------------------------------------------------->
        
        <div id="generatedPreview" >
            <div class="menuItem">
            <asp:RadioButtonList ID="Preview_RadioButtonList" runat="server" RepeatDirection="Horizontal" OnSelectedIndexChanged="Preview_RadioButtonList_SelectedIndexChanged" EnableViewState="False" AutoPostBack="True">
                <asp:ListItem>Email</asp:ListItem> 
                <asp:ListItem>KB</asp:ListItem> 
                <asp:ListItem>Excel</asp:ListItem>
            </asp:RadioButtonList>
            </div>
             <!--div class="menuItem">
                <form id="outageItems" onchange="test">
                <label class="blue"><input type="radio" name="toggle" runat="server" id="email_radio"><span>Email</span></label>
                <label class="blue"><input type="radio" name="toggle" runat="server" id="kb_radio"><span>KB</span></label>
                <label class="blue"><input type="radio" name="toggle" runat="server" id="excel_radio"><span>Excel</span></label>
                </form>
            </div-->

            <br />
            
            <div id="Email" class="tabcontent active" style="display: block;">
                <br/>
                <br/>
                <b>Email Subject:</b>
                <input type="text" id="emailSubject" name="email" value="" size="50">
                <br/>
                <br/>
                <iframe id="PreviewFrame" src="about:blank" runat="server"></iframe>
            </div>

            <!--div id="KnowledgeBase" class="tabcontent">
            </!--div>
            
            <div id="Excel" class="tabcontent">
                <h1>Coming soon!</h1>
            </div-->
            
        </div>  


        </div>

        
        
    </body> 
</asp:Content>
