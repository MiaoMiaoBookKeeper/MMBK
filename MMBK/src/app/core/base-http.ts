import { HttpParams, HttpClient, HttpResponse } from '@angular/common/http';
import { Observable, ReplaySubject } from 'rxjs';
import { map } from 'rxjs/operators';
import { BaseWebConnection } from './base-web-connection';

export abstract class BaseHttp extends BaseWebConnection {

    constructor(public http: HttpClient) {
        super();
    }

    protected get apiUrl(): string {
        return `${this.serverUrl}/api`;
    }

    protected get adminUrl(): string {
        return `${this.serverUrl}/api/admin`;
    }

    protected get mgmtConsoleUrl(): string {
        return `${this.serverUrl}/api/mc`;
    }
}

