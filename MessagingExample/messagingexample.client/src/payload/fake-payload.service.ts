import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Payload } from './payload.type';
import { PAYLOADS } from './payload.mock';

@Injectable({
  providedIn: 'root',
})
export class FakePayloadService {
  constructor() { }

  getPayloads(): Observable<Payload[]> {
    return of(PAYLOADS);
  }
}
