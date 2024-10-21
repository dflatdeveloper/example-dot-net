import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

interface Header {
  data1: string;
  data2: string;

}

interface Payload {
  headers: Header[];
  content: string;
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  public payloads: Payload[] = [];

  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.getPayloads();
  }

  getPayloads() {
    this.http.get<Payload[]>('/message').subscribe(
      (result) => {
        this.payloads = result;
      },
      (error) => {
        console.error(error);
      }
    );
  }

  title = 'Messaging Example';
}
