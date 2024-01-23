namespace UserManagement.Domain.Entities
{
    public class User: CommonEntity
    {
        public string? Username { get; set; }
        public string? Pwd { get; set; }
        public Guid IdRole { get; set; }
        public Role? Role { get; set; }
        public string? Name {  get; set; }
        public string? LastName { get; set; }
        
    }
}
