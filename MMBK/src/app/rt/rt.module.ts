import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RtComponent } from './rt.component';
import { NavbarComponent } from './navbar/navbar.component';
import { RtRoutingModule } from './rt-routing.module';
import { SidebarsComponent } from './navbar/sidebars/sidebars.component';
import { TopNavbarComponent } from './top-navbar/top-navbar.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { FlashComponent } from './flash/flash.component';



@NgModule({
  declarations: [
    RtComponent,
    NavbarComponent,
    SidebarsComponent,
    TopNavbarComponent,
    DashboardComponent,
    FlashComponent
  ],
  imports: [
    CommonModule,
    // Routing
    RtRoutingModule,
  ]
})
export class RtModule { }
