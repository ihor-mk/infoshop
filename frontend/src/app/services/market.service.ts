import { HttpService } from "../core/services/http.service";
import { IMarket } from "../shared/models/IMarket";

export class MarketService {
    private readonly routePrefix = '/market';

    constructor (private httpService: HttpService) {}

    public getMarkets() {
        return this.httpService.get<IMarket[]>(`${this.routePrefix}`);
    }
}