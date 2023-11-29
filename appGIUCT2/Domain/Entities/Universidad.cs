namespace appGIUCT.Domain.Entities
{
    public class Universidad : IEntity
    {
        public Universidad() {
            nombre = "";
            facultades = new List<Facultad>();

        }
        public List<Facultad> facultades {get; set;}
        public string nombre {get; set;}

    }
}