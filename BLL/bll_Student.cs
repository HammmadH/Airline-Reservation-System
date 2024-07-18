using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class bll_Student
    {
        public void saveStudent(int _sId, string _sName)
        { 
            DAL.DAL dalObj= new DAL.DAL();
            dalObj.OpenConnection();
            dalObj.LoadSpParameters("sp_InsertStudent", _sId, _sName);
            dalObj.ExecuteQuery();
            dalObj.UnLoadSpParameters();
            dalObj.CloseConnection();
        
        }


    }
}
