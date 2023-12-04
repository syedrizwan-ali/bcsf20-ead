import { Component, OnInit } from '@angular/core';
import { Student } from '../../models/student';

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [],
  templateUrl: './student.component.html',
  styleUrl: './student.component.css'
})
export class StudentComponent implements OnInit{

  public students: Student[];

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

}
