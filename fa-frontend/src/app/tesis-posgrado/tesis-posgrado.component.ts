import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DataTableComponent } from "../data-table/data-table.component";

@Component({
    selector: 'app-tesis-posgrado',
    standalone: true,
    templateUrl: './tesis-posgrado.component.html',
    styleUrl: './tesis-posgrado.component.css',
    imports: [CommonModule, DataTableComponent]
})
export class TesisPosgradoComponent {

}
