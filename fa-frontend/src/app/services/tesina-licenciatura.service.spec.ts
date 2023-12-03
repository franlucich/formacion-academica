import { TestBed } from '@angular/core/testing';

import { TesinaLicenciaturaService } from './tesina-licenciatura.service';

describe('TesinaLicenciaturaService', () => {
  let service: TesinaLicenciaturaService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TesinaLicenciaturaService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
