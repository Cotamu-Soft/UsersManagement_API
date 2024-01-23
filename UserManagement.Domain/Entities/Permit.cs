namespace UserManagement.Domain.Entities
{
    public class Permit: CommonEntity
    {
        public Guid IdPermitType { get; set; }
        public Lista? PermitType { get; set; }
        public string? Name {  get; set; }
        public string? Description { get; set; }

    }
}
