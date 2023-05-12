import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MainPageComponent } from './main-page/main-page.component';
import { MainRoutingModule } from './main-routing.module';
import { SharedModule } from "../../shared/shared.module";
import { MarketModule } from '../market/market.module';
import { ConnectionModule } from '../connection/connection.module';
import { CoreModule } from 'src/app/core/core.module';

@NgModule({
    declarations: [
        MainPageComponent
    ],
    imports: [
        CommonModule,
        MainRoutingModule,
        SharedModule,
        MarketModule,
        ConnectionModule,
        CoreModule
    ]
})

export class MainModule { }
