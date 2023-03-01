namespace ClootherShopAPI.Domain.Entities
{
    public class ReplyEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Comment { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
