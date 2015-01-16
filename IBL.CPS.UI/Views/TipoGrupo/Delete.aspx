<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IBL.CPS.UI.srTipoGrupo.TipoGrupoDTO>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<fieldset>
    <legend>TipoGrupoDTO</legend>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.DESCRICAO) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.DESCRICAO) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.ID) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.ID) %>
    </div>
</fieldset>
<% using (Html.BeginForm()) { %>
    <%: Html.AntiForgeryToken() %>
    <p>
        <input type="submit" value="Delete" /> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>
<% } %>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
