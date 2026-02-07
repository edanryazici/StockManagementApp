import { RouterOutletComponent } from '@abp/ng.core';
import { Routes } from '@angular/router';
import { ProductManagementComponent } from './components/product-management.component';

export const productManagementRoutes: Routes = [
  {
    path: '',
    pathMatch: 'full',
    component: RouterOutletComponent,
    children: [
      {
        path: '',
        component: ProductManagementComponent,
      },
    ],
  },
];
