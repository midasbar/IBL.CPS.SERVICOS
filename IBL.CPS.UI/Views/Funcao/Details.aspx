<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IBL.CPS.UI.srFuncao.FuncaoDTO>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Details</h2>

<fieldset>
    <legend>FuncaoDTO</legend>

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
<p>
    <%: Html.ActionLink("Edit", "Edit", new { id = Model.ID })%> |
    <%: Html.ActionLink("Back to List", "Index") %>
</p>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
