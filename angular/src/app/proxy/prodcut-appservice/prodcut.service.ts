import { RestService, Rest } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import type { CreateProductDto } from '../dto/models';
import type { Product } from '../entity/models';

@Injectable({
  providedIn: 'root',
})
export class ProdcutService {
  apiName = 'Default';
  

  create = (input: CreateProductDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, Product>({
      method: 'POST',
      url: '/api/app/prodcut',
      body: input,
    },
    { apiName: this.apiName,...config });
  

  getList = (config?: Partial<Rest.Config>) =>
    this.restService.request<any, Product[]>({
      method: 'GET',
      url: '/api/app/prodcut',
    },
    { apiName: this.apiName,...config });
  

  getProductCount = (config?: Partial<Rest.Config>) =>
    this.restService.request<any, number>({
      method: 'GET',
      url: '/api/app/prodcut/product-count',
    },
    { apiName: this.apiName,...config });

  constructor(private restService: RestService) {}
}
