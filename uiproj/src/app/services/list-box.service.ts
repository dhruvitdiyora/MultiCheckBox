import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ListBox } from '../model/ListBox.model';

@Injectable({
  providedIn: 'any',
})
export class ListBoxService {
  private baseUrl = 'https://localhost:7015/api';

  constructor(private http: HttpClient) {}
  getItems(): Observable<ListBox[]> {
    return this.http.get<ListBox[]>(`${this.baseUrl}/ListBox`);
  }
}
