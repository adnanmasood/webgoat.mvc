<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<%
    using (Html.BeginForm())
    {%>

    <p>
Search <input type="text" name="srchString"/></p>
<p><input type="submit" value="Search" /></p>
<%
    }%>
</asp:Content>
