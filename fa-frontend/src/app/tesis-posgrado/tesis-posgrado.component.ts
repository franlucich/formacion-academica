import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DataTableComponent } from "../data-table/data-table.component";

import { TesisPosgradoCreateComponent } from "../tesis-posgrado-create/tesis-posgrado-create.component";
import { TesisPosgradoEditComponent } from "../tesis-posgrado-edit/tesis-posgrado-edit.component";
import { TesisPosgradoDeleteComponent } from "../tesis-posgrado-delete/tesis-posgrado-delete.component";

import { Observable } from 'rxjs';
import { TesisPosgradoService } from '../services/tesis-posgrado.service';

@Component({
    selector: 'app-tesis-posgrado',
    standalone: true,
    templateUrl: './tesis-posgrado.component.html',
    styleUrl: './tesis-posgrado.component.css',
    imports: [CommonModule, DataTableComponent, TesisPosgradoCreateComponent, TesisPosgradoEditComponent, TesisPosgradoDeleteComponent]
})
export class TesisPosgradoComponent {
    tesis: any[]=[];
    tesis$: Observable<any[]>;
    constructor( private tesisposgradoService: TesisPosgradoService){
        this.tesis$= this.tesisposgradoService.tesisPosgrado();
      }
    ngOnInit(): void {
        this.tesis$.subscribe({
          next: (value) => this.tesis = value,
          error: (err) => console.log('Error:', err),
          complete: () => {
            console.log('Completed');
          }
        });
      };
}
