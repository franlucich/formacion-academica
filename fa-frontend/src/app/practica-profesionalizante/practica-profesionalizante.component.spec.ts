import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PracticaProfesionalizanteComponent } from './practica-profesionalizante.component';

describe('PracticaProfesionalizanteComponent', () => {
  let component: PracticaProfesionalizanteComponent;
  let fixture: ComponentFixture<PracticaProfesionalizanteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PracticaProfesionalizanteComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(PracticaProfesionalizanteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
