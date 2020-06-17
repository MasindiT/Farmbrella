<%@ Page Title="" Language="C#" MasterPageFile="~/FarmMaster.Master" AutoEventWireup="true" CodeBehind="editProduct.aspx.cs" Inherits="FarmbrellaSite.editProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="home">
        <div class="login">
    <h1 class="formTitle">Edit Product</h1>              
                <section>
                    <form method="post" action="#" runat="server" class="fields">
                        <div class="fields">
                            <div class="field">
                                <input type="text"  class="inputField" id="pname" placeholder="Product Name" runat="server" />
                            </div>
                            
                            <div class="field">
                                <input type="text"  class="inputField" id="description" placeholder="Description" runat="server" />
                            </div>
                           
                            <div class="field">
                                <input type="text" class="inputField" id="price" placeholder="Price" runat="server" />
                            </div>
                           
                            <div class="field">
                                <input type="number"  class="inputField" id="qty" placeholder="Quantity" runat="server" />
                            </div>
                            
                            <div class="field">
                                <input type="text"  class="inputField" id="img" placeholder="Image URL" runat="server" />
                            </div>
                           
                            <div class="field">
                                <select class="inputField" id="ptype" runat="server">
                                <option>Select Product Type</option>
                             <option value="1">Fruit</option>
                            <option value="0">Veges</option>
                            </select>
                            </div>

                        </div>
                        <asp:Button type="submit" id="BtnSend" class="btn btn-primary py-3 px-4" Text="Submit" runat="server" OnClick="BtnSend_Click"/>
                    </form>
                </section>
            </div>
        </div>
</asp:Content>
