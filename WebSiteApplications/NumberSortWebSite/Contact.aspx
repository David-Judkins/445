<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="NumberSortWebSite.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>Davids Contact Information</h2>
    <p>-------------------------------------</p>
    <address>
        806 W Brown St<br />
        Tempe, AZ 85281<br />
        <abbr title="Phone">P:</abbr> 703.725.8195</address>

    <address>
        <strong>Support:</strong>   <a href="mailto:judkinsdavid12@gmail.com">judkinsdavid12@gmail.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:dgjudkin@asu.edu">dgjudkin@asu.edu</a>
    </address>
</asp:Content>
