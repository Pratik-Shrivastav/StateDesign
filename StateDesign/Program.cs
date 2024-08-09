using StateDesign.Service;

namespace StateDesign
{
    public class Program
    {
        static void Main(string[] args)
        {
            AtmMachine atmMachine = new AtmMachine();

            Console.WriteLine("ATM Machine Current state : "
                            + atmMachine.AtmMachineState.GetType().Name);
            Console.WriteLine();
            atmMachine.EnterPin();
            atmMachine.WithdrawMoney();
            atmMachine.EjectDebitCard();
            atmMachine.InsertDebitCard();

            Console.WriteLine();

            Console.WriteLine("ATM Machine Current state : "
                            + atmMachine.AtmMachineState.GetType().Name);
            Console.WriteLine();

            atmMachine.EnterPin();
            atmMachine.WithdrawMoney();
            atmMachine.InsertDebitCard();
            atmMachine.EjectDebitCard();

            Console.WriteLine("");

            Console.WriteLine("ATM Machine Current state : "
                            + atmMachine.AtmMachineState.GetType().Name);

            Console.Read();
        }
    }
}