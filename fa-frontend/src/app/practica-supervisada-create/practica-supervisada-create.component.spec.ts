import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PracticaSupervisadaCreateComponent } from './practica-supervisada-create.component';

describe('PracticaSupervisadaCreateComponent', () => {
  let component: PracticaSupervisadaCreateComponent;
  let fixture: ComponentFixture<PracticaSupervisadaCreateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PracticaSupervisadaCreateComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(PracticaSupervisadaCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
