import { Routes } from '@angular/router';
import { StudentComponent } from './modules/student/student.component';
import { CityPageComponent } from './modules/city/city-page/city-page.component';
import { HomeComponent } from './modules/home/home.component';
import { NotFoundComponent } from './modules/not-found/not-found.component';
import { CityAddEditComponent } from './modules/city/city-add-edit/city-add-edit.component';
import { CityViewComponent } from './modules/city/city-view/city-view.component';

export const routes: Routes = [
    { path: "", component: HomeComponent, pathMatch: "full"},
    { path: "Student", component: StudentComponent},
    { path: "City", component: CityPageComponent},
    { path: "City/Add", component: CityAddEditComponent },
    { path: "City/Edit/:id", component: CityAddEditComponent },
    { path: "City/View/:id", component: CityViewComponent },
    { path: "**", component: NotFoundComponent}
];
