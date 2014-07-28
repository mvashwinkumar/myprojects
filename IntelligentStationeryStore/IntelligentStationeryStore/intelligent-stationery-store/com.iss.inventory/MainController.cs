using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.iss.inventory.Controllers;
using com.iss.inventory.CustomModels;

namespace com.iss.inventory
{
   public class MainController
    {
       LoginController lc;
       StationeryRequestController stationeryrequestController;
       public MainController()
        {
            lc = new LoginController();
            stationeryrequestController = new StationeryRequestController();
       }

        public List<string> LoginController(String username,String password)
        {
            List<string> login = new List<string>();
            login = lc.Login(username, password);
            return login;
           
        }
        public int StationeryRequestController(RequestListModel rlm)
        {
           
           return stationeryrequestController.InsertStationeryRequest(rlm);
        }
        public void StationeryRequestDetailController(int requestlistID,String description,int qty)
        {
            stationeryrequestController.AddRequestListDetails(requestlistID, description, qty);
        }
    }
}
