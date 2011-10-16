<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    FailureToRestrictURLAccess1
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Failure To Restrict URL Access</h2>

<p>We will test the access to the Dashboard which should be only accessible by administrators.</p>

<p>To test, Log in as an administrator.</p>

</asp:Content>
