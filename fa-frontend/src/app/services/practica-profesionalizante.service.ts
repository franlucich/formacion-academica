import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ApiService } from './api.service';

@Injectable({
  providedIn: 'root'
})
export class PracticaProfesionalizanteService {

  constructor(private api: ApiService) { }
  practicaProfesionalizante(): Observable<any[]>{
    return this.api.practicaProfesionalizante();
  }
  deletePracticaProfesionalizante(id: number){
    return this.api.deletePracticaProfesionalizante(id)
  }
}
