import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AboutRoutingModule } from './about.module.routing';
import { AboutComponent } from './components/about/about.component';

@NgModule({
  declarations: [AboutComponent ],
  imports: [
    CommonModule,
    AboutRoutingModule
  ]
})
export class AboutModule { }
