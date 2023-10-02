using DesignPattern.ChainOfResponsibility.DataAccess;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainofResponsibility
{
    public class Manager : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            Context context = new Context();

            if (request.Amount <= 250000)
            {
                CustomerProcess customerProcess = new CustomerProcess()
                {
                    Amount = request.Amount,
                    Name = request.Name,
                    EmployeeName = "Şube Müdürü - Hatice Sarı",
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
                    EmployeeName = "Şube Müdürü - Hatice Sarı",
                    Description = "Para çekme tutarı şube müdürünün günlük ödeyebileceği limiti aştığı için işlem bölge müdürüne  yönlendirildi."
                };
                context.CustomerProcesses.Add(customerProcess2);
                context.SaveChanges();
                NextApprover.ProcessRequest(request);
            }
        }
    }
}
