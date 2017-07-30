<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        Saving Customer Details<br />
    </p>
    <p>
        First Namae<asp:TextBox ID="firstName" runat="server" ToolTip="Enter your FN"></asp:TextBox>
    </p>
    <p>
        Last Name<asp:TextBox ID="lastName" runat="server" OnTextChanged="lastName_TextChanged"></asp:TextBox>
    </p>
    <p>
        Accound Number<asp:TextBox ID="accountNumber" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" Width="100px" />
&nbsp;&nbsp;&nbsp;
    </p>
    <p>
    </p>
    <p>
        &nbsp;</p>

</asp:Content>
