import { Injectable } from "@angular/core";
import { HttpService } from "../core/services/http.service";
import { IConnection } from "../shared/models/IConnection";
import { IIsp } from "../shared/models/IIsp";

@Injectable({
    providedIn: 'root',
})

export class IspService {
    private readonly routePrefix = '/isps';

    constructor (private httpService: HttpService) {}

    public getIsp(ispId: number) {
        return this.httpService.getById<IIsp>(`${this.routePrefix}`,`${ispId}`);
    }
}