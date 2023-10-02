using DesignPattern.ChainOfResponsibility.DataAccess;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainofResponsibility
{
    public class Treasurer : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            Context context = new Context();
            if (request.Amount <= 100000)
            {
                CustomerProcess customerProcess = new CustomerProcess()
                {
                    Amount = request.Amount,
                    Name = request.Name,
                    EmployeeName = "Veznedar - Ayşe Çınar",
                    Description = "Para Çekme İşlemi Onaylandı Müşteriye talep ettiği tutar ödendi"
                };
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else if(NextApprover !=null)
            {
                CustomerProcess customerProcess2 = new CustomerProcess()
                {
                    Amount = request.Amount,
                    Name = request.Name,
                    EmployeeName = "Veznedar - Ayşe Çınar",
                    Description = "Para çekme tutarı veznedarın günlük ödeyebileceği limiti aştığı için işlem şube müdür yardımcısına yönlendirildi."
                };
                context.CustomerProcesses.Add(customerProcess2);
                context.SaveChanges();
                NextApprover.ProcessRequest(request);
            }
            
        }
    }
}
