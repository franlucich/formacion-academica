import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TesisPosgradoDeleteComponent } from './tesis-posgrado-delete.component';

describe('TesisPosgradoDeleteComponent', () => {
  let component: TesisPosgradoDeleteComponent;
  let fixture: ComponentFixture<TesisPosgradoDeleteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [TesisPosgradoDeleteComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(TesisPosgradoDeleteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
