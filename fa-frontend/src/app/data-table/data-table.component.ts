import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EnsayoCatedraService } from '../services/ensayo-catedra.service';
import { TesisPosgradoService } from '../services/tesis-posgrado.service';
import { PracticaProfesionalizanteService } from '../services/practica-profesionalizante.service';
import { PracticaSupervisadaService } from '../services/practica-supervisada.service';
import { TesinaLicenciaturaService } from '../services/tesina-licenciatura.service';
import { ProyectoFinalIngenieriaService } from '../services/proyecto-final-ingenieria.service';

@Component({
  selector: 'app-data-table',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './data-table.component.html',
  styleUrl: './data-table.component.css'
})
export class DataTableComponent {

    @Input() items!: any[];
    @Input() tipoFA!: string;

    constructor(private ensayoCatedraService: EnsayoCatedraService, 
      private tesisPosgradoService: TesisPosgradoService,
      private practicaSupervisadaService: PracticaSupervisadaService,
      private practicaProfesionalizanteService: PracticaProfesionalizanteService ,
      private tesinaLicenciaturaService: TesinaLicenciaturaService,
      private proyectoFinalIngenieria: ProyectoFinalIngenieriaService
      ) {}
    deleteFA(id:number){
    
      switch(this.tipoFA){
        case "ensayo-catedra":{
          if(confirm("¿Seguro desea eliminar este ensayo de cátedra?")) {this.ensayoCatedraService.deleteEnsayoCatedra(id).subscribe();
            this.items = this.items.filter(item => item.id != id);}
          break;
        }
        case "practica-profesionalizante":{
          if(confirm("¿Seguro desea eliminar esta practica profesionalizante?")) {this.practicaProfesionalizanteService.deletePracticaProfesionalizante(id).subscribe();
            this.items = this.items.filter(item => item.id != id);}
          break;
        }
        case "practica-supervisada":{
          if(confirm("¿Seguro desea eliminar esta practica supervisada?")) {this.practicaSupervisadaService.deletePracticaSupervisada(id).subscribe();
            this.items = this.items.filter(item => item.id != id);}
          break;
        }
        case "proyecto-final-ingenieria":{
          if(confirm("¿Seguro desea eliminar este proyecto final de ingenieria?")) {this.proyectoFinalIngenieria.deleteProyectoFinalIngenieria(id).subscribe();
            this.items = this.items.filter(item => item.id != id);}
          break;
        }
        case "tesis-posgrado":{
          if(confirm("¿Seguro desea eliminar esta tesis de posgrado?")) {this.tesisPosgradoService.deleteTesisPosgrado(id).subscribe();
            this.items = this.items.filter(item => item.id != id);}
          break;
        }
        case "tesina-licenciatura":{
          if(confirm("¿Seguro desea eliminar esta tesina de licenciatura?")) {this.tesinaLicenciaturaService.deleteTesinaLicenciatura(id).subscribe();
            this.items = this.items.filter(item => item.id != id);}
          break;
        }

      }
  }
}
  
