using System.ComponentModel.DataAnnotations;

namespace ClootherShopAPI.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
