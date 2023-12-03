import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TesinaLicenciaturaCreateComponent } from './tesina-licenciatura-create.component';

describe('TesinaLicenciaturaCreateComponent', () => {
  let component: TesinaLicenciaturaCreateComponent;
  let fixture: ComponentFixture<TesinaLicenciaturaCreateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [TesinaLicenciaturaCreateComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(TesinaLicenciaturaCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
