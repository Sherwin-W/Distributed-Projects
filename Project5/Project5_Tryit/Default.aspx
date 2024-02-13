<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Project4_Tryit._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section>
            <asp:Label ID="Verifier" runat="server" Text="2.1 Verifier" style="display: block;" ></asp:Label>
            <section>
                <asp:TextBox ID="XML" runat="server" Text="https://www.public.asu.edu/~smwang2/Parks.xml"></asp:TextBox>
                <asp:TextBox ID="XSD" runat="server" Text="https://www.public.asu.edu/~smwang2/Parks.xsd"></asp:TextBox><asp:Button ID="vButton" runat="server" Text="GO" OnClick="vButton_Click"></asp:Button>
            </section>
            <asp:Label ID="verif" runat="server" Text="RESULT..." style="display: block;"></asp:Label>
        </section>

        <section>
            <asp:Label ID="Searcher" runat="server" Text="2.2 Search" style="display: block;" ></asp:Label>
            <section>
                <asp:TextBox ID="URL" runat="server" Text="https://www.public.asu.edu/~smwang2/Parks.xml"></asp:TextBox>
                <asp:TextBox ID="Key" runat="server" Text="Enter search key"></asp:TextBox><asp:Button ID="sButton" runat="server" Text="GO" OnClick="sButton_Click"></asp:Button>
            </section>
            <asp:GridView runat="server" ID="gridViewControl" AutoGenerateColumns="true"></asp:GridView>
        </section>
    </main>

</asp:Content>
