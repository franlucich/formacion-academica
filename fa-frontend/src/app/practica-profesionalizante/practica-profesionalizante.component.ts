import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DataTableComponent } from "../data-table/data-table.component";
import { PracticaProfesionalizanteCreateComponent } from "../practica-profesionalizante-create/practica-profesionalizante-create.component";
import { PracticaProfesionalizanteEditComponent } from "../practica-profesionalizante-edit/practica-profesionalizante-edit.component";
import { PracticaProfesionalizanteDeleteComponent } from "../practica-profesionalizante-delete/practica-profesionalizante-delete.component";
import { PracticaProfesionalizanteService } from '../services/practica-profesionalizante.service';
import { Observable } from 'rxjs';

@Component({
    selector: 'app-practica-profesionalizante',
    standalone: true,
    templateUrl: './practica-profesionalizante.component.html',
    styleUrl: './practica-profesionalizante.component.css',
    imports: [CommonModule, DataTableComponent, PracticaProfesionalizanteCreateComponent, PracticaProfesionalizanteEditComponent, PracticaProfesionalizanteDeleteComponent]
})
export class PracticaProfesionalizanteComponent {
    practicapro: any[] = [];
    practicapro$: Observable<any[]>;
    constructor( private practicaProfesionalizanteService: PracticaProfesionalizanteService){
        this.practicapro$= this.practicaProfesionalizanteService.practicaProfesionalizante();
      }
    ngOnInit(): void {
        this.practicapro$.subscribe({
          next: (value) => this.practicapro = value,
          error: (err) => console.log('Error:', err),
          complete: () => {
            console.log('Completed');
          }
        });
      };

}
