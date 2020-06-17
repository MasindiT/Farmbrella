<%@ Page Title="" Language="C#" MasterPageFile="~/FarmMaster.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="FarmbrellaSite.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="home-section" class="hero">
		  <div class="home-slider owl-carousel">
	      <div class="slider-item" style="background-image: url(images/bg_1.jpg);">
	      	<div class="overlay"></div>
	        <div class="container">
	          <div class="row slider-text justify-content-center align-items-center" data-scrollax-parent="true">

	            <div class="col-md-12 ftco-animate text-center">
	              <h1 class="mb-2">We serve Fresh Vegestables &amp; Fruits</h1>
	              <h2 class="subheading mb-4">We deliver organic vegetables &amp; fruits</h2>
	              <p><a href="shop.aspx" class="btn btn-primary">Visit Shop</a></p>
	            </div>

	          </div>
	        </div>
	      </div>
		<div class="slider-item" style="background-image: url(images/image_5.jpg);">
	      	<div class="overlay"></div>
	        <div class="container">
	          <div class="row slider-text justify-content-center align-items-center" data-scrollax-parent="true">

	            <div class="col-sm-12 ftco-animate text-center">
	              <h1 class="mb-2">100% Fresh &amp; Organic Foods</h1>
	              <h2 class="subheading mb-4">Farmed by real People</h2>
	              <p><a href="shop.aspx" class="btn btn-primary">See Shop...</a></p>
	            </div>

	          </div>
	        </div>
	      </div>


	      <div class="slider-item" style="background-image: url(images/bg_2.jpg);">
	      	<div class="overlay"></div>
	        <div class="container">
	          <div class="row slider-text justify-content-center align-items-center" data-scrollax-parent="true">

	            <div class="col-sm-12 ftco-animate text-center">
	              <h1 class="mb-2">100% Fresh &amp; Organic Foods</h1>
	              <h2 class="subheading mb-4">We deliver organic vegetables &amp; fruits</h2>
	              <p><a href="about.aspx" class="btn btn-primary">Learn More</a></p>
	            </div>

	          </div>
	        </div>
	      </div>
	    </div>
    </section>

    <section class="ftco-section">
			<div class="container">
				<div class="row no-gutters ftco-services">
          <div class="col-md-3 text-center d-flex align-self-stretch ftco-animate">
            <div class="media block-6 services mb-md-0 mb-4">
              <div class="icon bg-color-1 active d-flex justify-content-center align-items-center mb-2">
            		<span class="flaticon-shipped"></span>
              </div>
              <div class="media-body">
                <h3 class="heading">Free Delivery</h3>
                <span id="freeDelivery" runat="server"></span>
              </div>
            </div>      
          </div>
          <div class="col-md-3 text-center d-flex align-self-stretch ftco-animate">
            <div class="media block-6 services mb-md-0 mb-4">
              <div class="icon bg-color-2 d-flex justify-content-center align-items-center mb-2">
            		<span class="flaticon-diet"></span>
              </div>
              <div class="media-body">
                <h3 class="heading">Always Fresh</h3>
                <span>Product well package</span>
              </div>
            </div>    
          </div>
          <div class="col-md-3 text-center d-flex align-self-stretch ftco-animate">
            <div class="media block-6 services mb-md-0 mb-4">
              <div class="icon bg-color-3 d-flex justify-content-center align-items-center mb-2">
            		<span class="flaticon-award"></span>
              </div>
              <div class="media-body">
                <h3 class="heading">Superior Quality</h3>
                <span>Quality Products</span>
              </div>
            </div>      
          </div>
          <div class="col-md-3 text-center d-flex align-self-stretch ftco-animate">
            <div class="media block-6 services mb-md-0 mb-4">
              <div class="icon bg-color-4 d-flex justify-content-center align-items-center mb-2">
            		<span class="flaticon-customer-service"></span>
              </div>
              <div class="media-body">
                <h3 class="heading">Support</h3>
                <span>24/7 Support</span>
              </div>
            </div>      
          </div>
        </div>
			</div>
		</section>

		
		<section class="ftco-section img" style="background-image: url(images/bg_3.jpg);">
    	<div class="container">
		<div class="row justify-content-end">
          <div class="col-md-6 heading-section ftco-animate deal-of-the-day ftco-animate">
          	<span class="subheading">Best Prices For Your Wallet</span>
            <h2 class="mb-4">Value for your Body</h2>
            <p><span class="price">Great deals with different purchase values, Visit our <a href="shop.aspx">Shop Now!</a></span></p>
            <p><span class="price">R300 or more = Free Delivery</span></p>
			<p><span class="price">R700 or more = Discount Coupon for Next Purchase</span></p>
          </div>
        </div>   		
    	</div>
    </section>

    <section class="ftco-section testimony-section">
      <div class="container">
        <div class="row ftco-animate">
          <div class="col-md-12">
            <div class="carousel-testimony owl-carousel"> 
              <div class="item">
                <div class="testimony-wrap p-4 pb-5">
                  <div class="user-img mb-5" style="background-image: url(images/tify.jpg)">
                    
                  </div>
                  <div class="text text-center">
                    <p class="mb-5 pl-4 line">BscIT Computer Science &amp Informatics</p>
                    <p class="name">Thifhelimbilu Masindi</p>
                    <span class="position">Developer</span>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>

</asp:Content>
