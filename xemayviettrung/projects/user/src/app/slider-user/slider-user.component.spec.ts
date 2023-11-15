/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { SliderUserComponent } from './slider-user.component';

describe('SliderUserComponent', () => {
  let component: SliderUserComponent;
  let fixture: ComponentFixture<SliderUserComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SliderUserComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SliderUserComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
