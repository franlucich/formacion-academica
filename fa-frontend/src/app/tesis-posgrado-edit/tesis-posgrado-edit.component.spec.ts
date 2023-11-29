import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TesisPosgradoEditComponent } from './tesis-posgrado-edit.component';

describe('TesisPosgradoEditComponent', () => {
  let component: TesisPosgradoEditComponent;
  let fixture: ComponentFixture<TesisPosgradoEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [TesisPosgradoEditComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(TesisPosgradoEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
