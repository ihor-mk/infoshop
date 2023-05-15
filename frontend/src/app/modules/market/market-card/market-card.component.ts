import { Component, Input } from '@angular/core';
import { MarketHelper } from 'src/app/helpers/market.helper';
import { ConnectionService } from 'src/app/services/connection.service';
import { IConnection } from 'src/app/shared/models/IConnection';
import { IMarket } from 'src/app/shared/models/IMarket';
import Utils from 'src/app/shared/data/region.utils';

@Component({
  selector: 'app-market-card',
  templateUrl: './market-card.component.html',
  styleUrls: ['./market-card.component.sass']
})
export class MarketCardComponent {
  @Input() market!: IMarket
  regionsList = Utils.regionsList

  constructor(
    private marketHelper: MarketHelper,
    private connectionService: ConnectionService){}

  openDetail() {
    this.marketHelper.currentMarket = this.market;
    
    this.connectionService.getConnections(this.market.id!).subscribe((data: IConnection[]) => {
      this.marketHelper.connections = data
  })
  }
}
