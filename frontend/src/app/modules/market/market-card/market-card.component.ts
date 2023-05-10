import { Component, Input } from '@angular/core';
import { IMarket } from 'src/app/shared/models/IMarket';

@Component({
  selector: 'app-market-card',
  templateUrl: './market-card.component.html',
  styleUrls: ['./market-card.component.sass']
})
export class MarketCardComponent {
  @Input() market!: IMarket
}
