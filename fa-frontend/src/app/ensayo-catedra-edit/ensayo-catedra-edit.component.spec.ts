import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EnsayoCatedraEditComponent } from './ensayo-catedra-edit.component';

describe('EnsayoCatedraEditComponent', () => {
  let component: EnsayoCatedraEditComponent;
  let fixture: ComponentFixture<EnsayoCatedraEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [EnsayoCatedraEditComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(EnsayoCatedraEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
