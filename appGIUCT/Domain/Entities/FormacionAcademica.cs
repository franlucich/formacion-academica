namespace appGIUCT.Domain.Entities
{
    public abstract class  FormacionAcademica : IEntity
    {
        protected FormacionAcademica()
        {
            
        }
        public DateTime fechaInicio {get; set;}
        public DateTime fechaFin {get; set;}
        public string titulo {get; set;}
        public Pid Pid { get; set; }
        public  IniciativaDeInvestigacion IniciativaDeInvestigacion {get; set;}
        public int pkIniciativa {get; set;}
        public Facultad facultad { get; set; }
        public int pkFacultad { get; set; }
    
        public List<Person> persona {get; set;}

         public abstract string TipoForm { get; }



    }
}