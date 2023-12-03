import { TestBed } from '@angular/core/testing';

import { ProyectoFinalIngenieriaService } from './proyecto-final-ingenieria.service';

describe('ProyectoFinalIngenieriaService', () => {
  let service: ProyectoFinalIngenieriaService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ProyectoFinalIngenieriaService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
