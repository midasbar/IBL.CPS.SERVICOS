<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IBL.CPS.UI.Models.EnderecoDTO>" %>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.UF) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.UF) %>
            <%: Html.ValidationMessageFor(model => model.UF) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.CIDADE) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.CIDADE) %>
            <%: Html.ValidationMessageFor(model => model.CIDADE) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.BAIRRO) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.BAIRRO) %>
            <%: Html.ValidationMessageFor(model => model.BAIRRO) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.ENDERECO) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.ENDERECO) %>
            <%: Html.ValidationMessageFor(model => model.ENDERECO) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.NUMERO) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.NUMERO) %>
            <%: Html.ValidationMessageFor(model => model.NUMERO) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.COMPLEMENTO) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.COMPLEMENTO) %>
            <%: Html.ValidationMessageFor(model => model.COMPLEMENTO) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.CEP) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.CEP) %>
            <%: Html.ValidationMessageFor(model => model.CEP) %>
        </div>