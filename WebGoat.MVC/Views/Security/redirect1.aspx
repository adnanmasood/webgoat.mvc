<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    redirect1
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Scenario #1</h2>
<h3>A simple redirect to an external URL.</h3>

<p>To test this, click the following link: <a href="http://localhost:59586/Security/redirect?url=google.com">http://localhost:59586/Security/redirect?url=google.com</a></p>

</asp:Content>
