import { StorageService } from './storage.service';
import { login } from './../interfaces/login';
import { environment } from 'src/environments/environment';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { JwtHelperService } from '@auth0/angular-jwt';
import { map } from 'rxjs';
import { GlobalService } from './global.service';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  jwtHelper = new JwtHelperService();
  decodedToken: any;

  constructor(
    private http: HttpClient
    ,private _storageService: StorageService
    , private _globalService: GlobalService
    ) { }



  public getAllowPagesByUser(userExternalI: string) : any[] {
    return [
      {page: "dashboard"}
  ];
  }

  isAuthenticaded(): boolean {
    const access = this._storageService.getAccess();

    if (access === null) {
      return false;
    }

    return true;
  }
}
