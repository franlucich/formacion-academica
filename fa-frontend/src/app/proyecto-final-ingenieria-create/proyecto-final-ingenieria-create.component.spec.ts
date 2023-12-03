import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProyectoFinalIngenieriaCreateComponent } from './proyecto-final-ingenieria-create.component';

describe('ProyectoFinalIngenieriaCreateComponent', () => {
  let component: ProyectoFinalIngenieriaCreateComponent;
  let fixture: ComponentFixture<ProyectoFinalIngenieriaCreateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ProyectoFinalIngenieriaCreateComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ProyectoFinalIngenieriaCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
