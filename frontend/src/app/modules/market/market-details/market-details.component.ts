import { Component } from '@angular/core';
import { MarketHelper } from 'src/app/helpers/market.helper';
import Utils from 'src/app/shared/data/region.utils';

@Component({
  selector: 'app-market-details',
  templateUrl: './market-details.component.html',
  styleUrls: ['./market-details.component.sass'],
})
export class MarketDetailsComponent {
  market = this.marketHelper.currentMarket
  regionsList = Utils.regionsList

  constructor(public marketHelper: MarketHelper){
    this.market = this.marketHelper.currentMarket
  }
}
