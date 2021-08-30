using MicroRabbit.Domain.Core.Commands;

namespace MicroRabbit.Banking.Domain.Commands {
    public class CreateTransferCommand : Command {
        public int From { get; set; }

        public int To { get; set; }

        public decimal Amount { get; set; }
        public CreateTransferCommand(int from, int to, decimal amount) {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}
