import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EnsayoCatedraService } from '../services/ensayo-catedra.service';
import { FormGroup, FormControl, ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-ensayo-catedra-create',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './ensayo-catedra-create.component.html',
  styleUrl: './ensayo-catedra-create.component.css'
})
export class EnsayoCatedraCreateComponent {

  nuevoEnsayo= new FormGroup({
    titulo: new FormControl(''),
    fechaIni: new FormControl(''),
  });

  constructor( private ensayoCatedraService: EnsayoCatedraService){}

  crearEnsayoCatedra(){
    console.log(this.nuevoEnsayo.value)
    this.ensayoCatedraService.crearEnsayoCatedra(this.nuevoEnsayo.value).subscribe();
  }
}
