import {makeEnvironmentProviders} from '@angular/core';
import { PRODUCT_MANAGEMENT_ROUTE_PROVIDERS } from './providers/route.provider';

export function provideProductManagementConfig() {
  return makeEnvironmentProviders([PRODUCT_MANAGEMENT_ROUTE_PROVIDERS])
}
