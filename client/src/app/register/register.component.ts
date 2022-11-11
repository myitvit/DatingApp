import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  @Input() usersFromHomeComponent: any;

  model: any = {};

  constructor() { }

  ngOnInit(): void {
  }

  register(): void {
    console.log(this.model);
  }

  cancel(): void {
    console.log('Cancelled');
  }
}
