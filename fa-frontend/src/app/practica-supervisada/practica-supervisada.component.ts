import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DataTableComponent } from "../data-table/data-table.component";
import { PracticaSupervisadaCreateComponent } from "../practica-supervisada-create/practica-supervisada-create.component";
import { PracticaSupervisadaService } from '../services/practica-supervisada.service';
import { Observable } from 'rxjs';

@Component({
    selector: 'app-practica-supervisada',
    standalone: true,
    templateUrl: './practica-supervisada.component.html',
    styleUrl: './practica-supervisada.component.css',
    imports: [CommonModule, DataTableComponent, PracticaSupervisadaCreateComponent]
})
export class PracticaSupervisadaComponent {
    practicasup: any[]= [];
    practicasup$: Observable<any[]>;
    constructor( private practicaSupervisadaService: PracticaSupervisadaService){
        this.practicasup$= this.practicaSupervisadaService.practicaSupervisada();
      }
    ngOnInit(): void {
        this.practicasup$.subscribe({
          next: (value) => this.practicasup = value,
          error: (err) => console.log('Error:', err),
          complete: () => {
            console.log('Completed');
          }
        });
      };


}
