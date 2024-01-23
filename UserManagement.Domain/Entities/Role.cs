namespace UserManagement.Domain.Entities
{
    public class Role: CommonEntity
    {
        public string? Name {  get; set; }
        public List<Permit>? Permits { get; set; }
    }
}
