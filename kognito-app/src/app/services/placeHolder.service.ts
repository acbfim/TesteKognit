import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class PlaceHolderService {

constructor(
  private http: HttpClient
) { }
  baseUrl = environment.urlJsonPlaceHolder;

  getPosts(userId: number) {
    return this.http.get<any>(`${this.baseUrl}/posts?userId=${userId}`);
  }

}
