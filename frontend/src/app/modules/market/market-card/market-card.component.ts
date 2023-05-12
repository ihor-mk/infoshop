import { Component, Input } from '@angular/core';
import { MarketHelper } from 'src/app/helpers/market.helper';
import { IMarket } from 'src/app/shared/models/IMarket';

@Component({
  selector: 'app-market-card',
  templateUrl: './market-card.component.html',
  styleUrls: ['./market-card.component.sass']
})
export class MarketCardComponent {
  @Input() market!: IMarket
  constructor(private marketHelper: MarketHelper){}

  openDetail() {
    this.marketHelper.currentMarket = this.market;
  }
}
