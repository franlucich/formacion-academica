import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DataTableComponent } from "../data-table/data-table.component";
import { TesinaLicenciaturaCreateComponent } from "../tesina-licenciatura-create/tesina-licenciatura-create.component";
import { TesinaLicenciaturaService } from '../services/tesina-licenciatura.service';
import { Observable } from 'rxjs';

@Component({
    selector: 'app-tesina-licenciatura',
    standalone: true,
    templateUrl: './tesina-licenciatura.component.html',
    styleUrl: './tesina-licenciatura.component.css',
    imports: [CommonModule, DataTableComponent, TesinaLicenciaturaCreateComponent]
})
export class TesinaLicenciaturaComponent {
    tesina: any[] = [];
    tesina$: Observable<any[]>;
    constructor( private tesinaLicenciaturaService: TesinaLicenciaturaService){
        this.tesina$= this.tesinaLicenciaturaService.tesinaLicenciatura();
      }
    ngOnInit(): void {
        this.tesina$.subscribe({
          next: (value) => this.tesina = value,
          error: (err) => console.log('Error:', err),
          complete: () => {
            console.log('Completed');
          }
        });
      };


}
