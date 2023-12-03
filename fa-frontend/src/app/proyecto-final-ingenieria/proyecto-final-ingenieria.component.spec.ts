import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProyectoFinalIngenieriaComponent } from './proyecto-final-ingenieria.component';

describe('ProyectoFinalIngenieriaComponent', () => {
  let component: ProyectoFinalIngenieriaComponent;
  let fixture: ComponentFixture<ProyectoFinalIngenieriaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ProyectoFinalIngenieriaComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ProyectoFinalIngenieriaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
