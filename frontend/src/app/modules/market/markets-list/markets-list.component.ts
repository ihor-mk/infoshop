import { Component, OnInit } from '@angular/core';
import { MarketHelper } from 'src/app/helpers/market.helper';
import { ConnectionService } from 'src/app/services/connection.service';
import { MarketService } from 'src/app/services/market.service';
import { IConnection } from 'src/app/shared/models/IConnection';
import { IMarket } from 'src/app/shared/models/IMarket';

@Component({
  selector: 'app-markets-list',
  templateUrl: './markets-list.component.html',
  styleUrls: ['./markets-list.component.sass']
})
export class MarketsListComponent implements OnInit {
  markets: IMarket[] = []

  constructor(
    private marketService: MarketService,
    private marketHelper: MarketHelper,
    private connectionService: ConnectionService
      ) {}

  ngOnInit(): void {
    this.marketService.getMarkets().subscribe((data: IMarket[]) => {
        this.markets = data;
        this.marketHelper.currentMarket = this.markets[0]

        if (this.markets[0]) {
        this.connectionService.getConnections(this.markets[0].id!).subscribe((data: IConnection[]) => {
          this.marketHelper.connections = data
        })
      }
    })
  }

}
