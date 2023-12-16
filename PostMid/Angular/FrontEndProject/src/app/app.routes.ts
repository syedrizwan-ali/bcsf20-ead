import { Routes } from '@angular/router';
import { StudentComponent } from './modules/student/student.component';
import { CityPageComponent } from './modules/city/city-page/city-page.component';
import { HomeComponent } from './modules/home/home.component';
import { NotFoundComponent } from './modules/not-found/not-found.component';

export const routes: Routes = [
    { path: "", component: HomeComponent, pathMatch: "full"},
    { path: "Student", component: StudentComponent},
    { path: "City", component: CityPageComponent},
    { path: "**", component: NotFoundComponent}
];
