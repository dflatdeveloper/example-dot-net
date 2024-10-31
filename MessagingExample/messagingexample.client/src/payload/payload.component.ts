import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import { Payload } from './payload.type';
import { PayloadService } from './payload.service';


@Component({
  selector: 'payload-root',
  templateUrl: './payload.component.html',
  styleUrl: './payload.component.css'
})
export class PayloadComponent {
  payloads$: Observable<Payload[]>;

  constructor(payloadService: PayloadService) {
    this.payloads$ = payloadService.getPayloads();
  }
}
