namespace appGIUCT.Domain.Entities
{
    public class  FormacionAcademica : IEntity
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

        public List<PersonFormacionAcademica> persona {get; set;}

        public EnsayoCatedra ensayoCatedra {get; set;}

        public PracticaProfesionalizante practicaProfesionalizante {get; set;}

        public TesisPosgrado tesisPosgrado {get; set;}

        public TesinaLicenciatura tesinaLicenciatura {get; set;}

        public ProyectoFinalIngenieria proyectoFinalIngenieria {get; set;}

        public PracticaSupervisadaIngenieria practicaSupervisadaIngenieria {get; set;}



    }
}