
using ClootherShopAPI.Domain.Enums;

namespace ClootherShopAPI.Domain.Entities
{
    public class AdministratorEntity : BaseEntity
    {
        public string Name { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
    }
}
