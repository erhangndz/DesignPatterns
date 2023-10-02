using DesignPattern.ChainOfResponsibility.DataAccess;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainofResponsibility
{
    public class AssistantManager : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            Context context = new Context();

            if (request.Amount <= 150000)
            {
                CustomerProcess customerProcess = new CustomerProcess()
                {
                    Amount = request.Amount,
                    Name = request.Name,
                    EmployeeName = "Şube Müdür Yardımcısı - Melike Öztürk",
                    Description = "Para Çekme İşlemi Onaylandı Müşteriye talep ettiği tutar ödendi"
                };
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }

            else if (NextApprover != null)
            {
                CustomerProcess customerProcess2 = new CustomerProcess()
                {
                    Amount = request.Amount,
                    Name = request.Name,
                    EmployeeName = "Şube Müdür Yardımcısı - Melike Öztürk",
                    Description = "Para çekme tutarı şube müdür yardımcısının günlük ödeyebileceği limiti aştığı için işlem şube müdürüne  yönlendirildi."
                };
                context.CustomerProcesses.Add(customerProcess2);
                context.SaveChanges();
                NextApprover.ProcessRequest(request);
            }

        }
    }
}
