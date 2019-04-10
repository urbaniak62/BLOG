<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Connection.aspx.cs" Inherits="Connection" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<div>
            <asp:Label ID="Label1" runat="server" Text="Login"></asp:Label>
        <asp:TextBox ID="txtb_Login" onblur="verifier('txtb_Login','LB_message','email','btn_Submit')" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="mdp"></asp:Label>
            <asp:TextBox ID="txtb_mdp"   onblur="verifier('txtb_mdp','LB_message','password','btn_Submit')" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="btn_Submit" runat="server" OnClick="btn_Submit_Click" Text="submit" Enabled="false" />
            <asp:CheckBox ID="CB_Remember" runat="server" />
            <asp:Label ID="Label3" runat="server" Text="Se souvenir de moi"></asp:Label>
        <asp:Label ID="LB_message" runat="server"></asp:Label>
 </div>
</asp:Content>

