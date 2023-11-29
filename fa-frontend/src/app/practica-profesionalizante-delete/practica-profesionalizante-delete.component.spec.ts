import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PracticaProfesionalizanteDeleteComponent } from './practica-profesionalizante-delete.component';

describe('PracticaProfesionalizanteDeleteComponent', () => {
  let component: PracticaProfesionalizanteDeleteComponent;
  let fixture: ComponentFixture<PracticaProfesionalizanteDeleteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PracticaProfesionalizanteDeleteComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(PracticaProfesionalizanteDeleteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
