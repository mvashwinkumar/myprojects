using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.iss.inventory.Entity;

/*
 * criteriaList Sequence:
 * 0-SupplierID;
 * 1-ItemID;
 * 2-ItemName;
 * 3-EmployeeID;
 * 4-DepartmentID;
 * 5-BinNumber;
 * 6-ItemCategory;
 */
namespace com.iss.inventory.CustomModels
{
    public class SearchItemsModel
    {
        List<String> criteriaList = new List<string>();
        bool status;
        bool isSingleSelectMode = false; //default single-select mode is false
        List<StationeryItem> stationeryItemsList = new List<StationeryItem>();

        public List<String> CriteriaList
        {
            get
            {
                return criteriaList;
            }
            set
            {
                criteriaList = value;
            }
        }

        public bool Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

        public bool SingleSelectMode
        {
            get
            {
                return isSingleSelectMode;
            }
            set
            {
                isSingleSelectMode = value;
            }
        }

        public List<StationeryItem> StationeryItemsList
        {
            get
            {
                return stationeryItemsList;
            }
            set
            {
                stationeryItemsList = value;
            }
        }

        public List<String> getCriteriaList() {
            return criteriaList;
        }
        public void setCriteriaList(List<String> cri)
        {
            criteriaList = cri;
        }

        public bool getStatus()
        {
            return status;
        }
        public void setStatus(bool status)
        {
            this.status = status;
        }

        public List<StationeryItem> getStationeryItemsList()
        {
            return stationeryItemsList;
        }
        public void setStationeryItemsList(List<StationeryItem> staList)
        {
            stationeryItemsList = staList;
        }

    }
}
