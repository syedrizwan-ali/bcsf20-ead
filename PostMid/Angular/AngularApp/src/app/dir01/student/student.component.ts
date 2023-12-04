import { Component, OnInit } from '@angular/core';
import { Student } from 'src/app/models/student';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent implements OnInit {

  private student: Student;
  constructor() 
  {
    this.student = new Student();
    this.student.ID = 1;
    this.student.Name = 'Farwwa';
    this.student.RollNumber = '';
  }

  ngOnInit(): void {
  }

}
