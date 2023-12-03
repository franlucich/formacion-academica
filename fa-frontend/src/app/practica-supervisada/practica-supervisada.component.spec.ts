import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PracticaSupervisadaComponent } from './practica-supervisada.component';

describe('PracticaSupervisadaComponent', () => {
  let component: PracticaSupervisadaComponent;
  let fixture: ComponentFixture<PracticaSupervisadaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PracticaSupervisadaComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(PracticaSupervisadaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
