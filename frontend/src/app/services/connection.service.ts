import { Injectable } from "@angular/core";
import { HttpService } from "../core/services/http.service";
import { IConnection } from "../shared/models/IConnection";

@Injectable({
    providedIn: 'root',
})

export class ConnectionService {
    private readonly routePrefix = '/connections';

    constructor (private httpService: HttpService) {}

    public getConnections(marketId: number) {
        return this.httpService.getById<IConnection[]>(`${this.routePrefix}`,`${marketId}`);
    }
}