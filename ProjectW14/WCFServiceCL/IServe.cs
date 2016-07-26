using ADOClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

//Made [DataContract]'s and [DataMember]'s in ADOClassLibrary
namespace WCFServiceCL
{
    [ServiceContract]
    public interface IServe
    {
        [OperationContract]
        void addItemtoDBServiceMethod(Basket anItem);

        [OperationContract]
        List<Item> GetItemsFromDB();
    }
}
