import { Student } from './../models/student';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  serviceUrl: string = "http://localhost:55555";
  constructor(private httpClient: HttpClient) { }

  getStudents():Observable<Student[]> {
    return this.httpClient.get<Student[]>(`${this.serviceUrl}/api/student`);
  }

  getStudent(id: number) : Observable<Student> {
    return this.httpClient.get<Student>(`${this.serviceUrl}/api/student/${id}`);
  }

  save(student: Student) : Observable<Student> {
    return this.httpClient.post<Student>(`${this.serviceUrl}/api/student`, student);
  }

  update(student: Student) : Observable<Student> {
    return this.httpClient.put<Student>(`${this.serviceUrl}/api/student/${student.ID}`, student);
  }
}
