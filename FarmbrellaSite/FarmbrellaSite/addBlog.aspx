<%@ Page Title="" Language="C#" MasterPageFile="~/FarmMaster.Master" AutoEventWireup="true" CodeBehind="addBlog.aspx.cs" Inherits="FarmbrellaSite.addBlog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div >
        <h1 style="text-align:center; font-size:5rem; color:#82ae46;">Add To Underbrella</h1>
    </div>
	<div class="home">
		<div class="login">
				<section>
                    <form method="post" action="#" runat="server" class="fields">
                        <div class="fields">
                            <div class="field">
                                <input type="text"  class="inputField" id="subject" placeholder="Blog Subject" runat="server" />
                            </div>
                            
                            <div class="field">
                                <input type="text"  class="inputField" id="publisher" placeholder="Publisher Name" runat="server" />
                            </div>
                           
                            <div class="field">
                                <input type="text" class="inputField" id="content" placeholder="Blog Content" runat="server" />
                            </div>
                           
                            <div class="field">
                                <input type="text"  class="inputField" id="image" placeholder="Image URL" runat="server" />
                            </div>
                            
                            <div class="field">
                                Select Publishing Date: <input type="date" id="date" runat="server">
                            </div>
                       </div>
                        <asp:Button type="submit" id="BtnSend" class="btn btn-primary py-3 px-4" Text="Submit" runat="server" OnClick="BtnSend_Click"/>
                    </form>
                </section>
			</div>
		</div>

</asp:Content>
