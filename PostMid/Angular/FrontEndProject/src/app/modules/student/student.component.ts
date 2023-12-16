import { StudentService } from './../../services/student.service';
import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Student } from '../../models/student';
import { CourseComponent } from '../course/course.component';
import { RouterLink, RouterLinkActive } from '@angular/router';

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [CourseComponent, RouterLink, RouterLinkActive],
  templateUrl: './student.component.html',
  styleUrl: './student.component.css'
})

export class StudentComponent {
  @Input() someValue!:Number;

  public students?: Student[];
  public outputFromCourse!: Number;

  constructor(private studentService : StudentService) {

  }

  ngOnInit(): void {
    this.studentService.getStudents().subscribe((data: Student[]) => {
      this.students = data;
    }) ;
  }

  outPutListener(value: Number): void{
    console.log('listening value');
    this.outputFromCourse = value;
    console.log(value);
  }

  getStudentData($event: any, id: number){
    this.studentService.getStudent(id).subscribe((data: Student) => {
      console.log(data);
    });
  }
}
