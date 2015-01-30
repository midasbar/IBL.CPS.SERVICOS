<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IBL.CPS.UI.Models.LogInModel>" %>

<asp:Content ID="loginTitle" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>
<asp:Content ID="loginContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container edit cadastro">
        <div id="menu_holder">
        </div>
        <h1>
            Acesso ao Sistema</h1>
        <p>
            Por favor informe seu Usuário de Rede e Senha.
            
            
        </p>
        <% using (Html.BeginForm())
           { %>
        <%: Html.ValidationSummary(true, "Erro ao acessar o Sistema. Favor verificar e tentar novamente.")%>
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
                    <%: Html.LabelFor(m => m.Password) %>
                </div>
                <div class="editor-field">
                    <%: Html.PasswordFor(m => m.Password) %>
                    <%: Html.ValidationMessageFor(m => m.Password) %>
                </div>
            </fieldset>
            <div class="editor-label">
                <%: Html.CheckBoxFor(m => m.RememberMe) %>
                <%: Html.LabelFor(m => m.RememberMe) %>
            </div>
            <p>
                <input type="submit" value="Acessar" class="botao bg_lnj" />
            </p>
        </div>
        <% } %>
    </div>
</asp:Content>
