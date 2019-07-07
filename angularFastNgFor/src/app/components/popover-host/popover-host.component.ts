import { Component, OnInit, ViewChild } from '@angular/core';
import { NgbPopover } from '@ng-bootstrap/ng-bootstrap';

interface IItem {
  key: string | number;
  name: string;
  data: string;
}

@Component({
  selector: 'app-popover-host',
  templateUrl: './popover-host.component.html',
  styleUrls: ['./popover-host.component.css']
})
export class PopoverHostComponent implements OnInit {

  @ViewChild('popover', { static: true }) public popover: NgbPopover;
  public items: IItem[] = [];
  constructor() { }

  ngOnInit() {
    this.items = this.createItems();
  }
  private createItems(): IItem[] {
    const items: IItem[] = [];
    for (let i = 0; i < 100000; i++) {
      const element = items[i];
      items.push({
        key: i,
        name: `Name ${i}`,
        data: `Data ${i}`
      });
    }
    return items;
  }

  public onClick(event: Event): void {
    this.popover.open();
  }

}
