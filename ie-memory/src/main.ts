import { enableProdMode, PlatformRef, NgModuleRef, TestabilityRegistry } from '@angular/core';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/app.module';


//enableProdMode();


declare var window: any;

platformBrowserDynamic().bootstrapModule(AppModule).then((ref: NgModuleRef<AppModule>) => {
  window.onbeforeunload = () => {

    let platform = ref.injector.get(PlatformRef);

    const testabilityRegistry: TestabilityRegistry = platform.injector.get(TestabilityRegistry);
    (testabilityRegistry as any)._applications.clear();

    platform.destroy();
    platform = null;

    delete window.webpackJsonp;
    delete window.frameworkStabilizers;
    delete window.getAngularTestability;
    delete window.getAllAngularTestabilities;
    delete window.getAllAngularRootElements;
    delete window.ng;
    if (typeof window.CollectGarbage === 'function') {
      window.CollectGarbage();
    }

    document.body.innerHTML = '';
  };
}).catch(err => console.error(err));
