namespace appGIUCT.Domain.Entities
{
    public class FormacionAcademica : IEntity
    {
        
        public DateTime fechaInicio {get; set;}
        public DateTime fechaFin {get; set;}
        public string titulo {get; set;}
        public Pid Pid { get; set; }
        public int pkIniciativa {get; set;}
        public Facultad facultad { get; set; }
        public int pkFacultad { get; set; }
        public List<Person> person {get; set;}
        


    }
}