<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<WebGoat.MVC.Models.CreditCardViewModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Index</h2>

<p>
    <%: Html.ActionLink("Create New", "Create") %>
</p>
<table>
    <tr>
        <th></th>
        <th>
            FirstName
        </th>
        <th>
            LastName
        </th>
        <th>
            CreditCardNumber
        </th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.ActionLink("Edit", "Edit", new {  id=item.Id }) %> |
            <%: Html.ActionLink("Delete", "Delete", new { id = item.Id }) %>
        </td>
        <td> 
			<%: item.FirstName %>
        </td> 
        <td> 
			<%: item.LastName %>
        </td> 
        <td> 
			<%: item.CreditCardNumber %>
        </td>    
    </tr>  
<% } %>

</table>

</asp:Content>


