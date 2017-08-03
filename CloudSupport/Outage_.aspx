<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Outage_.aspx.cs" Inherits="CloudSupport.Outage1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/TR/REC-html40">
<head>
<head runat="server">
     <link rel="stylesheet" href="Content/style.css">
    <title></title>
</head>


<body>
    <form id="body" runat="server">
        <br>
        <b>Select a customer:</b>
        <br>
        <br>
        <select id="platformSelect" name="platform" runat="server">
            <option value="CUSTOMERS">Customers</option>
            <option value="ACADEMIA">Academia</option>
        </select>
        <br/>
        <br/>


        <b>Incident Start Time:</b>
        <br>
        <br>
        <input id="startTime" type="datetime-local" name="start" runat="server"/>
        <br/>
        <br/>
        <b>Incident Est. Return Time:</b>
        <br/>
        <br/>
        <input id="returnTime" type="datetime-local" name="return" runat="server"/>
            
        <br/>
        <br/>

        <b>Check affected location(s):</b>
        <br />


         <asp:CheckBoxList runat="server" id="locationsCheckbox">
            <asp:ListItem runat="server">Europe</asp:ListItem>
            <asp:ListItem runat="server">China</asp:ListItem>
            <asp:ListItem runat="server">Hong-Kong</asp:ListItem>
            <asp:ListItem runat="server">Singapore</asp:ListItem>
            <asp:ListItem runat="server">Korea</asp:ListItem>
            <asp:ListItem runat="server">Tokyo</asp:ListItem>
            <asp:ListItem runat="server">US-West</asp:ListItem>
            <asp:ListItem runat="server">US-East</asp:ListItem>
         </asp:CheckBoxList>
        <br/>
        <br/>

        <b>Enter service(s) impacted:</b><br>
        <br>
        <textarea id="servicesImpacted" rows="4" cols="50" runat="server"></textarea>
        <br>
        <br>

        <b>Enter summary of the problem:</b><br>
        <br>
        <textarea id="problemSummary" rows="4" cols="50" runat="server"></textarea>

    </form>
</body>
</html>
