import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'user',
  templateUrl: './user.component.html',
})
export class userComponent implements OnInit {
  user: any;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.http.get("https://localhost:44323/api/Comptes")
    .subscribe({
      next: (result: any) => this.user = result,
      error: (err: HttpErrorResponse) => console.log(err)
    })
  }

}