import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-popover-item',
  templateUrl: './popover-item.component.html',
  styleUrls: ['./popover-item.component.css']
})
export class PopoverItemComponent implements OnInit {
  @Input() public name: string;
  @Input() public data: string;

  constructor() { }

  ngOnInit() {
  }

}
