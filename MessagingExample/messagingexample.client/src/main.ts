import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { PayloadModule } from './payload/payload.module';

platformBrowserDynamic().bootstrapModule(PayloadModule)
  .catch(err => console.error(err));

