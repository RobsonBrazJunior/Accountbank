import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ConfigService {
  private baseUrl: string = 'https://localhost:7141/api/';

  get apiUrl(): string {
    return this.baseUrl;
  }
}