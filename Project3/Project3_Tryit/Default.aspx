<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Project3_Tryit._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section>
            <asp:Label runat="server" Text="Enter in desired stock's ticker and month, day, and year."></asp:Label>
        </section>
        <section>
            <asp:Label runat="server" Text="Ticker:"></asp:Label>
            <asp:TextBox ID="Ticker" runat="server" style="width: 100px;"></asp:TextBox><asp:Label runat="server" Text="Month:"></asp:Label>
            <asp:TextBox ID="Month" runat="server" style="width: 50px;"></asp:TextBox><asp:Label runat="server" Text="Day:"></asp:Label>
            <asp:TextBox ID="Day" runat="server" style="width: 50px;"></asp:TextBox><asp:Label runat="server" Text="Year:"></asp:Label>
            <asp:TextBox ID="Year" runat="server" style="width: 50px;"></asp:TextBox><asp:Button runat="server" Text="Get Price" OnClick="StockButton"></asp:Button>
        </section>
        <section>
            <asp:TextBox ID="Price" runat="server" style="width: 100px;" ReadOnly="true"></asp:TextBox><asp:Label runat="server" Text="Textbox will display ticker's open price at date."></asp:Label>
        </section>
         <section>
            <asp:Label runat="server" Text="--------------------------------------------------------------------"></asp:Label>
        </section>
        <section>
            <asp:Label runat="server" Text="Enter US zip code and store name."></asp:Label>
        </section>
        <section>
            <asp:Label runat="server" Text="Zip Code:"></asp:Label>
            <asp:TextBox ID="Zipcode" runat="server" style="width: 100px;"></asp:TextBox><asp:Label runat="server" Text="Store Name:"></asp:Label>
            <asp:TextBox ID="Store" runat="server" style="width: 100px;"></asp:TextBox><asp:Button runat="server" Text="Search" OnClick="SearchButton"></asp:Button>
        </section>
        <section>
            <asp:TextBox ID="Address" runat="server" style="width: 600px;" ReadOnly="true"></asp:TextBox>
        </section>
        <section>
            <asp:Label runat="server" Text="Textbox will display closest store's address."></asp:Label>
        </section>
    </main>

</asp:Content>