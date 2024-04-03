import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddOrEditFilialeComponent } from './add-or-edit-filiale.component';

describe('AddOrEditFilialeComponent', () => {
  let component: AddOrEditFilialeComponent;
  let fixture: ComponentFixture<AddOrEditFilialeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddOrEditFilialeComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddOrEditFilialeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
