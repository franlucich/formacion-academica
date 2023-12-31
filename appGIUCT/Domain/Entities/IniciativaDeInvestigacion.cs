namespace appGIUCT.Domain.Entities
{
    public class IniciativaDeInvestigacion : IEntity
    {
        public IniciativaDeInvestigacion() {
            codigo = 0;
            descripcion = "";
            duracion = 0;
            estado = "";
            titulo = "";
        }
        
        public int codigo {get; set;}
        public string descripcion {get; set;}
        public int duracion {get; set;}
        public string estado {get; set;}
        public DateTime fechaFin {get; set;}
        public DateTime fechaInicio {get; set;}
        public string titulo {get; set;}

        public List<PersonaIniciat> persona {get; set;}
        

        public int DirectorId { get; set; }
        public Person Director { get; set; }

        // Relación muchos a muchos: un PID puede tener varios integrantes
        public List<PersonaIniciat> Integrantes { get; set; }
        


    }
}