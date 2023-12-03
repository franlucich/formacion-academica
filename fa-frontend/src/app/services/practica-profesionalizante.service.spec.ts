import { TestBed } from '@angular/core/testing';

import { PracticaProfesionalizanteService } from './practica-profesionalizante.service';

describe('PracticaProfesionalizanteService', () => {
  let service: PracticaProfesionalizanteService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PracticaProfesionalizanteService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
