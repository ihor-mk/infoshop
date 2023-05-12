import { Injectable } from "@angular/core";
import { IMarket } from "../shared/models/IMarket";
import { IConnection } from "../shared/models/IConnection";

@Injectable({
    providedIn: 'root',
})

export class MarketHelper {
    public currentMarket!: IMarket
    public connections!: IConnection[] 
} 