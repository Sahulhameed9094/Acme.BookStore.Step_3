import { RestService, Rest } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import type { CreateDoctorDto } from '../dto/models';
import type { Doctor } from '../entity/models';

@Injectable({
  providedIn: 'root',
})
export class DoctorServicesService {
  apiName = 'Default';

  createNewDoctorByInput = (input: CreateDoctorDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, Doctor>(
      {
        method: 'POST',
        url: '/api/app/doctor-services/new-doctor',
        body: input,
      },
      { apiName: this.apiName, ...config }
    );

  doIt = (config?: Partial<Rest.Config>) =>
    this.restService.request<any, void>(
      {
        method: 'POST',
        url: '/api/app/doctor-services/do-it',
      },
      { apiName: this.apiName, ...config }
    );

  getList = (config?: Partial<Rest.Config>) =>
    this.restService.request<any, Doctor[]>(
      {
        method: 'GET',
        url: '/api/app/doctor-services',
      },
      { apiName: this.apiName, ...config }
    );

  getProductCount = (config?: Partial<Rest.Config>) =>
    this.restService.request<any, number>(
      {
        method: 'GET',
        url: '/api/app/doctor-services/product-count',
      },
      { apiName: this.apiName, ...config }
    );

  getTenantName = (config?: Partial<Rest.Config>) =>
    this.restService.request<any, string>(
      {
        method: 'GET',
        responseType: 'text',
        url: '/api/app/doctor-services/tenant-name',
      },
      { apiName: this.apiName, ...config }
    );

  constructor(private restService: RestService) {}
}
