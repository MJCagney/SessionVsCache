<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Caching.aspx.cs" Inherits="SessionVsCache.Caching" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<form id="form1" runat="server">  
    <div>  
    <div>  
            <h2 style="margin-left: 40px"><strong> Login Form</strong></h2>  
            <table>  
                <tr>  
                    <td>  
                        UserName: </td>  
                    <td>  
                        <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>  
                    </td>  
                </tr>  
                <tr>  
                    <td>  
                        Password:  
                    </td>  
                    <td>  
                        <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>  
                    </td>  
                </tr>  
                <tr>  
                    <td colspan="2" style="text-align:center">  
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                    </td>  
                </tr>  
            </table>  
        </div>  
    </div>  
    </form> 
</body>
</html>
