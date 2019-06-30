import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  public key: string;

  constructor(private route: ActivatedRoute, private router: Router) { }

  public ngOnInit(): void {
    console.log('ngOnInit')

    this.route.queryParamMap.subscribe(map => {
      const key = map.get('key') || '0';
      console.log(key);
      this.key = key;
    });
  }

}
