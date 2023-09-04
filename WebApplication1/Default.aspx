<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button runat="server" Text="To Celsius" OnClick="Unnamed1_Click"></asp:Button><asp:Label id="CLabel" runat="server" Text="----C"></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><asp:Button runat="server" Text="To Fahrenheit" OnClick="Unnamed3_Click"></asp:Button><asp:Label id="FLabel" runat="server" Text="----F"></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><asp:Button runat="server" Text="Sort Numbers" OnClick="Unnamed5_Click"></asp:Button><asp:Label id="sortedLabel" runat="server" Text="----"></asp:Label>
        </div>
    </main>

</asp:Content>
