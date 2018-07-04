<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="PDF._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to ASP.NET!
    </h2>
    <p>
        name-
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </p>
    <p>
        class-
        <asp:Label ID="Label2" runat="server"></asp:Label>
    </p>
    <p>
        DOB-
        <asp:Label ID="Label3" runat="server"></asp:Label>
    </p>
    <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
</asp:Content>
