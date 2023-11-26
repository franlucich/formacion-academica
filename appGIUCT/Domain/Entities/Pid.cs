namespace appGIUCT.Domain.Entities
{
    public class Pid : IEntity
    {
        public Pid() {
            codigo = 0;
            descripcion = "";
            duracion = 0;
            fechaFin = null;
            fechaInicio = null;
            titulo = "";
            tipo = "";
            estado = "";
        }
        
        public int codigo {get; set;}
        public string descripcion {get; set;}
        public int duracion {get; set;}
        public date fechaFin {get; set;}
        public date fechaInicio {get; set;}
        public string titulo {get; set;}
        public string tipo {get; set;}
        public string estado {get; set; }
    }
}