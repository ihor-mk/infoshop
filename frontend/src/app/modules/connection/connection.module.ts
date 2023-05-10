import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ConnectionsListComponent } from './connections-list/connections-list.component';
import { ConnectionCardComponent } from './connection-card/connection-card.component';



@NgModule({
  declarations: [
    ConnectionsListComponent,
    ConnectionCardComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    ConnectionsListComponent
  ]
})
export class ConnectionModule { }
