using MediatR;

namespace DesignPattern.MediatorDesign.MediatorPattern.Commands
{
    public class RemoveProductCommand:IRequest
    {
        public int id { get; set; }

        public RemoveProductCommand(int id)
        {
            this.id = id;
        }
    }
}
