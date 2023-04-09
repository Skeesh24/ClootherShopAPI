
using ClootherShopAPI.DAL.Enums;
using System.ComponentModel.DataAnnotations;

namespace ClootherShopAPI.DAL.Entities
{
    public class AdministratorEntity 
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
    }
}
