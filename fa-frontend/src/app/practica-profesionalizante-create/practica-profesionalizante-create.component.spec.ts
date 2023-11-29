import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PracticaProfesionalizanteCreateComponent } from './practica-profesionalizante-create.component';

describe('PracticaProfesionalizanteCreateComponent', () => {
  let component: PracticaProfesionalizanteCreateComponent;
  let fixture: ComponentFixture<PracticaProfesionalizanteCreateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PracticaProfesionalizanteCreateComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(PracticaProfesionalizanteCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
