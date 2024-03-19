import { AuthService } from '@abp/ng.core';
import { ToasterService } from '@abp/ng.theme.shared';
import { Component } from '@angular/core';

import { DoctorServicesService } from '@proxy/doctor-service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent {
  saveDoctor: any = {};
  get hasLoggedIn(): boolean {
    return this.authService.isAuthenticated;
  }

  constructor(
    private authService: AuthService,
    private toasterService: ToasterService,
    private _doctor: DoctorServicesService
  ) {}

  login() {
    this.authService.navigateToLogin();
  }

  create(): void {
    // debugger;
    var _data: any = {};
    _data.name = this.saveDoctor.name;
    _data.specialization = this.saveDoctor.specialization;
    _data.yearsOfExperience = this.saveDoctor.yearsOfExperience;
    _data.hospital = this.saveDoctor.hospital;

    this._doctor.createNewDoctorByInput(_data).subscribe(result => {
      this.toasterService.success('Doctor created successfully');
      console.log(JSON.stringify(result));
      this.saveDoctor = {};
    });
  }
}

export class CreateDoctorDto {
  name?: string;
  specialization?: string;
  yearsOfExperience: number;
  hospital?: string;
}
