import { Component } from '@angular/core';
import { MarketHelper } from 'src/app/helpers/market.helper';

@Component({
  selector: 'app-connections-list',
  templateUrl: './connections-list.component.html',
  styleUrls: ['./connections-list.component.sass']
})
export class ConnectionsListComponent {
  constructor(public marketHelper: MarketHelper) {  }

}
