import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MarketsListComponent } from './markets-list/markets-list.component';
import { MarketCardComponent } from './market-card/market-card.component';
import { MarketDetailsComponent } from './market-details/market-details.component';



@NgModule({
  declarations: [
    MarketsListComponent,
    MarketCardComponent,
    MarketDetailsComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    MarketsListComponent,
    MarketCardComponent,
    MarketDetailsComponent
  ]
})
export class MarketModule { }
