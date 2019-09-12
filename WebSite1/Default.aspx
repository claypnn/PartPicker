<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Button ID="ReadXmlUsingXMLDocument" runat="server" Text="ReadXMLDataUsingXMLDocument" OnClick="ReadXmlUsingXMLDocument_Click" />  
    <asp:TextBox ID="ID" runat="server" Width="250"></asp:TextBox>
    <asp:TextBox ID="SEOSlug" runat="server" Width="250"></asp:TextBox>
    <asp:TextBox ID="Type" runat="server" Width="250"></asp:TextBox>
    <asp:TextBox ID="Name" runat="server" Width="250"></asp:TextBox>
    <asp:TextBox ID="imageS" runat="server" Width="250"></asp:TextBox>
</asp:Content>
