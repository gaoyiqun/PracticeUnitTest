<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="CalculatePostCost.WebForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <fieldset>
            <legend>ItemInformation</legend>
            <table style="width: 100%;">
                <tr>
                    <td>
                        ItemName
                    </td>
                    <td>
                        <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please Enter"
                            ControlToValidate="txtProductName"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        Weight
                    </td>
                    <td>
                        <asp:TextBox ID="txtProductWeight" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please Enter"
                            ControlToValidate="txtProductWeight"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        Length
                    </td>
                    <td>
                        <asp:TextBox ID="txtProductLength" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please Enter"
                            ControlToValidate="txtProductLength"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        Width
                    </td>
                    <td>
                        <asp:TextBox ID="txtProductWidth" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please Enter"
                            ControlToValidate="txtProductWidth"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        Height
                    </td>
                    <td>
                        <asp:TextBox ID="txtProductHeight" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Please Enter"
                            ControlToValidate="txtProductHeight"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        Does it need cool storage?
                    </td>
                    <td>
                        <asp:RadioButtonList ID="rdoNeedCool" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="1">Yes</asp:ListItem>
                            <asp:ListItem Value="0">No</asp:ListItem>
                        </asp:RadioButtonList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="請輸入是否需低溫冷藏" ControlToValidate="rdoNeedCool"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        Logistic Carriers
                    </td>
                    <td>
                        <asp:DropDownList ID="drpCompany" runat="server">
                            <asp:ListItem>Please choose</asp:ListItem>
                            <asp:ListItem Value="1">BlackCat</asp:ListItem>
                            <asp:ListItem Value="2">Hsinchu</asp:ListItem>
                            <asp:ListItem Value="3">PostOffice</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="drpCompany"
                            InitialValue="Please choose" runat="server" ErrorMessage="Please choose Carriers"></asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
            <asp:Button ID="btnCalculate" runat="server" Text="CalculateCost" 
                onclick="btnCalculate_Click" />
        </fieldset>
    </div>
    <div>
        <fieldset>
            <legend>Result</legend>LogisticCarrier<asp:Label ID="lblCompany" runat="server"></asp:Label>
            <br />
            Cost<asp:Label ID="lblCharge" runat="server"></asp:Label>
        </fieldset>
    </div>
</asp:Content>