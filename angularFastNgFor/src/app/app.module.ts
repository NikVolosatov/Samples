import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

import { AppComponent } from './app.component';
import { PopoverHostComponent } from './components/popover-host/popover-host.component';
import { PopoverItemComponent } from './components/popover-item/popover-item.component';
import { LazyForDirective } from './directives/lazy-for.directive';

@NgModule({
  declarations: [
    AppComponent,
    PopoverHostComponent,
    PopoverItemComponent,
    LazyForDirective
  ],
  imports: [
    BrowserModule,
    NgbModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
