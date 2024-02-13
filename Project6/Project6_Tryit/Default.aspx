<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Project3_Tryit._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section>
                <asp:Table ID="Table1" runat="server" Height="272px" Width="703px">
                    <asp:TableHeaderRow>
                        <asp:TableHeaderCell ColumnSpan="5">Application and Components Summary Table</asp:TableHeaderCell>
                    </asp:TableHeaderRow>
                    <asp:TableHeaderRow>
                        <asp:TableCell ColumnSpan="5" HorizontalAlign="Center">
                            Percentage of Contribution: <br/>
                            Kaylem Brown-Malone: 50%, Sherwin Wang: 50%
                        </asp:TableCell>
                    </asp:TableHeaderRow>
                    <asp:TableHeaderRow>
                        <asp:TableHeaderCell>Provider Name</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Page/Component Type</asp:TableHeaderCell>
                        <asp:TableHeaderCell>TryIt Link</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Component Description</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Resources</asp:TableHeaderCell>
                    </asp:TableHeaderRow>
                    <asp:TableRow>
                        <asp:TableCell>Sherwin</asp:TableCell>
                        <asp:TableCell>GymFinderService</asp:TableCell>
                        <asp:TableCell>
                            <asp:HyperLink NavigateUrl="GymFinder.aspx" Text="Link" runat="server" />
                        </asp:TableCell>
                        <asp:TableCell>Finds closest 5 gyms from given zip.</asp:TableCell>
                        <asp:TableCell>C#, uses google geocode and places APIs.</asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>Sherwin</asp:TableCell>
                        <asp:TableCell>Recaptcha Component</asp:TableCell>
                        <asp:TableCell>
                            <asp:HyperLink NavigateUrl="GymFinder.aspx" Text="Link" runat="server" />
                        </asp:TableCell>
                        <asp:TableCell>Verifies human upon login.</asp:TableCell>
                        <asp:TableCell>C#, uses google recaptcha.</asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>Sherwin</asp:TableCell>
                        <asp:TableCell>Hashing Function</asp:TableCell>
                        <asp:TableCell>
                            <asp:HyperLink NavigateUrl="GymFinder.aspx" Text="Link" runat="server" />
                        </asp:TableCell>
                        <asp:TableCell>Hashes given input.</asp:TableCell>
                        <asp:TableCell>C#, SHA256</asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>Sherwin</asp:TableCell>
                        <asp:TableCell>XML Operations</asp:TableCell>
                        <asp:TableCell>
                            <asp:HyperLink NavigateUrl="GymFinder.aspx" Text="Link" runat="server" />
                        </asp:TableCell>
                        <asp:TableCell>Adds members by username and password. Can search for member's password given username.</asp:TableCell>
                        <asp:TableCell>C#, xml</asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
        </section>
    </main>

</asp:Content>

