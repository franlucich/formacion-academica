import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ApiService } from './api.service'; 

@Injectable({
  providedIn: 'root'
})
export class TesisPosgradoService {


  ultimoid: number =0;

  constructor(private api: ApiService) { }
  tesisPosgrado(): Observable<any[]>{
    return this.api.tesisPosgrado();
  }
  deleteTesisPosgrado(id: number){
    return this.api.deleteTesisPosgrado(id)
  }


}
