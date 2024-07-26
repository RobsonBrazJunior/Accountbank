import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ConfigService } from './config.service';

@Injectable({
  providedIn: 'root'
})
export class TransactionService {
  private apiUrl: string;

  constructor(private http: HttpClient, private configService: ConfigService) {
    this.apiUrl = `${this.configService.apiUrl}Transaction`;
  }

  getTransactions(days: number): Observable<any[]> {
    return this.http.get<any[]>(`${this.apiUrl}?days=${days}`);
  }
}
