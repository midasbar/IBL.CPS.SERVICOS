<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Arcelor.CtrlCultura.UI.Models.RegisterModel>" %>

<asp:Content ID="registerTitle" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>
<asp:Content ID="registerContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container edit cadastro">
        <div id="menu_holder">
        </div>
        <h1>
            Criação de Conta de Acesso</h1>
        <p>
            Use o formulário abaixo para criar uma nova Conta de Acesso.
        </p>
        <p>
            Senhas devem ter no mínimo
            <%: Membership.MinRequiredPasswordLength %>
            caracteres.
        </p>
        <% using (Html.BeginForm())
           { %>
        <%: Html.ValidationSummary(true, "Erro ao criar Conta de Acesso. Favor verificar e tentar novamente.") %>
        <%: Html.ValidationMessage("")%>
        <div>
            <fieldset>
                <div class="editor-label">
                    <%: Html.LabelFor(m => m.UserName) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(m => m.UserName) %>
                    <%: Html.ValidationMessageFor(m => m.UserName) %>
                </div>
                <div class="editor-label">
                    <%: Html.LabelFor(m => m.Name) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(m => m.Name) %>
                    <%: Html.ValidationMessageFor(m => m.Name) %>
                </div>
                <div class="editor-label">
                    <%: Html.LabelFor(m => m.Email) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(m => m.Email) %>
                    <%: Html.ValidationMessageFor(m => m.Email) %>
                </div>
                <div class="editor-label">
                    <%: Html.LabelFor(m => m.Password) %>
                </div>
                <div class="editor-field">
                    <%: Html.PasswordFor(m => m.Password) %>
                    <%: Html.ValidationMessageFor(m => m.Password) %>
                </div>
                <div class="editor-label">
                    <%: Html.LabelFor(m => m.ConfirmPassword) %>
                </div>
                <div class="editor-field">
                    <%: Html.PasswordFor(m => m.ConfirmPassword) %>
                    <%: Html.ValidationMessageFor(m => m.ConfirmPassword) %>
                </div>
            </fieldset>
            <p>
                <input type="submit" value="Criar Conta de Acesso" class="botao bg_lnj" />
            </p>
        </div>
        <% } %>
    </div>
</asp:Content>
