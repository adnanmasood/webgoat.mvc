<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<WebGoat.MVC.Models.CreditCard>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<fieldset>
    
    <div class="display-label">FirstName </div>
    <div class="display-field"><%: Model.FirstName %></div>

    <div class="display-label">LastName</div>
    <div class="display-field"><%: Model.LastName %></div>

    <div class="display-label">CreditCardNumber </div>
    <div class="display-field"><%: Model.CreditCardNumber %></div>
</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value="Delete" /> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>
<% } %>

</asp:Content>


