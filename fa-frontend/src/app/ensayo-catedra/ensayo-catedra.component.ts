import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DataTableComponent } from "../data-table/data-table.component";
import { EnsayoCatedraCreateComponent } from "../ensayo-catedra-create/ensayo-catedra-create.component";
import { EnsayoCatedraEditComponent } from "../ensayo-catedra-edit/ensayo-catedra-edit.component";
import { EnsayoCatedraDeleteComponent } from "../ensayo-catedra-delete/ensayo-catedra-delete.component";

@Component({
    selector: 'app-ensayo-catedra',
    standalone: true,
    templateUrl: './ensayo-catedra.component.html',
    styleUrl: './ensayo-catedra.component.css',
    imports: [CommonModule, DataTableComponent, EnsayoCatedraCreateComponent, EnsayoCatedraEditComponent, EnsayoCatedraDeleteComponent]
})
export class EnsayoCatedraComponent {

}
