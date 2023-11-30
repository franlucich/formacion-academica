import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DataTableComponent } from "../data-table/data-table.component";

import { TesisPosgradoCreateComponent } from "../tesis-posgrado-create/tesis-posgrado-create.component";
import { TesisPosgradoEditComponent } from "../tesis-posgrado-edit/tesis-posgrado-edit.component";
import { TesisPosgradoDeleteComponent } from "../tesis-posgrado-delete/tesis-posgrado-delete.component";
import { TesisPosgrado } from '../tesis-posgrado';

@Component({
    selector: 'app-tesis-posgrado',
    standalone: true,
    templateUrl: './tesis-posgrado.component.html',
    styleUrl: './tesis-posgrado.component.css',
    imports: [CommonModule, DataTableComponent, TesisPosgradoCreateComponent, TesisPosgradoEditComponent, TesisPosgradoDeleteComponent]
})
export class TesisPosgradoComponent {
    tesis: TesisPosgrado[]=[];

    constructor(){
      this.tesis.push(
        { id: 1, titulo:"hola", nombre:"chau", apellido: "pepe", fechaini: new Date(0)},
        { id: 2, titulo:"hola", nombre:"chau", apellido: "pepe", fechaini: new Date(0)},
        { id: 3, titulo:"hola", nombre:"chau", apellido: "pepe", fechaini: new Date(0)},

      );
      }
    }
