using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion
{
    public class Order
    {
        private IMessageService messageService;

        public Order(IMessageService messageService)
        {
            this.messageService = messageService;
        }
        public void Onay() 
        {
            messageService.Send6();
        }
       
    }
}
