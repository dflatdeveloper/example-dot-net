import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { PayloadRoutingModule } from './payload-routing.module';
import { PayloadComponent } from './payload.component';
import { PayloadService } from './payload.service';
import { FakePayloadService } from './fake-payload.service';

@NgModule({
  declarations: [
    PayloadComponent
  ],
  imports: [
    BrowserModule, HttpClientModule,
    PayloadRoutingModule
  ],
  providers: [{ provide: PayloadService, useClass: FakePayloadService }],
  bootstrap: [PayloadComponent]
})
export class PayloadModule { }
