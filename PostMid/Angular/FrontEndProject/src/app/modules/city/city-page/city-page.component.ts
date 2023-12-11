import { CityService } from './../../../services/city.service';
import { Component, OnInit } from '@angular/core';
import { City } from '../../../models/general/city';

@Component({
  selector: 'app-city-page',
  standalone: true,
  imports: [],
  templateUrl: './city-page.component.html',
  styleUrl: './city-page.component.css'
})
export class CityPageComponent implements OnInit{
  
  cities?: City[];
  constructor(private cityService: CityService) {
    
  }
  
  ngOnInit(): void {
    this.cityService.getCities().subscribe((data: City[]) => {
      this.cities = data
      console.table(data);
    });
  }

}
