import { login } from './../../interfaces/login';
import { StorageService } from './../../services/storage.service';
import { Component, HostListener, OnInit } from '@angular/core';
import { GlobalService } from 'src/app/services';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss'],
})
export class LoginComponent implements OnInit {
  isDesktop = this._globalService.isDesktop();
  hide = true;
  load = false;

  creds: login = {
    username: '',
    password: '',
  };

  salvarLogin = false;

  constructor(
    private _globalService: GlobalService,
    private _storageService: StorageService
  ) {}
  ngOnInit(): void {
    this.getLoginCreds();
    const token = this._storageService.getAccess().accessToken;
  }

  @HostListener('window:resize', ['$event'])
  onResize() {
    this.isDesktop = this._globalService.isDesktop();
  }

  login() {
    if (this.creds) {
      this.load = true;

      if (this.creds.username == 'admin' && this.creds.password == 'admin') {

        setTimeout(() => {

          if (this.salvarLogin) {
            this._storageService.setItem('loginAccess', this.creds);
          } else {
            this.clearAccess();
          }

          this._storageService.setAccess(true);
          this.load = false;
          this._globalService.navigateTo('auth/dashboard');

        }, 2000);
      }
    }
  }

  getLoginCreds() {
    let cred = this._storageService.getItem('loginAccess');
    if (cred !== null) {
      this.creds = cred;
      this.salvarLogin = true;
    }
  }

  clearAccess() {
    if (this.salvarLogin) {
      this.creds = {
        username: '',
        password: '',
      };
      this._storageService.cleanItem('loginAccess');
    }
  }
}
