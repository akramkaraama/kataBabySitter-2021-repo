import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { WorkTime } from '../models/work-time';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  baseUrl = "http://localhost:58317/api/payCalculator"

  constructor(private api: HttpClient) { }

  postWorkTime(workTime: WorkTime) {
    return this.api.post<WorkTime>(this.baseUrl, workTime);
  }
}
