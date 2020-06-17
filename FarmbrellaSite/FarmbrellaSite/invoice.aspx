<%@ Page Title="" Language="C#" MasterPageFile="~/FarmMaster.Master" AutoEventWireup="true" CodeBehind="invoice.aspx.cs" Inherits="FarmbrellaSite.invoice" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .theTable {
          font-family: "Trebuchet MS", Arial, Helvetica, sans-serif;
          border-collapse: collapse;
          width: 100%;
        }

        .theTable td, #theTable th {
          border: 1px solid #ddd;
          padding: 8px;
          text-align:center;
          text-transform:capitalize;
        }

        .theTable tr:nth-child(even){background-color: #f2f2f2;}

        .theTable tr:hover {background-color: #ddd;}

        .theTable th {
          padding-top: 12px;
          padding-bottom: 12px;
          text-align: left;
          background-color: #4CAF50;
          color: white;
          text-align:center;
          text-transform:capitalize;
          font-weight: bold;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="padding: 5px 5rem 5px 5rem; width:100vw">
        <div id="inv" runat="server"></div>

        <div style="display:flex; align-items:center; justify-content:center; margin:auto;">
            <form runat="server" style="margin: 0 2rem;">
            <asp:Button ID="downloadBtn" class="btn btn-primary py-3 px-4" runat="server" Text="Download invoice" OnClick="downloadBtn_Click" />
        </form>
        </div>
    </div>
</asp:Content>
