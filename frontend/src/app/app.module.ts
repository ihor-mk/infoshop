import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MainModule } from './modules/main/main.module';
import { SharedModule } from './shared/shared.module';
import { MarketModule } from './modules/market/market.module';
import { MarketHelper } from './helpers/market.helper';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MainModule,
    SharedModule,
    MarketModule
  ],
  providers: [MarketHelper],
  bootstrap: [AppComponent]
})
export class AppModule { }
