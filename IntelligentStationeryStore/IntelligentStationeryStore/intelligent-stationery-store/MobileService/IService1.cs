using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.ServiceModel.Configuration;
using MobileService;
using MobileService.DataModels;
//using com.iss.inventory.Entity;

namespace MobileService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebGet(UriTemplate = "/GetStockCard/{itemid}", ResponseFormat = WebMessageFormat.Json)]
        StockCardMobile GetStockCardDetails(string itemid);

        [OperationContract]
        [WebGet(UriTemplate = "/AdjVoucherDetails/{adjustid}", ResponseFormat = WebMessageFormat.Json)]
        AdjVoucherMobile GetAdjVoucherDetails(string adjustid);

        [OperationContract]
        [WebGet(UriTemplate = "/GetData", ResponseFormat = WebMessageFormat.Json)]
        string GetData();

        [OperationContract]
        [WebGet(UriTemplate = "/AdjVoucherDetails/Pending", ResponseFormat = WebMessageFormat.Json)]
        AdjVoucherDetailsMobile[] GetPendingAdjVoucherDetails();

        //[OperationContract]
        //[WebGet(UriTemplate = "/AdjVoucherDetails/Delete/{adjvdid}", ResponseFormat = WebMessageFormat.Json)]
        //string DeleteAdjVoucherDetails(int adjvdid);

        //[OperationContract]
        //[WebGet(UriTemplate = "/AdjVoucherDetails/Approve/{empid}", ResponseFormat = WebMessageFormat.Json)]
        //string ApproveAdjVoucherDetails(string empid, List<int> voucherList);

        //[OperationContract]
        //[WebInvoke(Method = "POST", UriTemplate = "/AdjVoucherDetails/Approve/{empid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        //string ApproveAdjVoucherDetails(string empid, List<int> voucherList);

        ////[OperationContract]
        ////[WebGet(UriTemplate = "/Employee", ResponseFormat = WebMessageFormat.Json)]
        ////List<Employee> List();

        //[OperationContract]
        //[WebGet(UriTemplate = "/Employee/{id}", ResponseFormat = WebMessageFormat.Json)]
        //string[] empDetails(string id);

        //[OperationContract]  //pending service impl
        //[WebGet(UriTemplate = "/ItemVoucher/Add/Bin/{binnum}", ResponseFormat = WebMessageFormat.Json)]
        //string[] GetItembyBin(string binnum);

        //[OperationContract]  //pending service impl
        //[WebGet(UriTemplate = "/ItemVoucher/Add/item/{itemid}", ResponseFormat = WebMessageFormat.Json)]
        //string[] GetItembyId(string itemid);

        //[OperationContract]  //pending service impl
        //[WebGet(UriTemplate = "/ItemVoucher/Add/new/{itemid}/{qty}/{reason}", ResponseFormat = WebMessageFormat.Json)]
        //string[] AddItemtoVoucher(string itemid, string qty, string reason);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }
    //[DataContract]
    [DataContract]
    public class Employee
    {
        int employeeID;
        string name;
        string password;
        int deptID;
        string email;
        int phone;
        string role;

        public static Employee Make(int employeeID, string name, string password, int deptID, string email, int phone, string role)
        {
            Employee e = new Employee();
            e.employeeID = employeeID;
            e.name = name;
            e.password = password;
            e.deptID = deptID;
            e.email = email;
            e.phone = phone;
            e.role = role;
            return e;
        }

        [DataMember]
        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        [DataMember]
        public int DeptID
        {
            get { return deptID; }
            set { deptID = value; }
        }

        [DataMember]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        [DataMember]
        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        [DataMember]
        public string Role
        {
            get { return role; }
            set { role = value; }
        }
    }

    //// Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}

