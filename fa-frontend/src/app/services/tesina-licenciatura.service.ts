import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ApiService } from './api.service';

@Injectable({
  providedIn: 'root'
})
export class TesinaLicenciaturaService {

  constructor(private api: ApiService) { }
  tesinaLicenciatura(): Observable<any[]>{
    return this.api.tesinaLicenciatura();
  }
  deleteTesinaLicenciatura(id: number){
    return this.api.deleteTesinaLicenciatura(id)
  }

}
