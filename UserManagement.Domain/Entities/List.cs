namespace UserManagement.Domain.Entities
{
    public class Lista : CommonEntity
    {
        public string? Name { get; set; }
        public Guid IdListaType { get; set; }
        public ListaType? ListaType { get; set; }

    }
}
