<%@ Page Title="" Language="C#" MasterPageFile="~/FarmMaster.Master" AutoEventWireup="true" CodeBehind="visualdata.aspx.cs" Inherits="FarmbrellaSite.visualdata" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <form id="form1" runat="server">
    <div style="width:750px;height:3000px; display:flex; align-content:center; margin:auto;">
        <asp:Literal ID="ltChart" runat="server"></asp:Literal>
    </div>
    </form>


</asp:Content>
