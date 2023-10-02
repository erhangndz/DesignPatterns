using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainofResponsibility
{
    public abstract class Employee
    {
        protected Employee NextApprover;
        public void SetNextApprover(Employee supervisor)
        {
            this.NextApprover = supervisor;
        }
        public abstract void ProcessRequest(CustomerProcessViewModel request);
        

        
    }
}
