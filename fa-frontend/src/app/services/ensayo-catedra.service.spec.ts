import { TestBed } from '@angular/core/testing';

import { EnsayoCatedraService } from './ensayo-catedra.service';

describe('EnsayoCatedraService', () => {
  let service: EnsayoCatedraService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(EnsayoCatedraService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
