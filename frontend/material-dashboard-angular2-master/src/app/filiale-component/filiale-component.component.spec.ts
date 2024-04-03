import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FilialeComponentComponent } from './filiale-component.component';

describe('FilialeComponentComponent', () => {
  let component: FilialeComponentComponent;
  let fixture: ComponentFixture<FilialeComponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FilialeComponentComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FilialeComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
