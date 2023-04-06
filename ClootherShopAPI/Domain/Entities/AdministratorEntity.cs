
using ClootherShopAPI.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace ClootherShopAPI.Domain.Entities
{
    public class AdministratorEntity 
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
    }
}
