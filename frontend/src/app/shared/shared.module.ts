import { NgModule } from "@angular/core";
import { HeaderComponent } from './components/header/header.component';
import { MaterialModule } from "./material/material.module";
import { ConnectionService } from "../services/connection.service";
import { IspService } from "../services/isp.service";
import { MarketService } from "../services/market.service";

@NgModule({
    imports: [
        MaterialModule
    ],
    declarations: [
        HeaderComponent
    ],
    exports: [
        HeaderComponent,
        MaterialModule,
    ],
    providers:[
        ConnectionService,
        IspService,
        MarketService
    ]
})
export class SharedModule { }