<%@ Page Language="C#"  MasterPageFile="~/Masters/GlobalMaster.Master" AutoEventWireup="true" CodeBehind="BasketPage.aspx.cs" Inherits="VasiliyCarsSyte.BasketPage" %>

<asp:Content ID="PageContent" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
<div style="border: 5px outset #BCBCBC; float: left; overflow:auto; background-color:White;">
        <table>
            <tr>
                          <td align="center" colspan="2" style="font-weight: bold; color: white; background-color: Black; " >
                                  Your data delivery</td>
                            </tr>
                            <tr>
                              <td>
                              Name
                              </td>
                              <td>
                               <asp:TextBox ID="TextBoxName" ValidationGroup="CreateUserWizard1" runat="server"></asp:TextBox>
                           <asp:RequiredFieldValidator ID="NameValidator" runat="server" ControlToValidate="TextBoxName"
                                    ErrorMessage="*" ToolTip="" ForeColor="Red"  ValidationGroup="bay"
                                  >*</asp:RequiredFieldValidator>
                              </td>
                            </tr>
                            <tr>
                              <td>
                              Surname
                              </td>
                              <td>
                                  <asp:TextBox ID="TextBoxSurname" runat="server"></asp:TextBox>
                                   <asp:RequiredFieldValidator ID="RequiredFieldValidatorSurname" runat="server" ControlToValidate="TextBoxSurname"
                                    ErrorMessage="*" ToolTip="" ForeColor="Red"  ValidationGroup="bay"
                                   >*</asp:RequiredFieldValidator>
                              </td>
                            </tr>
                            <tr>
                              <td>
                              Address
                              </td>
                              <td>
                               <asp:TextBox ID="TextBoxAddress" runat="server"></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidatorAddress" runat="server" ControlToValidate="TextBoxAddress"
                                    ErrorMessage="*" ToolTip="" ForeColor="Red" ValidationGroup="bay"
                                    >*</asp:RequiredFieldValidator>
                              </td>
                            </tr>
                            <tr>
                              <td>
                              Phone
                              </td>
                              <td>
                               <asp:TextBox ID="TextBoxPhone" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorPhone" runat="server" ControlToValidate="TextBoxPhone"
                                    ErrorMessage="*" ToolTip="" ForeColor="Red"  ValidationGroup="bay"
                                   >*</asp:RequiredFieldValidator>

                              </td>
                            </tr>
                            <tr>
                                <td>
                                </td>
                                <td>                   
                                         <asp:RegularExpressionValidator ID="RegularExpressionValidatorPhone" runat="server" ControlToValidate="TextBoxPhone"
                                                ForeColor="Red" ErrorMessage="11 numbers only"  ValidationExpression="^\d{11}$" ValidationGroup="bay">
                                           </asp:RegularExpressionValidator>
                               </td>

                         </tr>
                   </table>

    <asp:Button ID="ButtonBay" style=" float:right" runat="server" 
            Text="Bay" ValidationGroup="bay" onclick="ButtonBay_Click"  />
</div >
   <div style="float:left" class="CarDiv"  >
 <asp:PlaceHolder ID="PlaceHolderCar" runat="server">  </asp:PlaceHolder>
      </div>
</asp:Content>