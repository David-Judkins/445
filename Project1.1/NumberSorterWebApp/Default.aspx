<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NumberSorterWebApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron" style="text-align: center; font-family: 'Century Gothic'; height: 615px; ">
       
        <br />
    
        <asp:Label ID="Label1" runat="server" style="text-align: center; font-size: xx-large; font-weight: 700; text-decoration: underline;" Text="Number Sorter"></asp:Label>
        
        <asp:Panel ID="Panel2" runat="server" Height="140px" style="margin-top: 46px" BackColor="#FFD2D2" BorderColor="#CEFFE7" BorderStyle="Ridge" Font-Bold="False">
            <br />
            <asp:Label ID="Label2" runat="server" Text="How would you like the list to be sorted?" style="font-weight: 700; font-size: large;"></asp:Label>
            <br />
            <br />
            
            <asp:Button ID="Ascending" runat="server" Text="Ascending Order" Height="47px" Width="140px" BackColor="White" BorderColor="Black" BorderStyle="Solid" Font-Bold="True" OnClick="Button1_Click1" />
             &#9
             &#9
             &#9
             &#9
            &#9
            			<asp:Button ID="Descending" runat="server" Text="Descending Order"  margin="10px" Height="47px" Width="140px" BackColor="White" BorderColor="Black" BorderStyle="Solid" Font-Bold="True" OnClick="Descending_Click"/>
        </asp:Panel>
        <asp:Panel ID="SorterPanel" runat="server" Height="245px" style="margin-top: 46px" BackColor="#D2FFFF" BorderColor="#C4C4FF" BorderStyle="Inset" Visible="False">
            <br />
            <strong><span style="font-size: large">Enter your list of numbers separated by commas. No need to worry about spaces, I covered it!<br /> </span></strong></span style="font-size: medium">
            <br />
            (Ex. 45,12,23,3,1,2,34,2,1)<strong><br /></strong><strong>
            <asp:TextBox ID="ListInput" runat="server" Width="578px"></asp:TextBox>
            <br />
            <br />
            </strong>
            <asp:Button ID="Button3" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" Height="36px" Text="Click here when you're ready!" OnClick="Button3_Click" />
            <br />
            <br />
            <asp:Label ID="ListPrint" runat="server" ForeColor="#CC3300" style="font-size: large" Text="Your sorted list will display here"></asp:Label>
        </asp:Panel>
               
    </div>

    <asp:Panel ID="Panel1" runat="server">
    </asp:Panel>

</asp:Content>