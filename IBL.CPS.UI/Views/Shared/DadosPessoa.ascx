<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IBL.CPS.UI.srPessoa.PessoaDTO>" %>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.IDPESSOA) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.IDPESSOA) %>
            <%: Html.ValidationMessageFor(model => model.IDPESSOA) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.SEXO) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.SEXO) %>
            <%: Html.ValidationMessageFor(model => model.SEXO) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.NOME) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.NOME) %>
            <%: Html.ValidationMessageFor(model => model.NOME) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.DATANASC) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.DATANASC) %>
            <%: Html.ValidationMessageFor(model => model.DATANASC) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.RG) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.RG) %>
            <%: Html.ValidationMessageFor(model => model.RG) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.CPF) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.CPF) %>
            <%: Html.ValidationMessageFor(model => model.CPF) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.TELEFONE_FIXO) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.TELEFONE_FIXO) %>
            <%: Html.ValidationMessageFor(model => model.TELEFONE_FIXO) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.CELULAR) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.CELULAR) %>
            <%: Html.ValidationMessageFor(model => model.CELULAR) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.E_MAIL) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.E_MAIL) %>
            <%: Html.ValidationMessageFor(model => model.E_MAIL) %>
        </div>