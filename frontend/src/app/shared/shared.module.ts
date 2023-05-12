import { NgModule } from "@angular/core";
import { HeaderComponent } from './components/header/header.component';
import { MaterialModule } from "./material/material.module";

@NgModule({
    imports: [
        MaterialModule
    ],
    declarations: [
        HeaderComponent
    ],
    exports: [
        HeaderComponent,
        MaterialModule
    ],
})
export class SharedModule { }