import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { Course } from '../../models/course';

@Component({
  selector: 'app-course',
  standalone: true,
  imports: [],
  templateUrl: './course.component.html',
  styleUrl: './course.component.css'
})
export class CourseComponent{ 
  @Output() someOutput = new EventEmitter<Number>();

  public courses: Course[];
  constructor() {
    this.courses = [
      new Course("EAD", "cs-ead"),
      new Course("Mobile Development", "cs-mod"),
      new Course("Business Development", "cs-bizdev")
    ];
  }

  ngOnInit(): void {

    setTimeout(() =>{
      this.someOutput.emit(3.141562954);
      console.log('emiting value');
    }, 2000);

  }

}
