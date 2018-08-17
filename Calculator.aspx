<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="HelloWorld.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            First Number: <asp:TextBox ID="txtFirst" runat="server"></asp:TextBox><br />
            <br />
        </div>
        <div>
            Second Number: <asp:TextBox ID="txtSecond" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
        <br /><br />

        The answer is: <asp:Label ID="lblAnswer" runat="server"></asp:Label>
    </form>
</body>
</html>
