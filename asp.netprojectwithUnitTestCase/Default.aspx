<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="asp.netprojectwithUnitTestCase._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
       <asp:label id="lbldummy" runat="server" Text="Dummy label" ></asp:label>
       
      
   </div>

   <div>
       <asp:label id="lblfirstnumber" runat="server" Text="FirstNumber" ></asp:label>
       <asp:TextBox type="textbox" id="txtfirstNumber" runat="server" />
      
   </div>
      <div>
       <asp:label id="lblsecondNumber" runat="server" Text="SecondNumber" ></asp:label>
       <asp:TextBox type="textbox" id="txtsecondNumber" runat="server" />
      
   </div>
    <div>
        <asp:Button ID="btnadd" runat="server" Text="ADD" OnClick="btn_Add" />
    </div>

    <div>
        <asp:Label ID="lblvalue" runat="server" ></asp:Label>
    </div>

</asp:Content>
