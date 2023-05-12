import { Injectable } from "@angular/core";
import { IMarket } from "../shared/models/IMarket";

@Injectable({
    providedIn: 'root',
})

export class MarketHelper {
    public currentMarket!: IMarket
} 