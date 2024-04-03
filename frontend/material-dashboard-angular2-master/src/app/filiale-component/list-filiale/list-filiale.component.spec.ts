import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListFilialeComponent } from './list-filiale.component';

describe('ListFilialeComponent', () => {
  let component: ListFilialeComponent;
  let fixture: ComponentFixture<ListFilialeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListFilialeComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListFilialeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
