import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  public data: string[] = [];

  title = 'ie-memory';

  constructor() {
    for (let i = 0; i < 1000; i++) {
      const num = new Date().getTime() * Math.random() * 10000;
      this.data.push(num.toString(10));
    }
  }
}
