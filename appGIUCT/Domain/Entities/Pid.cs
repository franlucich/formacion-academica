namespace appGIUCT.Domain.Entities
{
    public class Pid : IEntity
    {
        public Pid() {
            codigo = 0;
            descripcion = "";
            duracion = 0;
            titulo = "";
            tipo = "";
            estado = "";
            person = new List<Person>();
        }
        
        public int codigo {get; set;}
        public string descripcion {get; set;}
        public int duracion {get; set;}
        public DateTime fechaFin {get; set;}
        public DateTime fechaInicio {get; set;}
        public string titulo {get; set;}
        public string tipo {get; set;}
        public string estado {get; set; }
        public List<Person> person {get; set;}

        public FormacionAcademica formacionAcademica {get; set; }
        public int pkFormacionAcademica {get; set;}
    }
}