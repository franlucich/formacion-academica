import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ApiService } from './api.service';

@Injectable({
  providedIn: 'root'
})
export class PersonaService {

  constructor(private api: ApiService) { }
  personas(): Observable<any[]>{
    return this.api.persona();
  }
  facultad(): Observable<any[]>{
    return this.api.facultad();
  }
}