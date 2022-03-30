import { EventEmitter, Output } from '@angular/core';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'difficulty',
  templateUrl: './difficulty-selection.component.html',
  styleUrls: ['./difficulty-selection.component.css']
})
export class DifficultySelectionComponent implements OnInit{

  selectedDifficulty: string = "easy";

  @Output() difficultySelected = new EventEmitter<string>();

  constructor() { }

  ngOnInit() {
    this.difficultySelected.emit(this.selectedDifficulty);
  }

  setDifficulty(difficulty: string): void {
    this.difficultySelected.emit(difficulty);
  }


}
