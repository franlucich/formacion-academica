import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment.development';
import { Observable } from 'rxjs';
import { TesisPosgrado } from '../tesis-posgrado';


const API_URL = environment.apiUrl + "/api/formacionacademica"
@Injectable({
  providedIn: 'root'
})
export class ApiService {


  constructor(private httpClient:HttpClient) { }

  tesis(): Observable<TesisPosgrado[]>{
    return this.httpClient.get<TesisPosgrado[]>(API_URL);
  }

}
