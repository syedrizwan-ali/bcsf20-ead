import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CityViewComponent } from './city-view.component';

describe('CityViewComponent', () => {
  let component: CityViewComponent;
  let fixture: ComponentFixture<CityViewComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CityViewComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CityViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
