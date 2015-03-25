<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    InsecureCryptographicStorage1
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Insecure Cryptographic Storage 1</h2>

<p>This will demonstrate how to use encryption to secure your sensitive data.</p>

<p><%: Html.ActionLink("Go to the Credit Cards Area", "Index", "CreditCards") %></p>

</asp:Content>
