import { Component } from '@angular/core';
import { HttpParams } from "@angular/common/http";
import { HttpClient } from "@angular/common/http";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})

export class AppComponent {
  title = 'app';
  difficulty: string;
  playermove: string;
  gamestate: number;
  aiGesture: number;
  errorMessage: string;
  gamestateMessage: string;
  aIMoveString: string;

  constructor(private http: HttpClient) {
  }

  selectDifficulty(difficulty: string) {
    this.difficulty = difficulty;
    console.log("Selected difficulty " + difficulty);
  }

  moveSelected(move: string) {
    this.playermove = move;
    console.log("Selected move " + move);
    this.sendRequest(move);
  }

  sendRequest(move: string) {

    let queryParams = new HttpParams();
    queryParams = queryParams.append("player", this.playermove);
    queryParams = queryParams.append("ailevel", this.difficulty);

    this.http.get<any>('https://localhost:44390/api/gamecontroller/PlayRockPaperScissors', {params:queryParams}).subscribe({
      next: data => {
        this.gamestate = data.gameState;
        this.aiGesture = data.aiGesture;
        console.log(this.gamestate);

        if (this.gamestate == 0)
          this.gamestateMessage = "You LOST";

        if (this.gamestate == 1)
          this.gamestateMessage = "DRAW";

        if (this.gamestate == 2)
          this.gamestateMessage = "You WON";

        if (this.aiGesture == 0)
          this.aIMoveString = "AI played ROCK";

        if (this.aiGesture == 1)
          this.aIMoveString = "AI played PAPER";

        if (this.aiGesture == 2)
          this.aIMoveString = "AI played SCISSORS";

      },
      error: error => {
        this.errorMessage = error.message;
        console.error('There was an error!', error);
      }
    })
  }
}
