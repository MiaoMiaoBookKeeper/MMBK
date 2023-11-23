import { environment } from '../../environments/environment';

export abstract class BaseWebConnection {
    protected serverUrl: string;
    constructor() {
        if (environment.production) {
            this.serverUrl = '';
        } else {
            this.serverUrl = 'https://localhost:44343';
            // this.serverUrl = 'https://dev.dpxpricing.com';
        }
    }
}
