import { TestBed } from '@angular/core/testing';

import { TesisPosgradoService } from './tesis-posgrado.service';

describe('TesisPosgradoService', () => {
  let service: TesisPosgradoService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TesisPosgradoService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
