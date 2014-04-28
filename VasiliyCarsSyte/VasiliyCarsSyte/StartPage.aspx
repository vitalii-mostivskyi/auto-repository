<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Masters/GlobalMaster.Master" CodeBehind="StartPage.aspx.cs" Inherits="VasiliyCarsSyte.StartPage" %>


<asp:Content ID="PageContent" ContentPlaceHolderID="MainContentPlaceHolder" runat="server"> 
<div style = "width:1000px;" >
  <div class="navigation">
     <asp:TreeView ID="TreeViewCaregoryStart" runat="server">
        </asp:TreeView>

        

  </div>
  <div class="AllCarDiv">
        <asp:PlaceHolder ID="PlaceHolderCars" runat="server">

        </asp:PlaceHolder>
   </div>
     
</div>
</asp:Content>

