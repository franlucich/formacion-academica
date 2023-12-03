import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProyectoFinalIngenieriaCreateComponent } from "../proyecto-final-ingenieria-create/proyecto-final-ingenieria-create.component";
import { DataTableComponent } from "../data-table/data-table.component";
import { Observable } from 'rxjs';
import { ProyectoFinalIngenieriaService } from '../services/proyecto-final-ingenieria.service';

@Component({
    selector: 'app-proyecto-final-ingenieria',
    standalone: true,
    templateUrl: './proyecto-final-ingenieria.component.html',
    styleUrl: './proyecto-final-ingenieria.component.css',
    imports: [CommonModule, ProyectoFinalIngenieriaCreateComponent, DataTableComponent]
})
export class ProyectoFinalIngenieriaComponent {
    proyectofinal: any[] = [];
    proyectofinal$: Observable<any[]>;
    constructor( private proyectoFinalIngenieriaService: ProyectoFinalIngenieriaService){
        this.proyectofinal$= this.proyectoFinalIngenieriaService.proyectoFinalIngenieria();
      }
    ngOnInit(): void {
        this.proyectofinal$.subscribe({
          next: (value) => this.proyectofinal = value,
          error: (err) => console.log('Error:', err),
          complete: () => {
            console.log('Completed');
          }
        });
      };


}
