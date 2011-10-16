<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    UnvalidatedRedirectsAndForwardsFix2
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Unvalidated Redirects And Forwards #2 - Fix</h2>
<h3>This example validates the incoming URL against a whitelist of domains.  If the URL isn't contained in the whitelist, it throws an exception.</h3>

<p>To test this, click the following link: <a href="http://localhost:59586/Security/RedirectToWhiteList?code=google.com">http://localhost:59586/Security/RedirectToWhiteList?code=google.com</a></p>

</asp:Content>
