import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MainPageComponent } from './main-page/main-page.component';
import { MainRoutingModule } from './main-routing.module';
import { SharedModule } from "../../shared/shared.module";

@NgModule({
    declarations: [
        MainPageComponent
    ],
    imports: [
        CommonModule,
        MainRoutingModule,
        SharedModule
    ]
})

export class MainModule { }
