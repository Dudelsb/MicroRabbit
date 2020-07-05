namespace MicroRabbit.Banking.Domain.Commands
{
    public class CreateTranferCommand : TransferCommand
    {
        public CreateTranferCommand(int from, int to, decimal amount)
        {
            this.From = from;
            this.To = to;
            Amount = amount;

        }
    }
}
