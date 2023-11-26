import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TesisPosgradoComponent } from './tesis-posgrado.component';

describe('TesisPosgradoComponent', () => {
  let component: TesisPosgradoComponent;
  let fixture: ComponentFixture<TesisPosgradoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [TesisPosgradoComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(TesisPosgradoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
