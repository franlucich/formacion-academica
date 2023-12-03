import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ApiService } from './api.service';

@Injectable({
  providedIn: 'root'
})
export class ProyectoFinalIngenieriaService {

  constructor(private api: ApiService) { }
  proyectoFinalIngenieria(): Observable<any[]>{
    return this.api.proyectoFinalIngenieria();
  }
  deleteProyectoFinalIngenieria(id: number){
    return this.api.deleteProyectoFinalIngenieria(id)
  }
}
