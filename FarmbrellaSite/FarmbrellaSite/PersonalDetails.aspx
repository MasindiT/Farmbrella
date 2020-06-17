<%@ Page Title="" Language="C#" MasterPageFile="~/FarmMaster.Master" AutoEventWireup="true" CodeBehind="PersonalDetails.aspx.cs" Inherits="FarmbrellaSite.profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="home">
        <div class="login">
                    
                <h1 class="formTitle">Personal Details</h1>
                
                <section>
                    <form runat="server" class="fields">
                        <div class="fields">
                            <div class="field">
                                <input type="text" name="txttitle" class="inputField" id="title" runat="server" />
                            </div>
                            <div class="field">
                                <input type="text" name="txtname" class="inputField" id="name" runat="server" />
                            </div>
                            <div class="field">
                                <input type="text" name="txtsurname" class="inputField" id="surname" runat="server" />
                            </div>
                            <div class="field">
                                <input type="email" name="txtemail" class="inputField" id="email" placeholder="E-Mail" runat="server" readonly="readonly"/>
                            </div>

                            <div class="field">
                                <input type="password" name="txtpass" class="inputField" id="password" placeholder=" Change Password" runat="server" />
                            </div>
                            <div class="field">
                                <input type="password" name="txtconfirm" class="inputField" id="passConfirm" placeholder="Confirm New Password" runat="server" />
                            </div>
                            
                        </div>
                        <asp:Button type="submit" id="BtnSend" class="btn btn-primary" Text="Update" runat="server" OnClick="BtnSend_Click"/>
                    </form>
                </section>
            </div>
    </div>
</asp:Content>
