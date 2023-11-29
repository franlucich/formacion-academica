import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DataTableComponent } from "../data-table/data-table.component";
import { PracticaProfesionalizanteCreateComponent } from "../practica-profesionalizante-create/practica-profesionalizante-create.component";
import { PracticaProfesionalizanteEditComponent } from "../practica-profesionalizante-edit/practica-profesionalizante-edit.component";
import { PracticaProfesionalizanteDeleteComponent } from "../practica-profesionalizante-delete/practica-profesionalizante-delete.component";

@Component({
    selector: 'app-practica-profesionalizante',
    standalone: true,
    templateUrl: './practica-profesionalizante.component.html',
    styleUrl: './practica-profesionalizante.component.css',
    imports: [CommonModule, DataTableComponent, PracticaProfesionalizanteCreateComponent, PracticaProfesionalizanteEditComponent, PracticaProfesionalizanteDeleteComponent]
})
export class PracticaProfesionalizanteComponent {

}
