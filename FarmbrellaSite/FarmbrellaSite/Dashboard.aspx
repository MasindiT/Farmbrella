<%@ Page Title="" Language="C#" MasterPageFile="~/FarmMaster.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="FarmbrellaSite.Dashboard" %>
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

   <script>
       function today() {
           let today = new Date().toISOString().substring(0, 10);
           document.querySelector('#inDate').value = today;

       }
   </script>

    <div>
        <div class="card-body">
                <h3 style="text-align:center;" class="box-title">Number of user registered</h3>
        </div>
        <form runat="server">

            <table class="theTable">

                <thead>
                    <tr>
                        <th>Date</th>
                        <th>Find Users</th>
                        <th>Number of User</th>
                    </tr>
                </thead>
                <tbody id="Tbody1" runat="server">
                    <tr>
                                
                        <td>
                            <input type="date" id="inDate" value="2019-10-16" runat="server"/>
                            </td>
                        <td>
                                    
                                <asp:Button ID="getUsers" runat="server" class="btn btn-primary py-3 px-4" Text="Get Registered users" OnClick="getUsers_Click"/>
                                    
                        </td>
                                
                        <td><span id="numUsers" runat="server"></span></td>
                    </tr>
                </tbody>
            </table>
        </form>
    </div>
    <hr />
    <div>
        <div class="card-body">
                <h3 style="text-align:center;" class="box-title">Product Inventory</h3>
        </div>
        <table class="theTable">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Name</th>
                    <th>Quantity</th>
                    <th>Delete Product</th>
                </tr>
            </thead>
            <tbody id="productTable" runat="server">
                            
            </tbody>
        </table>
    </div>
    
</asp:Content>
