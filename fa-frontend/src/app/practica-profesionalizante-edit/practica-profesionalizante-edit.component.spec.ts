import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PracticaProfesionalizanteEditComponent } from './practica-profesionalizante-edit.component';

describe('PracticaProfesionalizanteEditComponent', () => {
  let component: PracticaProfesionalizanteEditComponent;
  let fixture: ComponentFixture<PracticaProfesionalizanteEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PracticaProfesionalizanteEditComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(PracticaProfesionalizanteEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
