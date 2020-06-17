using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace FarmService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        int Register(UserClass details);
        [OperationContract]
        int Login(String email,String password);
        [OperationContract]
        bool registered(string email, string pass);
        [OperationContract]
        int AddProduct(ProductClass product);
        [OperationContract]
        int EditProduct(ProductClass product);
        [OperationContract]
        ProductClass getProduct(string name);
        [OperationContract]
        bool Exist(string name);
        [OperationContract]
        List<Product> getAllProduct(int type);
        [OperationContract]
        List<Product> getProductType(int type);
        [OperationContract]
        String fetchProduct(int ID);
        [OperationContract]
        User getUser(int ID);
        [OperationContract]
        ProductClass getProductByID(int id);
        [OperationContract]
        int AddSubscribe(Subscriber visitor);
        [OperationContract]
        bool emailExists(string email);
		[OperationContract]
		int AddBlog(CBlog blog);
		[OperationContract]
		bool BlogExists(string subject);
		[OperationContract]
		List<Blog> GetBlogs();
		[OperationContract]
		CBlog FetchBlog(int ID);
        [OperationContract]
        int generateInvoice(InvoiceClass newInv);
        [OperationContract]
        int getInvoiceID(int userID, DateTime day);
        [OperationContract]
        List<InvoiceProduct> getAllInvoiceProduct(int invID);
        [OperationContract]
        InvoiceClass getInvoiceByID(int indID);
        [OperationContract]
        bool saveOrderProduct(List<ProductsInCart> list, int invID);
        [OperationContract]
        int fetchUsers(DateTime date);
        [OperationContract]
        List<User> getAllUsers();
        [OperationContract]
        List<InvoiceClass> getAllInvoices(int userID);
        [OperationContract]
        bool editUser(UserClass userClass);
        [OperationContract]
        bool deleteProduct(string prodName);
        [OperationContract]
        bool addCoupon(CouponClass userCoupon);
        [OperationContract]
        int verifyCoupon(CouponClass userCoupon);
        [OperationContract]
        List<graph> getAllInvoicesGraph(int num);

    }
}
