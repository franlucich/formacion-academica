import { Injectable } from '@angular/core';
import { TesisPosgrado } from '../tesis-posgrado';

@Injectable({
  providedIn: 'root'
})
export class TesisPosgradoService {

  tesis: TesisPosgrado[] = [];
  ultimoid: number =0;

  constructor() { }

  crearTesis(tesis:TesisPosgrado): TesisPosgradoService {
    tesis.id == ++this.ultimoid;
    this.tesis.push(tesis);
    return this;
  }

  get Tesis(){
    return this.tesis;
  }
}
