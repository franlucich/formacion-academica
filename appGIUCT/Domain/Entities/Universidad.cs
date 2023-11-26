namespace appGIUCT.Domain.Entities
{
    public class Universidad : IEntity
    {
        public Universidad() {
            nombre = "";
        }
        
        public string nombre {get; set;}

    }
}