import { City } from '../../../models/general/city';
import { CityService } from '../../../services/city.service';
import { Student } from './../../../models/student';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { FormGroup, FormControl, FormsModule } from '@angular/forms';

@Component({
  selector: 'app-city-add-edit',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './city-add-edit.component.html',
  styleUrl: './city-add-edit.component.css'
})
export class CityAddEditComponent implements OnInit{
  public id!: number;
  public model: City;
  public title?: string;

  constructor(private route: ActivatedRoute, private cityService: CityService, private router: Router) {
    var param = route.params.subscribe((params: Params) => {
      this.id = params['id'] ?? 0;

      if (this.id == 0)
      {
        this.title = 'Add City';
      }
      else
      {
        this.title = 'Edit City';
      }
    });
    this.model = new City('');
  }

  ngOnInit(): void{
    if (this.id > 0)
    {
      this.cityService.get(this.id).subscribe((data) => {
        this.model = data;
      });
    }
  }

  save(event: any)
  {
    if(this.id == 0)
    {
      this.cityService.save(this.model).subscribe((data: City) => {
        if (data.ID > 0)
        {
          this.router.navigateByUrl('City');
        }
      });
    }
    else
    {
      this.cityService.update(this.model).subscribe((data: City) => {
        if (data.ID > 0)
        {
          this.router.navigateByUrl('City');
        }
      });
    }
  }

  cancel(event: any)
  {
    this.router.navigateByUrl('City');
  }
}
