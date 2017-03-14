<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AddEditCategory.aspx.cs" Inherits="ShoppingHeart.Admin.AddEditCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <h4> ADD NEW CATEGORY</h4>
        <hr />

    </div>
    <table style="width:100%; background-color:#FFFFFF;">
        <tr>
            <td style="width:46%; padding-left:100px;align-self: auto">
                Category Name:: 
            </td>
            <td style="width:50%">
                <asp:TextBox ID="txtCategoryName" runat="server" Width="183px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width:46%; padding-left:100px;align-self: auto">
                &nbsp;
            </td>
            <td style="width:50%";align="left">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                
            </td>
        </tr>
        <tr>
            <td style="width:46%; padding-left:100px;">
                &nbsp;
                </td>
            <td style="width:46%; padding-left:100px;">
                &nbsp;
                </td>

        </tr>
       
    </table>


</asp:Content>
