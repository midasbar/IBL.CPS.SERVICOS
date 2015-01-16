<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Externo.Master" Inherits="System.Web.Mvc.ViewPage<Arcelor.CtrlCultura.UI.Models.ChangePasswordModel>" %>

<asp:Content ID="changePasswordTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Alteração de Senha de Acesso
</asp:Content>
<asp:Content ID="changePasswordContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container edit cadastro">
        <div id="menu_holder">
        </div>
        <h2>
            Alteração de Senha de Acesso</h2>
        <p>
            Use o formulário abaixo para alterar sua Senha de Acesso.
        </p>
        <p>
            Senhas devem ter no mínimo
            <%: Membership.MinRequiredPasswordLength %>
            caracteres.
        </p>
        <% using (Html.BeginForm())
           { %>
        <%: Html.ValidationSummary(true, "Erro ao alterar Senha de Acesso. Favor verificar e tentar novamente.")%>
        <div>
            <fieldset>
                <legend></legend>
                <div class="editor-label">
                    <%: Html.LabelFor(m => m.OldPassword) %>
                </div>
                <div class="editor-field">
                    <%: Html.PasswordFor(m => m.OldPassword) %>
                    <%: Html.ValidationMessageFor(m => m.OldPassword) %>
                </div>
                <div class="editor-label">
                    <%: Html.LabelFor(m => m.NewPassword) %>
                </div>
                <div class="editor-field">
                    <%: Html.PasswordFor(m => m.NewPassword) %>
                    <%: Html.ValidationMessageFor(m => m.NewPassword) %>
                </div>
                <div class="editor-label">
                    <%: Html.LabelFor(m => m.ConfirmPassword) %>
                </div>
                <div class="editor-field">
                    <%: Html.PasswordFor(m => m.ConfirmPassword) %>
                    <%: Html.ValidationMessageFor(m => m.ConfirmPassword) %>
                </div>
                <p>
                    <input type="submit" value="Alterar Senha de Acesso" class="botao bg_lnj" />
                </p>
            </fieldset>
        </div>
        <% } %>
    </div>
</asp:Content>
