using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFTest.Messages
{
    [ServiceContract]
    public interface IMessageService
    {
        [OperationContract]
        List<Message> GetAllMessages();
        [OperationContract]
        Message GetMessageById(int Id);
        [OperationContract]
        void AddMessage(MyWedding.Models.Message message);


    }
}
