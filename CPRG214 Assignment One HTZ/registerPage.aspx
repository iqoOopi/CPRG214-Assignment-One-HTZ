<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="registerPage.aspx.cs" Inherits="CPRG214_Assignment_One_HTZ.registerPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">
     <table>
                <tr>
                    <td style="width:150px">First Name:</td>
                    <td style="width:250px">
            <asp:TextBox ID="uxFirstName" runat="server" Height="16px" Width="220px"></asp:TextBox></td>

                </tr>
                <tr>
                    <td>Last Name:</td>
                    <td>
                        <asp:TextBox ID="uxLastName" runat="server" Width="220px"></asp:TextBox>
                    </td>
                </tr>
               
                <tr>
                    <td colspan="2" style="text-align: center" >
            <asp:Button ID="uxOK" runat="server" Text="OK" Width="77px" OnClick="uxOK_Click" />
                    </td>                    
                </tr>
            </table>
</asp:Content>
