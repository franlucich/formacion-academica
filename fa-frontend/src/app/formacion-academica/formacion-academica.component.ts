import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SidebarComponent } from "../sidebar/sidebar.component";
import { DataTableComponent } from "../data-table/data-table.component";
import { RouterOutlet, RouterLink, RouterLinkActive } from '@angular/router';

@Component({
    selector: 'app-formacion-academica',
    standalone: true,
    templateUrl: './formacion-academica.component.html',
    styleUrl: './formacion-academica.component.css',
    imports: [CommonModule, SidebarComponent, DataTableComponent, RouterOutlet, RouterLink, RouterLinkActive]
})
export class FormacionAcademicaComponent {

}
