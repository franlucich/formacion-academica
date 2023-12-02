import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EnsayoCatedraDeleteComponent } from './ensayo-catedra-delete.component';

describe('EnsayoCatedraDeleteComponent', () => {
  let component: EnsayoCatedraDeleteComponent;
  let fixture: ComponentFixture<EnsayoCatedraDeleteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [EnsayoCatedraDeleteComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(EnsayoCatedraDeleteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
