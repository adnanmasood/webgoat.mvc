<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<WebGoat.MVC.Models.CreditCard>" %>

<div class="editor-label">
    <%: Html.LabelFor(model => model.FirstName) %>
</div>
<div class="editor-field">
    <%: Html.EditorFor(model => model.FirstName) %>
    <%: Html.ValidationMessageFor(model => model.FirstName) %>
</div>

<div class="editor-label">
    <%: Html.LabelFor(model => model.LastName) %>
</div>
<div class="editor-field">
    <%: Html.EditorFor(model => model.LastName) %>
    <%: Html.ValidationMessageFor(model => model.LastName) %>
</div>

<div class="editor-label">
    <%: Html.LabelFor(model => model.CreditCardNumber) %>
</div>
<div class="editor-field">
    <%: Html.EditorFor(model => model.CreditCardNumber) %>
    <%: Html.ValidationMessageFor(model => model.CreditCardNumber) %>
</div>