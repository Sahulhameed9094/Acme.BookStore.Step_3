import { Component } from '@angular/core';

@Component({
  selector: 'app-dashboard',
  template: `
    <app-host-dashboard *abpPermission="'Step_3.Dashboard.Host'"></app-host-dashboard>
    <app-tenant-dashboard *abpPermission="'Step_3.Dashboard.Tenant'"></app-tenant-dashboard>
  `,
})
export class DashboardComponent {}
