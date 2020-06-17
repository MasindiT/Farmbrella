﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace FarmService
{
    
    public class Service1 : IService1
    {
        FarmDBDataContext db = new FarmDBDataContext();

        public int Login(string email, string password)
        {
            var UserExist = (from p in db.Users
                             where p.Email.Equals(email) &&
              p.Password.Equals(Secrecy.HashPassword(password))
                             select p).FirstOrDefault();

            if(UserExist == null)
            {
                return -1;
            }
            else if(UserExist.UserType == 1)
            {
                return UserExist.UserID;
            }
            else
            {
                return UserExist.UserID;
            }
        }

        public bool registered(string email, string pass)
        {
            var exist = (from u in db.Users where u.Email.Equals(email) && u.Password.Equals(Secrecy.HashPassword(pass)) select u).FirstOrDefault();

            if (exist != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public int Register(UserClass details)
        {
            if (!registered(details.email, details.Password))
            {

                var newU = new User
                {
                    Title = details.Title,
                    Name = details.Name,
                    LastName = details.Surname,
                    Email = details.email,
                    Password = Secrecy.HashPassword(details.Password),
                    UserType = details.userType,
                    ActiveOrNot = 1,
                    RegDate = DateTime.Now.Date

                           
                };

                db.Users.InsertOnSubmit(newU);

                try
                {
                    db.SubmitChanges();
                    return 1;
                }
                catch (Exception e)
                {
                    e.GetBaseException();
                    return -1;
                }
            }
            else
            {
                return 0;
            }
        }

        public bool Exist(string name)
        {
            var exist = (from u in db.Products where u.ProductName.Equals(name) select u).FirstOrDefault();

            if (exist != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public int AddProduct(ProductClass product)
        {
            if (!Exist(product.name))
            {
                var newU = new Product
                {
                    ProductID = product.productID,
                    ProductName = product.name,
                    ProductPrice = Convert.ToDecimal(product.price),
                    ProductImage = product.image,
                    ProuctQty = product.quantity,
                    ProductDescription = product.description,
                    ProductType = product.type,
                    ProductStatus = 1
                };

                db.Products.InsertOnSubmit(newU);

                try
                {
                    db.SubmitChanges();
                    return 1;
                }
                catch (Exception e)
                {
                    e.GetBaseException();
                    return -1;
                }
            }
            else
            {
                return 0;
            }

        }

        public int EditProduct(ProductClass product)
        {
            if (Exist(product.name))
            {
                Product p = (from i in db.Products where i.ProductName.Equals(product.name) select i).FirstOrDefault();

                p.ProductPrice = Convert.ToDecimal(product.price);
                p.ProductImage = product.image;
                p.ProuctQty = product.quantity;
                p.ProductDescription = product.description;


                try
                {
                    db.SubmitChanges();
                    return 1;
                }
                catch (Exception e)
                {
                    e.GetBaseException();
                    return -1;
                }
            }
            else
            {
                return 0;
            }

        }

        public ProductClass getProduct(string name)
        {

            ProductClass prod = null;
            if(Exist(name))
            {
                var a = (from p in db.Products where p.ProductName.Equals(name) && p.ProductStatus.Equals(1) select p).FirstOrDefault();

                prod = new ProductClass{
                    productID = a.ProductID,
                    name = a.ProductName,
                    price = Convert.ToDouble(a.ProductPrice),
                    description = a.ProductDescription,
                    quantity = a.ProuctQty,
                    image = a.ProductImage,
                    type = a.ProductType
                };
            }

            return prod;
        }

        public ProductClass getProductByID(int id)
        {
            ProductClass prod = null;
            
            var a = (from p in db.Products where p.ProductID.Equals(id) select p).FirstOrDefault();

            prod = new ProductClass
            {
                productID = a.ProductID,
                name = a.ProductName,
                price = Convert.ToDouble(a.ProductPrice),
                description = a.ProductDescription,
                quantity = a.ProuctQty,
                image = a.ProductImage,
                type = a.ProductType
            };
            

            return prod;
        }

        public List<Product> getAllProduct(int type)
        {
            List<Product> collection = new List<Product>();

            dynamic products;
            if (type == 4)
            {
                products = (from p in db.Products orderby p.ProductName ascending
                            select p);
            }
            else if(type == 5)
            {
                products = (from p in db.Products
                            orderby p.ProductName descending
                            select p);
            }
            else if(type == 6)
            {
                products = (from p in db.Products
                            orderby p.ProductPrice ascending
                            select p);
            }
            else if(type == 7)
            {
                products = (from p in db.Products
                            orderby p.ProductPrice descending
                            select p);
            }
            else
            {
               products = (from p in db.Products
                                    select p);
            }

            foreach(Product a in products)
            {
                if(a.ProductStatus.Equals(1))
                {
                    collection.Add(a);
                }

            }

            return collection;
        }

        public List<Product> getProductType(int type)
        {
            List<Product> collection = new List<Product>();

            dynamic products = (from p in db.Products
                                where p.ProductType.Equals(type) && p.ProductStatus.Equals(1)
                                select p);

            foreach (Product a in products)
            {
                collection.Add(a);

            }

            return collection;
        }

        public string fetchProduct(int ID)
        {
            var getByName = (from e in db.Products
                             where e.ProductID.Equals(ID)
                             select e).FirstOrDefault();

            return getByName.ProductName;
        }

        public User getUser(int ID)
        {
            var userFound = (from u in db.Users
                             where u.UserID.Equals(ID)
                             select u).FirstOrDefault();

            return userFound;
        }

        public bool emailExists(string email)
        {
            var exists = (from e in db.Newsletters where e.Email.Equals(email) select e).FirstOrDefault();

            if (exists != null)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public int AddSubscribe(Subscriber visitor)
        {
            if (!emailExists(visitor.emailAdd))
            {
                var mail = new Newsletter
                {
                    Email = visitor.emailAdd
                };
                db.Newsletters.InsertOnSubmit(mail);

                try
                {
                    db.SubmitChanges();
                    return 1;
                }
                catch(Exception ex)
                {
                    ex.GetBaseException();
                    return -1;
                }
            }
            else
            {
                return 0;
            }
        }
		public bool BlogExists(string subject)
		{
			var post = (from b in db.Blogs where b.Subject.Equals(subject) select b).FirstOrDefault();
			if(post != null)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public int AddBlog(CBlog blog)
		{
			if (!BlogExists(blog.subject))
			{
				var post = new Blog {
					Subject = blog.subject,
					Content = blog.content,
					Publisher = blog.publisher,
					PublishDate = blog.date,
					ContentImage = blog.image
				};

				db.Blogs.InsertOnSubmit(post);
				try
				{
					db.SubmitChanges();
					return 1;
				}
				catch(Exception ex)
				{
					ex.GetBaseException();
					return -1;
				}
			}
			else
			{
				return 0;
			}
		}

		public List<Blog> GetBlogs()
		{
			List<Blog> list = new List<Blog>();
			dynamic logs = (from b in db.Blogs select b);
			foreach (Blog bl in logs)
			{
				list.Add(bl);
			}
			return list;
		}

		public CBlog FetchBlog(int ID)
		{
			CBlog single = null;
			var getContent = (from c in db.Blogs where c.BlogId.Equals(ID)
							  select c).FirstOrDefault();
			single = new CBlog
			{
				bID = getContent.BlogId,
				subject = getContent.Subject,
				publisher = getContent.Publisher,
				content = getContent.Content,
				date = getContent.PublishDate,
				image = getContent.ContentImage
			};

			return single;
		}

        public int generateInvoice(InvoiceClass newInv)
        {
            Invoice latest = new Invoice
            {
                UserId = newInv.user,
                PurchaseDay = newInv.day,
                SubTotal = Convert.ToDecimal(newInv.subtotal),
                VAT = Convert.ToDecimal(newInv.vat),
                DeliveryFee = Convert.ToDecimal(newInv.delivery),
                TotalExpenditure = Convert.ToDecimal(newInv.grossTotal)
            };

            db.Invoices.InsertOnSubmit(latest);

            try
            {
                db.SubmitChanges();
                return 0;
            }
            catch (Exception e)
            {
                e.GetBaseException();
                return -1;
            }
        }

        public int getInvoiceID(int userID, DateTime day)
        {
            dynamic invo = (from i in db.Invoices where i.UserId.Equals(userID) && i.PurchaseDay.Equals(day) select i).FirstOrDefault();

            if (invo != null)
            {
                return invo.InvoiceID;
            }
            else
            {
                return -1;
            }
        }

        public List<InvoiceProduct> getAllInvoiceProduct(int invID)
        {
            List<InvoiceProduct> list = new List<InvoiceProduct>();

            dynamic products = (from pr in db.OrderTrackers where pr.InvoiceId.Equals(invID) select pr);

            foreach (OrderTracker od in products)
            {
                list.Add(new InvoiceProduct
                {
                    prodID = od.ItemID,
                    qty = od.ItemQty,
                    price = Convert.ToDouble(od.ItemPrice)
                });
            }

            return list;
        }

        public InvoiceClass getInvoiceByID(int indID)
        {
            InvoiceClass newInv = null;
            dynamic inv = (from p in db.Invoices where p.InvoiceID.Equals(indID) select p).FirstOrDefault();

            if (inv != null)
            {
                newInv = new InvoiceClass
                {
                    InvoiceID = inv.InvoiceID,
                    user = inv.UserId,
                    day = inv.PurchaseDay,
                    subtotal = Convert.ToDouble(inv.SubTotal),
                    vat = Convert.ToDouble(inv.VAT),
                    delivery = Convert.ToDouble(inv.DeliveryFee),
                    grossTotal = Convert.ToDouble(inv.TotalExpenditure)
                };
            }

            return newInv;
        }

        public bool saveOrderProduct(List<ProductsInCart> list, int invID)
        {
            try
            {
                foreach (var item in list)
                {
                    OrderTracker monitoredOrder = new OrderTracker
                    {
                        InvoiceId = invID,
                        ItemID = item.ID,
                        ItemQty = item.Quantity,
                        ItemPrice = Convert.ToDecimal(getProductByID(item.ID).price)

                    };
                    db.OrderTrackers.InsertOnSubmit(monitoredOrder);
                }
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }

        public int fetchUsers(DateTime date)
        {
            dynamic users = (from u in db.Users where u.RegDate.Equals(date.Date) select u);
            int num = 0;
            foreach(User u in users)
            {
                ++num;
            }

            return num;
        }

        public graph getGraph(int change , List<InvoiceClass> list)
        {
            graph nw = new graph();
            DateTime date = DateTime.Now;
            date = date.AddMonths(-1 * change);
            list = list.Where(e => e.day.Month == date.Month).ToList();
            nw.Label = date.Month.ToString() + " " + date.Year.ToString();
            nw.Value = 0;
            list.ForEach(e =>
            {
                nw.Value += Convert.ToInt32(e.subtotal);
            });

            return nw;
        }
        public List<graph> getAllInvoicesGraph(int num)
        {
            List<InvoiceClass> list = new List<InvoiceClass>();
            List<graph> newGraph = new List<graph>();
            
            
            dynamic invoices = (from i in db.Invoices  select i);

            foreach (Invoice i in invoices)
            {
                list.Add(new InvoiceClass
                {
                    InvoiceID = i.InvoiceID,
                    user = i.UserId,
                    day = i.PurchaseDay,
                    grossTotal = Convert.ToDouble(i.TotalExpenditure),
                    delivery = Convert.ToDouble(i.DeliveryFee),
                    subtotal = Convert.ToDouble(i.SubTotal),
                    vat = Convert.ToDouble(i.VAT)

                });
            }

            for(int a = 0; a< num; a++)
            {
                newGraph.Add(getGraph(a, list));
            }

            return newGraph;
            
        }

        

        public List<User> getAllUsers()
        {
            List<User> list = new List<User>();
            dynamic users = (from u in db.Users select u);

            foreach(User u in users)
            {
                list.Add(u);
            }
            return list;
        }

        public List<InvoiceClass> getAllInvoices(int userID)
        {
            List<InvoiceClass> list = new List<InvoiceClass>();

            dynamic invoices = (from i in db.Invoices where i.UserId.Equals(userID) select i);

            foreach(Invoice i in invoices)
            {
                list.Add(new InvoiceClass
                {
                    InvoiceID = i.InvoiceID,
                    user = i.UserId,
                    day = i.PurchaseDay,
                    grossTotal = Convert.ToDouble(i.TotalExpenditure),
                    delivery = Convert.ToDouble(i.DeliveryFee),
                    subtotal = Convert.ToDouble(i.SubTotal),
                    vat =Convert.ToDouble( i.VAT)

                });
            }

            return list;
        }

        public bool editUser(UserClass userClass)
        {
            dynamic fetchTheUser = (from e in db.Users
                                    where e.UserID.Equals(userClass.userID)
                                    select e).FirstOrDefault();

            fetchTheUser.Title = userClass.Title;
            fetchTheUser.Name = userClass.Name;
            fetchTheUser.LastName = userClass.Surname;
            fetchTheUser.Password =Secrecy.HashPassword(userClass.Password);

            try
            {
                db.SubmitChanges();
                return true;
            }
            catch(Exception ex)
            {
                ex.GetBaseException();
                return false;
            }

            


        }

        public bool deleteProduct(string prodName)
        {
            Product pr = (from p in db.Products where p.ProductName.Equals(prodName) select p).FirstOrDefault();

            pr.ProductStatus = 0;

            try
            {
                db.SubmitChanges();
                return true;
            }
            catch(Exception e)
            {
                e.GetBaseException();
                return false;
            }
        }

        public bool addCoupon(CouponClass userCoupon)
        {
            var addNew = new Coupon
            {
                UserID = userCoupon.UserID,
                Coupon_ID= userCoupon.CouponID
            };

            db.Coupons.InsertOnSubmit(addNew);

            try
            {
                db.SubmitChanges();
                return true;
            }
            catch(Exception ex)
            {
                ex.GetBaseException();
                return false;
            }



        }

        public int verifyCoupon(CouponClass userCoupon)
        {
            var valid = (from d in db.Coupons
                         where d.UserID.Equals(userCoupon.UserID)
                          && d.Coupon_ID.Equals(userCoupon.CouponID)
                         select d).FirstOrDefault();

          
            if(valid != null)
            {
                valid.UserID = 0;
                valid.Coupon_ID = 0;

                try
                {
                    db.SubmitChanges();
                    return 1;
                }
                catch (Exception ex)
                {
                    ex.GetBaseException();
                    return -1;
                }
            }
            else
            {
                return 0;
            }
                

        }
    }
}
