<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IBL.CPS.UI.srTipoGrupo.TipoGrupoDTO>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Edit</h2>

<% using (Html.BeginForm()) { %>
    <%: Html.AntiForgeryToken() %>
    <%: Html.ValidationSummary(true) %>

    <fieldset>
        <legend>TipoGrupoDTO</legend>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.DESCRICAO) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.DESCRICAO) %>
            <%: Html.ValidationMessageFor(model => model.DESCRICAO) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.ID) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.ID) %>
            <%: Html.ValidationMessageFor(model => model.ID) %>
        </div>

        <p>
            <input type="submit" value="Save" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Back to List", "Index") %>
</div>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
    <%: Scripts.Render("~/bundles/jqueryval") %>
</asp:Content>
