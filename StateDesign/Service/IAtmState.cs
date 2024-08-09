using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesign.Service
{
    public interface IAtmState
    {
        void InsertDebitCard();
        void EjectDebitCard();
        void EnterPin();
        void WithdrawMoney();
    }
}
