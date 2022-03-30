import { Component, EventEmitter, OnInit, Output } from '@angular/core';

@Component({
  selector: 'player-movement',
  templateUrl: './player-movement.component.html',
  styleUrls: ['./player-movement.component.css']
})
export class PlayerMovementComponent  {

  @Output() moveSelected = new EventEmitter<string>();

  constructor() { }

  setPlayerMove(difficulty: string): void {
    this.moveSelected.emit(difficulty);
  }
}
