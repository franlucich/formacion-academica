import { TestBed } from '@angular/core/testing';

import { PracticaSupervisadaService } from './practica-supervisada.service';

describe('PracticaSupervisadaService', () => {
  let service: PracticaSupervisadaService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PracticaSupervisadaService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
