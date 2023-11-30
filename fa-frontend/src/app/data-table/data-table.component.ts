import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TesisPosgrado } from '../tesis-posgrado';

@Component({
  selector: 'app-data-table',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './data-table.component.html',
  styleUrl: './data-table.component.css'
})
export class DataTableComponent {

    @Input() items!: TesisPosgrado[];

    }
