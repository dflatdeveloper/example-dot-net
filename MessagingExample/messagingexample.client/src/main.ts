import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/app.module';
import { PayloadModule } from './payload/payload.module';

platformBrowserDynamic().bootstrapModule(AppModule)
  .catch(err => console.error(err));

platformBrowserDynamic().bootstrapModule(PayloadModule)
  .catch(err => console.error(err));

