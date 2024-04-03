import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { NgForm } from '@angular/forms';
import { Subscription } from 'rxjs';

@Component({
  selector: 'login',
  templateUrl: './login.component.html'
 })
export class LoginComponent {
    invalideLogin: boolean; 
  subscription: Subscription;

  constructor(  private router: Router, private http: HttpClient) {}
  login(form:NgForm) {
    const credentials={
       'cin' : form.value.cin,
       'motdepasse' : form.value.motdepasse
    };
    


    const headers = new HttpHeaders()
      .set('Content-Type', 'application/json-patch+json')
      .set('accept', '*/*');
      
      
      // Use observer object with subscribe
      debugger
      this.http.post("https://localhost:44323/api/Comptes/login", credentials, { headers })
      .subscribe(
        (response) => {
          console.log('Login successful:', response);
          const token = (<any> response).token;
          // const token = response.token;
          localStorage.setItem("jwt", token);
          this.router.navigate(["/dashboard"]);
          this.invalideLogin = false;
          // Handle successful login response
        },
        (error) => {
          console.error('Login failed:', error);
          this.invalideLogin = true;
          // Handle login error
        }
      );
  
;  }
}
