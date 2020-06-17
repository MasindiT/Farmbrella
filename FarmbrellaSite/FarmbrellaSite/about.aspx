<%@ Page Title="" Language="C#" MasterPageFile="~/FarmMaster.Master" AutoEventWireup="true" CodeBehind="about.aspx.cs" Inherits="FarmbrellaSite.about" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div >
        <h1 style="text-align:center; font-size:5rem; color:#82ae46;">About Us</h1>
    </div>

    <section class="ftco-section ftco-no-pb ftco-no-pt bg-light">
			<div class="container">
				<div class="row">
					<div class="col-md-5 p-md-5 img img-2 d-flex justify-content-center align-items-center" style="background-image: url(img/about2.jpg);">
						<a href="https://www.youtube.com/watch?v=WhOrIUlrnPo" class="icon popup-vimeo d-flex justify-content-center align-items-center">
							<span class="icon-play"></span>
						</a>
					</div>
					<div class="col-md-7 py-5 wrap-about pb-md-5 ftco-animate">
	          <div class="heading-section-bold mb-4 mt-md-5">
	          	<div class="ml-md-0">
		            <h2 class="mb-4">Welcome to FarmBrella where Your Organic Food Lives</h2>
	            </div>
	          </div>
	          <div class="pb-md-5">
	          	<p>Eating is part of the daily chores or at least has become one. We live in the 21st century and selecting food to eat should not be part of your daily schedule. With Farmbrella we take away the stress of unbalanced diet and organically modified food. We have one job and one job only; that is to bring real farmed food to your door step.</p>
							<p>And I am sure you wondering how is that possible huh?</p>
                            <p>Easy as peeling... We taking it back to long long time ago like 1000 years back. Remember when our forefathers would harvest and go door to door to sell/deliver crop? Yes that far away with a twist of E-Commerce. We have teamed up with various small scaled organic farmers to supply us
                                with fruits & veges to sell to you directly without involving the big guys. Every week you will get a chance to order freshly harvested produce of the week straight from our site. You select all products you want and we will deliver to your doorstep for a small fee or even at times for free.
                                Do not be shy please try us out...
                            </p>
							<p><a href="shop.aspx" class="btn btn-primary">Shop now</a></p>
						</div>
					</div>
				</div>
			</div>
		</section>

		<section class="ftco-section ftco-no-pt ftco-no-pb py-5 bg-light">
      <div class="container py-4">
        <div class="row d-flex justify-content-center py-5">
          <div class="col-md-6">
          	<h2 style="font-size: 22px;" class="mb-0">Subcribe to our Newsletter</h2>
          	<span>Get e-mail updates about our latest fresh produce</span>
          </div>
          <div class="col-md-6 d-flex align-items-center">
            <form action="#" class="subscribe-form" runat="server">
              <div class="form-group d-flex">
                <input type="text"  id="emailInput" runat="server" class="form-control" placeholder="Enter email address">
                  <asp:Button ID="SubscribeBtn" runat="server" Text="Subscribe"  class="submit px-3" OnClick="SubcribeBtn_Click" />
              </div>
            </form>
          </div>
        </div>
      </div>
            <div id="divId" runat="server" style ="display:flex; align-items:center; margin:auto;justify-content:center;">


            </div>
    </section>
		
		
		
		<section class="ftco-section testimony-section">
      <div class="container">
        <div class="row ftco-animate">
          <div class="col-md-12">
            <div class="carousel-testimony owl-carousel">
              <div class="item">
                <div class="testimony-wrap p-4 pb-5">
                  <div class="user-img mb-5" style="background-image: url(images/vic.jpg)">             
                  </div>
                  <div class="text text-center">
                    <p class="mb-5 pl-4 line">BscIT Computer Science &amp Informatics Second Year Student</p>
                    <p class="name">Mxolisi Montwedi</p>
                    <span class="position">QA Engineer</span>
                  </div>
                </div>
              </div>
              <div class="item">
                <div class="testimony-wrap p-4 pb-5">
                  <div class="user-img mb-5" style="background-image: url(images/andy.jpg)">
                    
                  </div>
                  <div class="text text-center">
                    <p class="mb-5 pl-4 line">BscIT Computer Science &amp Informatics Second Year Student</p>
                    <p class="name">Andile Getyengana</p>
                    <span class="position">Architect &amp; Developer</span>
                  </div>
                </div>
              </div>
              <div class="item">
                <div class="testimony-wrap p-4 pb-5">
                  <div class="user-img mb-5" style="background-image: url(images/kat.jpg)">
                    
                  </div>
                  <div class="text text-center">
                    <p class="mb-5 pl-4 line">BscIT Computer Science &amp Informatics Second Year Student</p>
                    <p class="name">Katlego Ralehlaka</p>
                    <span class="position">UI Designer</span>
                  </div>
                </div>
              </div>
              <div class="item">
                <div class="testimony-wrap p-4 pb-5">
                  <div class="user-img mb-5" style="background-image: url(images/tify.jpg)">
                    
                  </div>
                  <div class="text text-center">
                    <p class="mb-5 pl-4 line">BscIT Computer Science &amp Informatics Second Year Student</p>
                    <p class="name">Thifhelimbilu Masindi</p>
                    <span class="position">Web Developer</span>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>

    <section class="ftco-section bg-light">
			<div class="container">
				<div class="row no-gutters ftco-services">
          <div class="col-lg-3 text-center d-flex align-self-stretch ftco-animate">
            <div class="media block-6 services mb-md-0 mb-4">
              <div class="icon bg-color-1 active d-flex justify-content-center align-items-center mb-2">
            		<span class="flaticon-shipped"></span>
              </div>
              <div class="media-body">
                <h3 class="heading">Faster Weekly Delivery</h3>
                <span>Free for orders of at least R300</span>
              </div>
            </div>      
          </div>
          <div class="col-lg-3 text-center d-flex align-self-stretch ftco-animate">
            <div class="media block-6 services mb-md-0 mb-4">
              <div class="icon bg-color-2 d-flex justify-content-center align-items-center mb-2">
            		<span class="flaticon-diet"></span>
              </div>
              <div class="media-body">
                <h3 class="heading">Always Fresh</h3>
                <span>Product well packaged</span>
              </div>
            </div>    
          </div>
          <div class="col-lg-3 text-center d-flex align-self-stretch ftco-animate">
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
          <div class="col-lg-3 text-center d-flex align-self-stretch ftco-animate">
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
</asp:Content>
