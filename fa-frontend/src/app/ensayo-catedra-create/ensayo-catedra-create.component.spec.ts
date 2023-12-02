import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EnsayoCatedraCreateComponent } from './ensayo-catedra-create.component';

describe('EnsayoCatedraCreateComponent', () => {
  let component: EnsayoCatedraCreateComponent;
  let fixture: ComponentFixture<EnsayoCatedraCreateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [EnsayoCatedraCreateComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(EnsayoCatedraCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
