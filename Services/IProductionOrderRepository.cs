using API_Proje.Models;

namespace API_Proje.Services
{
    public interface IProductionOrderRepository
    {
        ProductionOrder Add(ProductionOrder productionorder);
        IEnumerable<ProductionOrder> GetAll();
        ProductionOrder GetById(int id);
        void Delete(ProductionOrder productionorder);
        void Update(ProductionOrder productionorder);
    }
}
