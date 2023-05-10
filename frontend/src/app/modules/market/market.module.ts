import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MarketComponent } from './market/market.component';
import { MarketsListComponent } from './markets-list/markets-list.component';



@NgModule({
  declarations: [
    MarketComponent,
    MarketsListComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    MarketsListComponent,
  ]
})
export class MarketModule { }
