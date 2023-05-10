import { Injectable } from "@angular/core";
import { HttpService } from "../core/services/http.service";
import { IMarket } from "../shared/models/IMarket";

@Injectable({
    providedIn: 'root',
})

export class MarketService {
    private readonly routePrefix = '/markets';

    constructor (private httpService: HttpService) {}

    public getMarkets() {
        return this.httpService.get<IMarket[]>(`${this.routePrefix}`);
    }
}