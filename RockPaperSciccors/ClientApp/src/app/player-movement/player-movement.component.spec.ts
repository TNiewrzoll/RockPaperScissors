import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PlayerMovementComponent } from './player-movement.component';

describe('PlayerMovementComponent', () => {
  let component: PlayerMovementComponent;
  let fixture: ComponentFixture<PlayerMovementComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PlayerMovementComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PlayerMovementComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
