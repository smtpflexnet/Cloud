<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OutageInput.aspx.cs" Inherits="CloudSupport.OutageInput" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="userInputContent">

            </div>
        <asp:ScriptManager ID="ScriptManager" runat="server">
        </asp:ScriptManager>

            <form action="/action_page.php">
                <asp:Label ID="Customer_Label" runat="server" Text="Select a customer:"></asp:Label>
                <br>
                <br>
                <asp:DropDownList ID="Customers_DropDownList" runat="server">
                </asp:DropDownList>
            </form>
            <br>
            <br>
            

            <form action="/action_page.php">
                <asp:Label ID="StartTime_Label" runat="server" Text="Incident Start Time:"></asp:Label>
                <br>
                <br>

                <input id="startTime" type="datetime-local" name="start"><br>
                <br>
                <b>Incident Est. Return Time:</b>
                <br>
                <br>
                <input id="estReturnTime" type="datetime-local" name="return">
            </form>
            <br>
            <br>

            <asp:Label ID="Label1" runat="server" Text="Check affected location(s):"></asp:Label>
            <asp:CheckBoxList ID="Locations_CheckBoxList" runat="server">
                <asp:ListItem>Europe</asp:ListItem>
                <asp:ListItem>China</asp:ListItem>
                <asp:ListItem>Hong-Kong</asp:ListItem>
                <asp:ListItem>Singapore</asp:ListItem>
                <asp:ListItem>Korea</asp:ListItem>
                <asp:ListItem>Tokyo</asp:ListItem>
                <asp:ListItem>US-West</asp:ListItem>
                <asp:ListItem>US-East</asp:ListItem>
            </asp:CheckBoxList>
            <br>
            <br>

            <asp:Label ID="Services_Label" runat="server" Text="Enter service(s) impacted:"></asp:Label>
            <br>
            <br>
            <textarea id="servicesImpacted" rows="4" cols="50"></textarea>
            <br>
            <br>

            <asp:Label ID="Summary_Label" runat="server" Text="Enter summary of the problem:"></asp:Label>
            <br>
            <br>
            <textarea id="problemSummary" rows="4" cols="50"></textarea>

        </div>
    </form>
</body>
</html>
