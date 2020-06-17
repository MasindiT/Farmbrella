<%@ Page Title="" Language="C#" MasterPageFile="~/FarmMaster.Master" AutoEventWireup="true" CodeBehind="fruit.aspx.cs" Inherits="FarmbrellaSite.fruit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     
     <section class="ftco-section">
    	<div class="container">
    		<div class="row justify-content-center">
    			<div class="col-md-10 mb-5 text-center">
    				<ul class="product-category">
    					<li><a href="shop.aspx">All</a></li>
    					<li><a href="vegetable.aspx">Vegetables</a></li>
    					<li><a href="#" class="active">Fruits</a></li>
    				</ul>
    			</div>
    		</div>
    		<div class="row" id="catalogue" runat="server">
    			<!-- products here -->
    			
    		</div>
    	
    	</div>
    </section>

</asp:Content>
