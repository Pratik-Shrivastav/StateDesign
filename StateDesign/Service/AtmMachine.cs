using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesign.Service
{
    public class AtmMachine : IAtmState
    {
        public IAtmState AtmMachineState = null;
        public AtmMachine()
        {
            AtmMachineState = new DebitCardNotInsertedSate();
        }
        public void InsertDebitCard()
        {
            AtmMachineState.InsertDebitCard();

            if (AtmMachineState is DebitCardNotInsertedSate)
            {
                AtmMachineState = new DebitCardInsertedState();
                Console.WriteLine($"ATM Machine internal state has been changed to : {AtmMachineState.GetType().Name}");
            }
        }
        public void EjectDebitCard()
        {
            AtmMachineState.EjectDebitCard();

            if (AtmMachineState is DebitCardInsertedState)
            {
                AtmMachineState = new DebitCardNotInsertedSate();
                Console.WriteLine($"ATM Machine internal state has been Changed to : {AtmMachineState.GetType().Name}");
            }
        }
        public void EnterPin()
        {
            AtmMachineState.EnterPin();
        }
        public void WithdrawMoney()
        {
            AtmMachineState.WithdrawMoney();
        }
    }
}

