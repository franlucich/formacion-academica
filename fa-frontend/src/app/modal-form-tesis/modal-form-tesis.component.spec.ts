import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ModalFormTesisComponent } from './modal-form-tesis.component';

describe('ModalFormTesisComponent', () => {
  let component: ModalFormTesisComponent;
  let fixture: ComponentFixture<ModalFormTesisComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ModalFormTesisComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ModalFormTesisComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
