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

  getAll() : Observable<City[]>{
    return this.httpClient.get<City[]>(`${this.serviceUrl}/city`);
  }

  get(id: number){
    return this.httpClient.get<City>(`${this.serviceUrl}/city/${id}`);
  }

  save(city: City){
    return this.httpClient.post<City>(`${this.serviceUrl}/city`, city);
  }

  update(city: City){
    return this.httpClient.put<City>(`${this.serviceUrl}/city/${city.ID}`, city);
  }

  delete(id: number){
    return this.httpClient.delete<boolean>(`${this.serviceUrl}/city/${id}`);
  }
}
