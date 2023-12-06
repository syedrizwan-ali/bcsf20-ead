import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Student } from '../../models/student';
import { CourseComponent } from '../course/course.component';

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [CourseComponent],
  templateUrl: './student.component.html',
  styleUrl: './student.component.css'
})

export class StudentComponent implements OnInit{
  @Input() someValue!:Number;

  public students: Student[];
  public outputFromCourse!: Number;

  constructor() {
    this.students = [
      new Student("Student 01", "Rollnumber01"),
      new Student("Student 02", "Rollnumber02"),
      new Student("Student 03", "Rollnumber03"),
      new Student("Student 04", "Rollnumber04"),
      new Student("Student 05", "Rollnumber05")
    ];
  }

  ngOnInit(): void {
  }

  outPutListener(value: Number): void{
    console.log('listening value');
    this.outputFromCourse = value;
    console.log(value);
  }

}
