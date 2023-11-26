namespace appGIUCT.Domain.Entities
{
    public class Person : IEntity
    {
        public Person() {
            Nombre = "";
            Apellido = "";
            Dni = 0;
            cuil =0;
            telefono =0;
            celular =0;
            direccionPostal = 0;
            emailPersonal = "";
            emailInsitucional = "";
            horasSemInvestigadas = 0;
        }
    
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        
        public int Dni { get; set; }
       
        public int cuil {get; set;}
        public int telefono  {get; set;}
        public int celular {get; set;}
        
        public int direccionPostal {get; set;}
        public string emailPersonal {get; set;}
        public string emailInsitucional {get; set;}
        public int horasSemInvestigadas{get; set;}

    }
}