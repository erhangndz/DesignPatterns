using DesignPattern.ChainOfResponsibility.DataAccess;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainofResponsibility
{
    public class RegionalManager : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            Context context = new Context();

            if (request.Amount <= 400000)
            {
                CustomerProcess customerProcess = new CustomerProcess()
                {
                    Amount = request.Amount,
                    Name = request.Name,
                    EmployeeName = "Bölge Müdürü - Zeynep Yılmaz",
                    Description = "Para Çekme İşlemi Onaylandı Müşteriye talep ettiği tutar ödendi"
                };
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }

            else 
            {
                CustomerProcess customerProcess2 = new CustomerProcess()
                {
                    Amount = request.Amount,
                    Name = request.Name,
                    EmployeeName = "Bölge Müdürü - Zeynep Yılmaz",
                    Description = "Para çekme tutarı bölge müdürünün günlük ödeyebileceği limiti aştığı için işlem gerçekleştirilemedi, Günlük maksimum çekebileceği tutar 400.000 ₺ olup daha fazlası için birden fazla gün gelemsi gerekli!"
                };
                context.CustomerProcesses.Add(customerProcess2);
                context.SaveChanges();
                
            }
        }
    }
}
