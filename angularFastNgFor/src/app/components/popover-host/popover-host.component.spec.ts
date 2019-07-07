import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PopoverHostComponent } from './popover-host.component';

describe('PopoverHostComponent', () => {
  let component: PopoverHostComponent;
  let fixture: ComponentFixture<PopoverHostComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PopoverHostComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PopoverHostComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
