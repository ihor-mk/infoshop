import { Component, Input, OnInit } from '@angular/core';
import { IspService } from 'src/app/services/isp.service';
import { IConnection } from 'src/app/shared/models/IConnection';
import { IIsp } from 'src/app/shared/models/IIsp';

@Component({
  selector: 'app-connection-card',
  templateUrl: './connection-card.component.html',
  styleUrls: ['./connection-card.component.sass']
})
export class ConnectionCardComponent implements OnInit {
  @Input() connection!: IConnection

  isp: IIsp = { name: '' }

  connectionType!: string

  constructor(private ispService: IspService) {}

  ngOnInit(): void {
    if (this.connection) {
      this.ispService.getIsp(this.connection.ispId).subscribe((data: IIsp) => {
        this.isp = data
      })
    }
  }

  getConnectionType() {
    switch (this.connection.type){
      case (1):
        return 'DHCP'
      case (2):
        return 'Static'
      case (3):
        return 'PPPoE'
      default:
        return ''
    }
  }
}
