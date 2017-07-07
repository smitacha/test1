<%@ Page Language="C#" AutoEventWireup="true" CodeFile="User.aspx.cs" Inherits="User" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td><asp:Label runat="server" >Name</asp:Label></td>
                <td><asp:TextBox runat="server" ID="txtName"></asp:TextBox></td>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtName" ErrorMessage="Please Provide Name"> </asp:RequiredFieldValidator>
                <%--<asp:RangeValidator runat="server" ControlToValidate="txtName" ></asp:RangeValidator>--%>
            </tr>
            <tr>
                <td><asp:Label runat="server" >Mobile No</asp:Label></td>
                <td><asp:TextBox runat="server" ID="txtMob"></asp:TextBox></td>
                <%-- <asp:RequiredFieldValidator runat="server" ControlToValidate="txtMob" ErrorMessage="Please Provide Mobile No"> </asp:RequiredFieldValidator>--%>
                <asp:RangeValidator ControlToValidate="txtMob" runat="server" ></asp:RangeValidator>
            </tr>
            <tr>
                <td><asp:Label runat="server" >Join Date</asp:Label></td>
                <td><asp:TextBox ID="txtDate" runat="server"></asp:TextBox></td>
                <%--<asp:RequiredFieldValidator runat="server" ControlToValidate="txtDate" ErrorMessage="Please Provide Join Date"> </asp:RequiredFieldValidator>--%>
            </tr>

             <tr>
                <td><asp:Label runat="server" >Country</asp:Label></td>
                <td>
                    <asp:DropDownList ID="ddlCountry" runat="server" OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                 
            </tr>
            
              <tr>
                <td><asp:Label runat="server" >State</asp:Label></td>
                <td>
                    <asp:DropDownList ID="ddlState" runat="server">
                    </asp:DropDownList>
                </td>
                 
            </tr>


            <tr>
                <td><asp:Label runat="server" >City</asp:Label></td>
                <td>
                    <asp:DropDownList ID="ddlCity" runat="server">
                    </asp:DropDownList>
                </td>
                <%-- <asp:RequiredFieldValidator runat="server" ControlToValidate="ddlCity" ErrorMessage="Please Provide City"> </asp:RequiredFieldValidator>--%>
            </tr>
             <tr>
                <td colspan="2"><asp:Button runat="server" text="Save" ForeColor="#0066ff" OnClick="Unnamed11_Click"/></td>
                 
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server"  ForeColor="#0066ff"  Text="Save Tarun" OnClick="Button1_Click" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
    
</body>
</html>
