<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<IBL.CPS.UI.srFuncao.FuncaoDTO>>" %>

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
        <th>
            <%: Html.DisplayNameFor(model => model.DESCRICAO) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.ID) %>
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.DESCRICAO) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.ID) %>
        </td>
        <td>
            <%: Html.ActionLink("Edit", "Edit", new {  id=item.ID }) %> |
            <%: Html.ActionLink("Details", "Details", new {  id=item.ID }) %> |
            <%: Html.ActionLink("Delete", "Delete", new {  id=item.ID }) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
