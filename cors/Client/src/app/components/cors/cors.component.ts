import { Component, OnInit } from '@angular/core';
import { CorsService } from 'src/app/services/cors/cors.service';

@Component({
  selector: 'app-cors',
  templateUrl: './cors.component.html',
  styleUrls: ['./cors.component.css']
})
export class CorsComponent implements OnInit {

  public data: any;

  constructor(private service: CorsService) { }

  ngOnInit() {
    this.service.getData().subscribe(data => this.data = data);
  }

}
