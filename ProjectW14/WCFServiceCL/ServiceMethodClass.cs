using ADOClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFServiceCL
{
    public class ServiceMethodClass : IServe
    {

        public void addItemtoDBServiceMethod(Basket anItem)
        {
            DBAccess DBAccessObject = new DBAccess(new Entities());
            DBAccessObject.addItemtoDB(anItem);
        }

        public List<Item> GetItemsFromDB()
        {
            DBAccess DBAccessObject = new DBAccess(new Entities());
            return DBAccessObject.GetItemsFromDB();
        }
    }
}
