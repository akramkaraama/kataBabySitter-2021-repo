import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ApiService } from '../services/api.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styles: [
  ]
})
export class HomeComponent implements OnInit {
  public shiftHours;
  public shiftHoursForm: FormGroup;

  public startTime: string;
  public endTime: string;
  public totalPay: number = 0;

  constructor(fb: FormBuilder, private apiService: ApiService) {
    this.shiftHoursForm = fb.group({
      startTime: ["", Validators.required],
      endTime: ["", Validators.required]
    });
  }

  ngOnInit(): void {
    this.shiftHours = [{ hour: 1, name: '5:00 PM' }, { hour: 2, name: '6:00 PM' }, { hour: 3, name: '7:00 PM' },
                        { hour: 4, name: '8:00 PM' }, { hour: 5, name: '9:00 PM' }, { hour: 6, name: '10:00 PM' },
                        { hour: 7, name: '11:00 PM' }, { hour: 8, name: '12:00 AM' }, { hour: 9, name: '01:00 AM' },
                        { hour: 10, name: '02:00 AM' }, { hour: 11, name: '03:00 AM' }, { hour: 12, name: '04:00 AM' }];
  }

  onChangeStartTime($event) {
    this.startTime = $event.target.options[$event.target.options.selectedIndex].text;
    this.totalPay = 0;
  }

  onChangeEndTime($event) {
    this.endTime = $event.target.options[$event.target.options.selectedIndex].text;
    this.totalPay = 0;
  }

  calculatePay() {
    this.apiService.postWorkTime(this.shiftHoursForm.value).subscribe((result: any) => {
      this.totalPay = result;
    });
    this.shiftHoursForm.reset();
  }

}
