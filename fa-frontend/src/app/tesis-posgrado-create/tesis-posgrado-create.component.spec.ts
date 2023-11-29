import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TesisPosgradoCreateComponent } from './tesis-posgrado-create.component';

describe('TesisPosgradoCreateComponent', () => {
  let component: TesisPosgradoCreateComponent;
  let fixture: ComponentFixture<TesisPosgradoCreateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [TesisPosgradoCreateComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(TesisPosgradoCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
