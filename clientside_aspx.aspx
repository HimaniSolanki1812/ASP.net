<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="clientside_aspx.aspx.cs" Inherits="first_web.clientside_aspx" %>--%>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="clientside_aspx.aspx.cs" Inherits="first_web.clientside_aspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Client side state management in ASP.NET"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="1) View state Example"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtViewState" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblViewState" runat="server"></asp:Label>
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="Label3" runat="server" Text="2) HiddenField Example"></asp:Label>
        <br />
        <asp:HiddenField ID="HiddenField1" runat="server" Visible="False" />
        <br />
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Store Hidden Value" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblHidden" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="3) Cookies Example"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtcookie" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Create cookie" OnClick="Button3_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button7" runat="server" Text="Read Cookie " OnClick="Button7_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblCookie" runat="server"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="4)Query String Example"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtQueryString" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button5" runat="server" Text="Button" OnClick="Button5_Click" />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <div>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
