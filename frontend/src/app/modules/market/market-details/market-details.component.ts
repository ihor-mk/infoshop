import { Component, Input } from '@angular/core';
import { MarketHelper } from 'src/app/helpers/market.helper';
import { IMarket } from 'src/app/shared/models/IMarket';

@Component({
  selector: 'app-market-details',
  templateUrl: './market-details.component.html',
  styleUrls: ['./market-details.component.sass']
})
export class MarketDetailsComponent {
  @Input() market!: IMarket

  constructor(public marketHelper: MarketHelper){
    this.market = this.marketHelper.currentMarket
  }


}
