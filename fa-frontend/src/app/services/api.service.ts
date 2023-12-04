import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment.development';
import { Observable } from 'rxjs';


const API_URL = environment.apiUrl
@Injectable({
  providedIn: 'root'
})
export class ApiService {


  constructor(private httpClient:HttpClient) { }

  tesisPosgrado(): Observable<any[]>{
    return this.httpClient.get<any[]>(API_URL + "/api/tesisPosgrado");
  }
  deleteTesisPosgrado(id: number){
    return this.httpClient.delete(API_URL + '/api/tesisPosgrado/'+ id);
  }
  ensayoCatedra(): Observable<any[]>{
    return this.httpClient.get<any[]>(API_URL + "/api/ensayoCatedra");
  }
  crearEnsayoCatedra(ensayo: any): Observable<any>{
    return this.httpClient.post<any>(API_URL + "/api/ensayoCatedra", ensayo);
  }
  deleteEnsayoCatedra(id: number){
    return this.httpClient.delete(API_URL + '/api/ensayoCatedra/'+ id);
  }
  practicaProfesionalizante(): Observable<any[]>{
    return this.httpClient.get<any[]>(API_URL + "/api/PracticaProfesionalizante");
  }
  deletePracticaProfesionalizante(id: number){
    return this.httpClient.delete(API_URL + '/api/PracticaProfesionalizante/'+ id);
  }
  practicaSupervisada(): Observable<any[]>{
    return this.httpClient.get<any[]>(API_URL + "/api/practicaSupervisada");
  }
  deletePracticaSupervisada(id: number){
    return this.httpClient.delete(API_URL + '/api/practicaSupervisada/'+ id);
  }
  proyectoFinalIngenieria(): Observable<any[]>{
    return this.httpClient.get<any[]>(API_URL + "/api/ProyectoFinalIngenieria");
  }
  deleteProyectoFinalIngenieria(id: number){
    return this.httpClient.delete(API_URL + '/api/ProyectoFinalIngenieria/'+ id);
  }
  tesinaLicenciatura(): Observable<any[]>{
    return this.httpClient.get<any[]>(API_URL + "/api/TesinaLicenciatura");
  }
  deleteTesinaLicenciatura(id: number){
    return this.httpClient.delete(API_URL + '/api/TesinaLicenciatura/'+ id);
  }
  persona(): Observable<any[]>{
    return this.httpClient.get<any[]>(API_URL + "/api/general/persona");
  }
  facultad(): Observable<any[]>{
    return this.httpClient.get<any[]>(API_URL + "/api/general/facultad");
  }
}
