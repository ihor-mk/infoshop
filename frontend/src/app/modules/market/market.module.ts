import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MarketsListComponent } from './markets-list/markets-list.component';
import { MarketCardComponent } from './market-card/market-card.component';



@NgModule({
  declarations: [
    MarketsListComponent,
    MarketCardComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    MarketsListComponent,
    MarketCardComponent,
  ]
})
export class MarketModule { }
