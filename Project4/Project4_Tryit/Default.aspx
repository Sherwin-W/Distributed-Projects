<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Project3_Tryit._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section>
            <asp:Label runat="server" Text="Stock Price Finder" style="display: block; font-weight: bold; font-size: 20px;"></asp:Label>
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
            <asp:Label runat="server" Text="Store Address Finder" style="display: block; font-weight: bold; font-size: 20px;"></asp:Label>
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
        <section>
            <asp:Label runat="server" Text="--------------------------------------------------------------------"></asp:Label>
        </section>
        <section>
            <asp:Label runat="server" Text="Closest Gyms Finder" style="display: block; font-weight: bold; font-size: 20px;"></asp:Label>
            <asp:Label runat="server" Text="Enter US zip code to find the 5 closest gyms in the area."></asp:Label>
        </section>
        <section>
            <asp:Label runat="server" Text="Zip Code:"></asp:Label>
            <asp:TextBox ID="GymZip" runat="server" Style="width: 100px;"></asp:TextBox>
            <asp:Button runat="server" Text="Search" OnClick="GymButton"></asp:Button>
        </section>
        <section>
            <asp:TextBox ID="Gym" runat="server" TextMode="MultiLine" Rows="10" Columns="200" CssClass="auto-resize"></asp:TextBox>
        </section>
                <section>
            <asp:Label runat="server" Text="--------------------------------------------------------------------"></asp:Label>
        </section>
        <section>
            <asp:Label runat="server" Text="Recipe Finder" style="display: block; font-weight: bold; font-size: 20px;"></asp:Label>
            <asp:Label runat="server" Text="Enter a list of ingredients separated by commas to find related recipes."></asp:Label>
        </section>
        <section>
            <asp:Label runat="server" Text="Ingredients:"></asp:Label>
            <asp:TextBox ID="Ingredients" runat="server" style="width: 100px;"></asp:TextBox>
            <asp:Button runat="server" Text="Search" OnClick="RecipeButton"></asp:Button>
        </section>
        <section>
            <asp:Label ID="first" runat="server" Text="Result 1"></asp:Label>
            <asp:Image ID="firstI" style="display: block;" runat="server" ImageUrl="" />
        </section>
        <section>
            <asp:Label ID="second" runat="server" Text="Result 2"></asp:Label>
            <asp:Image ID="secondI" style="display: block;" runat="server" ImageUrl="" />
        </section>
        <section>
            <asp:Label ID="third" runat="server" Text="Result 3"></asp:Label>
            <asp:Image ID="thirdI" style="display: block;" runat="server" ImageUrl="" />
        </section>
        <section>
            <asp:Label ID="fourth" runat="server" Text="Result 4"></asp:Label>
            <asp:Image ID="fourthI" style="display: block;" runat="server" ImageUrl="" />
        </section>
        <section>
            <asp:Label ID="fifth" runat="server" Text="Result 5"></asp:Label>
            <asp:Image ID="fifthI" style="display: block;" runat="server" ImageUrl="" />
        </section>
    </main>

</asp:Content>