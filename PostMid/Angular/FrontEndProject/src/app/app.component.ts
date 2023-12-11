import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { StudentComponent } from './modules/student/student.component';
import { CityPageComponent } from "./modules/city/city-page/city-page.component";

@Component({
    selector: 'app-root',
    standalone: true,
    templateUrl: './app.component.html',
    styleUrl: './app.component.css',
    imports: [CommonModule, RouterOutlet, StudentComponent, CityPageComponent]
})
export class AppComponent {
  title = 'BCSF20M - Angular';
}
