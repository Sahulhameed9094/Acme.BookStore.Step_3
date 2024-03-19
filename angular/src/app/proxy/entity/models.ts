import type { Entity } from '../volo/abp/domain/entities/models';

export interface Doctor {
  tenantId?: string;
  name?: string;
  specialization?: string;
  yearsOfExperience: number;
  hospital?: string;
}

export interface Product {
  tenantId?: string;
  name?: string;
  price: number;
}
