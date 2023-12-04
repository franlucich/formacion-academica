import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EnsayoCatedraService } from '../services/ensayo-catedra.service';
import { FormGroup, FormControl, ReactiveFormsModule } from '@angular/forms';
import { PersonaService } from '../services/persona.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-ensayo-catedra-create',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './ensayo-catedra-create.component.html',
  styleUrl: './ensayo-catedra-create.component.css'
})
export class EnsayoCatedraCreateComponent {

  personas: any[] = []
  personas$: Observable<any[]>;
  facultades: any[] = [];
  facultades$: Observable<any[]>;

  nuevoEnsayo= new FormGroup({
    titulo: new FormControl(''),
    fechaInicio: new FormControl(''),
    fechaFin: new FormControl(''),
    pkFacultad: new FormControl(''),
    //pkPersona: new FormControl(''),
    persona: new FormControl([]),
  });

  constructor( private ensayoCatedraService: EnsayoCatedraService,
    private personaService: PersonaService) {
    this.personas$= this.personaService.personas();
    this.facultades$= this.personaService.facultad();
  }
  ngOnInit(): void {
    this.personas$.subscribe({
      next: (value) => this.personas = value,
      error: (err) => console.log('Error:', err),
      complete: () => {
        console.log('Completed');
      }
    });
    this.facultades$.subscribe({
      next: (value) => this.facultades = value,
      error: (err) => console.log('Error:', err),
      complete: () => {
        console.log('Completed');
      }
    });
  };

  crearEnsayoCatedra(){
    console.log(this.nuevoEnsayo.value)
    this.ensayoCatedraService.crearEnsayoCatedra(this.nuevoEnsayo.value).subscribe({complete: ()=> location.reload()});
    
  }
}
