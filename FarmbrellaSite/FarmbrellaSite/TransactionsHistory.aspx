<%@ Page Title="" Language="C#" MasterPageFile="~/FarmMaster.Master" AutoEventWireup="true" CodeBehind="TransactionsHistory.aspx.cs" Inherits="FarmbrellaSite.TransactionsHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
      #theTable {
      font-family: "Trebuchet MS", Arial, Helvetica, sans-serif;
      border-collapse: collapse;
      width: 100%;
        }

        #theTable td, #theTable th {
          border: 1px solid #ddd;
          padding: 8px;
          text-align:center;
          text-transform:capitalize;
        }

        #theTable tr:nth-child(even){background-color: #f2f2f2;}

        #theTable tr:hover {background-color: #ddd;}

        #theTable th {
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

    <h1 style="text-align:center">Transaction History</h1>
    <table id="theTable">
        <tbody id="history" runat="server">

        </tbody>
     </table>
</asp:Content>
