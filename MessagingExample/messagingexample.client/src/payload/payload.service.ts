import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Payload } from './payload.type';


@Injectable({
  providedIn: 'root'
})
export class PayloadService {

  constructor(private http: HttpClient) { }

  getPayloads(): Observable<Payload[]> {
    return this.http.get<Payload[]>('/payloads');
  }
}
