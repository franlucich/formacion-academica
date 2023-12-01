import { Injectable } from '@angular/core';
import { TesisPosgrado } from '../tesis-posgrado';
import { Observable } from 'rxjs';
import { ApiService } from './api.service'; 

@Injectable({
  providedIn: 'root'
})
export class TesisPosgradoService {


  ultimoid: number =0;

  constructor(private api: ApiService) { }
  tesis(): Observable<TesisPosgrado[]>{

    return this.api.tesis();
  }


}
