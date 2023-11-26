namespace appGIUCT.Domain.Entities
{
    public class Facultad : IEntity
    {
        public Facultad() {
            nombre = "";
        }
        public string nombre {get; set;}

    }
}