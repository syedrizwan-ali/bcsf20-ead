import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Student } from '../models/student';

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  serviceUrl: string = "http://localhost:5000";
  constructor(private httpClient: HttpClient) { }

  getStudents():Observable<Student[]> {
    return this.httpClient.get<Student[]>(`${this.serviceUrl}/api/student`);
  }

  getStudent(id: number) : Observable<Student> {
    return this.httpClient.get<Student>(`${this.serviceUrl}/api/student/${id}`);
  }
}
