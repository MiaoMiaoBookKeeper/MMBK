import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RtModule } from './rt/rt.module';
import { HttpClientModule } from '@angular/common/http'; // <-- Import here


@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,

    // module
    RtModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
