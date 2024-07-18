using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class bll_AMS
    {
        public void insertPassenger(int _pID, string _pCNIC, string _pName, int _pAge, string _pGender, int _pPhNumber, string _pAddress, string _pFrom, string _pTo, string _pDay, int _pSeat, string _pClass)
        { 
            DAL.DAL dalObj= new DAL.DAL();
            dalObj.OpenConnection();
            dalObj.LoadSpParameters("sp_InsertPassenger", _pID, _pCNIC, _pName, _pAge, _pGender, _pPhNumber, _pAddress, _pFrom, _pTo, _pDay, _pSeat, _pClass);
            dalObj.ExecuteQuery();
            dalObj.UnLoadSpParameters();
            dalObj.CloseConnection();
        }

        public void getPassenger(int _pID, string _pCNIC, string _pName, int _pAge, string _pGender, int _pPhNumber, string _pAddress, string _pFrom, string _pTo, string _pDay, int _pSeat, string _pClass)
        {
            DAL.DAL dalObj = new DAL.DAL();
            dalObj.OpenConnection();
            dalObj.LoadSpParameters("sp_InsertPassenger", _pID, _pCNIC, _pName, _pAge, _pGender, _pPhNumber, _pAddress, _pFrom, _pTo, _pDay, _pSeat, _pClass);
            dalObj.GetDataTable();
            dalObj.UnLoadSpParameters();
            dalObj.CloseConnection();
        }

        public void deletePassenger(int _pID)
        {
            DAL.DAL dalObj = new DAL.DAL();
            dalObj.OpenConnection();
            dalObj.LoadSpParameters("sp_DeletePassenger", _pID);
            dalObj.ExecuteQuery();
            dalObj.UnLoadSpParameters();
            dalObj.CloseConnection();
        }
        public void updatePassenger(int _pID, string _pCNIC, string _pName, int _pAge, string _pGender, int _pPhNumber, string _pAddress, string _pFrom, string _pTo, string _pDay, int _pSeat, string _pClass)
        {
            DAL.DAL dalObj = new DAL.DAL();
            dalObj.OpenConnection();
            dalObj.LoadSpParameters("sp_UpdatePassenger", _pID, _pCNIC, _pName, _pAge, _pGender, _pPhNumber, _pAddress, _pFrom, _pTo, _pDay, _pSeat, _pClass);
            dalObj.ExecuteQuery();
            dalObj.UnLoadSpParameters();
            dalObj.CloseConnection();
        }
        public void insertEmployee(int _eID, string _eCNIC, string _eName, int _eAge, string _eGender, int _ePhNumber)
        {
            DAL.DAL dalObj = new DAL.DAL();
            dalObj.OpenConnection();
            dalObj.LoadSpParameters("sp_InsertEmployee", _eID, _eCNIC, _eName, _eAge, _eGender, _ePhNumber);
            dalObj.ExecuteQuery();
            dalObj.UnLoadSpParameters();
            dalObj.CloseConnection();
        }
        public void deleteEmployee(int _eID)
        {
            DAL.DAL dalObj = new DAL.DAL();
            dalObj.OpenConnection();
            dalObj.LoadSpParameters("sp_DeleteEmployee", _eID);
            dalObj.ExecuteQuery();
            dalObj.UnLoadSpParameters();
            dalObj.CloseConnection();
        }
        public void updateEmployee(int _eID, string _eCNIC, string _eName, int _eAge, string _eGender, int _ePhNumber)
        {
            DAL.DAL dalObj = new DAL.DAL();
            dalObj.OpenConnection();
            dalObj.LoadSpParameters("sp_UpdateEmployee", _eID, _eCNIC, _eName, _eAge, _eGender, _ePhNumber);
            dalObj.ExecuteQuery();
            dalObj.UnLoadSpParameters();
            dalObj.CloseConnection();
        }
    }
}
