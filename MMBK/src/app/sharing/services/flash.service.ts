import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BaseHttp } from '../../core/base-http';
import { Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class FlashService extends BaseHttp {
  
  constructor(http: HttpClient) {
    super(http);
  }

  get() {
    return this.http.get<number>(`${this.apiUrl}/demo`);
  }

  add(req: number) {
    return this.http.get<number>(`${this.apiUrl}/demo/${req}`);
  }
  
}
