<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NumberSortWebSite._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron" style="text-align: left; font-family: 'Century Gothic';">
       
        <span style="font-size: xx-large; font-family: 'Courier New'; text-decoration: underline;"><strong>This Program Sorts a List of Comma Separated of Numbers!</strong></span>
        <br />
        <br />
        Enter a list of numbers with commas separating them,&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style="color: #0066FF">&nbsp;&nbsp;&nbsp;&nbsp; (Ex. 67,23,1,2,3,5,23,12)</span><br />
        no need to worry about spaces!&nbsp; I took care of them XD&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="ListInput" runat="server" Height="18px" Width="608px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" BackColor="Black" BorderColor="#336600" BorderStyle="Inset" BorderWidth="3px" ForeColor="White" Text="Click here when youre ready" OnClick="Button1_Click" Width="650px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:Label ID="ListPrint" runat="server" Text="THE SORTED LIST WILL APPEAR HERE!" ForeColor="#CC0000"></asp:Label>
       
    </div>

</asp:Content>
