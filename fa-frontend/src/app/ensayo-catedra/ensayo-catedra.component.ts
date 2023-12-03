import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DataTableComponent } from "../data-table/data-table.component";
import { EnsayoCatedraCreateComponent } from "../ensayo-catedra-create/ensayo-catedra-create.component";
import { EnsayoCatedraEditComponent } from "../ensayo-catedra-edit/ensayo-catedra-edit.component";
import { EnsayoCatedraDeleteComponent } from "../ensayo-catedra-delete/ensayo-catedra-delete.component";
import { AnyAaaaRecord, AnyCnameRecord } from 'dns';
import { Observable } from 'rxjs';
import { EnsayoCatedraService } from '../services/ensayo-catedra.service';

@Component({
    selector: 'app-ensayo-catedra',
    standalone: true,
    templateUrl: './ensayo-catedra.component.html',
    styleUrl: './ensayo-catedra.component.css',
    imports: [CommonModule, DataTableComponent, EnsayoCatedraCreateComponent, EnsayoCatedraEditComponent, EnsayoCatedraDeleteComponent]
})
export class EnsayoCatedraComponent {
    ensayo: any[]=[];
    ensayo$: Observable<any[]>;
    constructor( private ensayoCatedraService: EnsayoCatedraService){
        this.ensayo$= this.ensayoCatedraService.ensayoCatedra();
      }
    ngOnInit(): void {
        this.ensayo$.subscribe({
          next: (value) => this.ensayo = value,
          error: (err) => console.log('Error:', err),
          complete: () => {
            console.log('Completed');
          }
        });
      };

}
