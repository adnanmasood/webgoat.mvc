<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    UnvalidatedRedirectsAndForwardsFix1
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Unvalidated Redirects And Forwards #1 - Fix</h2>
<h3>This throws an exception if the redirecting URL does not belong to this domain.</h3>

<p>To test this, click the following link: <a href="http://localhost:59586/Security/redirect1fix?url=google.com">http://localhost:59586/Security/redirect1fix?url=google.com</a></p>

</asp:Content>
