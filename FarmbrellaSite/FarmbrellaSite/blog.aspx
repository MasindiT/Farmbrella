 <%@ Page Title="" Language="C#" MasterPageFile="~/FarmMaster.Master" AutoEventWireup="true" CodeBehind="blog.aspx.cs" Inherits="FarmbrellaSite.blog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
    <div >
        <h1 style="text-align:center; font-size:4rem; color:#82ae46;">Underbrella</h1>
    </div>

    <section class="ftco-section ftco-degree-bg">
      <div class="container">
        <div class="row">
          <div class="col-lg-8 ftco-animate">
						<div class="row" id="post" runat="server">

						</div>
          </div> <!-- .col-md-8 -->
        </div>
      </div>
    </section> <!-- .section -->
</asp:Content>
