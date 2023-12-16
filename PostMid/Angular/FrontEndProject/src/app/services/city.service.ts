import { Injectable } from '@angular/core';
import { City } from '../models/general/city';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class CityService {

  private serviceUrl: string = "http://localhost:55555/api";
  constructor(private httpClient: HttpClient) { }

  getCities() : Observable<City[]>{
    return this.httpClient.get<City[]>(`${this.serviceUrl}/city`);
  }
}
