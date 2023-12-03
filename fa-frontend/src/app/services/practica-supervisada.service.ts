import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ApiService } from './api.service';

@Injectable({
  providedIn: 'root'
})
export class PracticaSupervisadaService {

  constructor(private api: ApiService) { }
  practicaSupervisada(): Observable<any[]>{
    return this.api.practicaSupervisada();
  }
  deletePracticaSupervisada(id: number){
    return this.api.deletePracticaSupervisada(id)
  }
}
