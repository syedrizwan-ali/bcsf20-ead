import { CityService } from './../../../services/city.service';
import { Component, OnInit } from '@angular/core';
import { City } from '../../../models/general/city';
import { RouterLink } from '@angular/router';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-city-page',
  standalone: true,
  imports: [RouterLink],
  templateUrl: './city-page.component.html',
  styleUrl: './city-page.component.css'
})
export class CityPageComponent{
  
  cities?: City[];
  constructor(private cityService: CityService) {
    
  }
  
  ngOnInit(): void {
    this.cityService.getAll().subscribe((data: City[]) => {
      this.cities = data;
    });
  }

  delete(event:any, id: number){
    this.cityService.delete(id).subscribe((data: boolean) => {
      if (data){
        this.cityService.getAll().subscribe((data: City[]) => {
          this.cities = data;
        });
      }
    });
  }
}
