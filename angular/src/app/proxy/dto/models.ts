
export interface CreateDoctorDto {
  name?: string;
  specialization?: string;
  yearsOfExperience: number;
  hospital?: string;
}

export interface CreateProductDto {
  name?: string;
  price: number;
}
