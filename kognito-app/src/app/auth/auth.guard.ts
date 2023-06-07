import { JwtHelperService } from '@auth0/angular-jwt';
import { Injectable } from '@angular/core';
import { Route, UrlSegment, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, Router } from '@angular/router';
import { Observable, Subscriber } from 'rxjs';
import { GlobalService, StorageService } from '../services';
import { AuthService } from '../services/auth.service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard  {

  jwtHelper = new JwtHelperService();

  constructor(
    private router: Router
    , private _storageService: StorageService
    , private _globalService: GlobalService
    , private _authService: AuthService
  ) {

  }



  async canActivate(

    activated: ActivatedRouteSnapshot
  ): Promise<boolean> {

    let page = activated.url[0]?.path;

    let access = this._storageService.getAccess();

    if (access == null || access === false) {
      this.router.navigate(['/login']);
      this._storageService.cleanAccess();
      this._globalService.sendAlert("Sessão encerrada. Faça login novamente", "OK")
      return false;
    }


    if (page !== null && page !== undefined) {

      let allowPages = await this._authService.getAllowPagesByUser("idUser");
      let cont = 0;

      allowPages.forEach(function (x) : any {
        if (x.page === page) {
          cont++
        }
      });

      if(cont == 0) {
        this._globalService.navigateTo("auth");
        this._globalService.sendAlertError("Você não possui acesso a essa página.","OK")
        return false;

      }
    }

    return true;
  }



}

export class VerificarPermissoes {
  public static temPermissao(roles: string[], permissoesDoUsuario: string[]): boolean {
    for (let role of roles) {
      if (permissoesDoUsuario.includes(role)) {
        return true;
      }
    }
    return false;
  }
}
