<%@ Page Title="GymFinder Service" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GymFinder.aspx.cs" Inherits="Project3_Tryit._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
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
            <asp:Label runat="server" Text="------------------------------------------------------" style="display: block;"></asp:Label>
            <asp:Label runat="server" Text="User Control" style="display: block;"></asp:Label>
            <asp:Button runat="server" Text="Try Login" OnClick="LoginButton"></asp:Button>
            <script src='https://www.google.com/recaptcha/api.js' async defer></script>
            <div class="g-recaptcha" data-sitekey="6LcdxAwpAAAAAHlw83uhSpgkjsa8MxklZbNlcKQ9"></div>
            <asp:Label ID="result" runat="server" Text="Result of login attempt..." style="display: block;"></asp:Label>
        </section>
        <section>
            <asp:Label runat="server" Text="------------------------------------------------------" style="display: block;"></asp:Label>
            <asp:Label runat="server" Text="Hashing" style="display: block;"></asp:Label>
            <asp:TextBox ID="hashInput" runat="server" Style="width: 100px;"></asp:TextBox>
            <asp:Button runat="server" Text="HASH" OnClick="HashButton"></asp:Button>
            <asp:Label ID="hashOutput" runat="server" Text="Hashing result..." style="display: block;"></asp:Label>
        </section>
        <section>
            <asp:Label runat="server" Text="------------------------------------------------------" style="display: block;"></asp:Label>
            <asp:Label runat="server" Text="XML Operations" style="display: block;"></asp:Label>
            <asp:Label runat="server" Text="Username:" style="display: block;"></asp:Label>
            <asp:TextBox ID="username" runat="server" Style="width: 100px;"></asp:TextBox>
            <asp:Label runat="server" Text="Password:" style="display: block;"></asp:Label>
            <asp:TextBox ID="password" runat="server" Style="width: 100px;"></asp:TextBox>
            <asp:Button runat="server" Text="Add Member" OnClick="AddMemberButton"></asp:Button>
            <asp:Button runat="server" Text="Search Member (Username Only)" OnClick="SearchButton"></asp:Button>
            <asp:Label ID="searchResult" runat="server" Text="Search Result..." style="display: block;"></asp:Label>
        </section>
    </main>
</asp:Content>
