import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TesinaLicenciaturaComponent } from './tesina-licenciatura.component';

describe('TesinaLicenciaturaComponent', () => {
  let component: TesinaLicenciaturaComponent;
  let fixture: ComponentFixture<TesinaLicenciaturaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [TesinaLicenciaturaComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(TesinaLicenciaturaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
