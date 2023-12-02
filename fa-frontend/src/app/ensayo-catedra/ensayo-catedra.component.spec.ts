import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EnsayoCatedraComponent } from './ensayo-catedra.component';

describe('EnsayoCatedraComponent', () => {
  let component: EnsayoCatedraComponent;
  let fixture: ComponentFixture<EnsayoCatedraComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [EnsayoCatedraComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(EnsayoCatedraComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
