import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ApiService } from './api.service';

@Injectable({
  providedIn: 'root'
})
export class EnsayoCatedraService {

  constructor(private api: ApiService) { }
  ensayoCatedra(): Observable<any[]>{
    return this.api.ensayoCatedra();
  }
  crearEnsayoCatedra(ensayo: any): Observable<any>{
    return this.api.crearEnsayoCatedra(ensayo)
  }
  deleteEnsayoCatedra(id: number){
    return this.api.deleteEnsayoCatedra(id)
  }
}

