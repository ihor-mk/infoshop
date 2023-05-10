import { Component, OnInit } from '@angular/core';
import { MarketService } from 'src/app/services/market.service';
import { IMarket } from 'src/app/shared/models/IMarket';

@Component({
  selector: 'app-markets-list',
  templateUrl: './markets-list.component.html',
  styleUrls: ['./markets-list.component.sass']
})
export class MarketsListComponent implements OnInit {
  markets: IMarket[] = []

  constructor(private marketService: MarketService) {}

  ngOnInit(): void {
    this.marketService.getMarkets().subscribe((data: IMarket[]) => {
        this.markets = data;
        console.log(this.markets);
    })
  }

}
