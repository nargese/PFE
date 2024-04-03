// import { Injectable } from '@angular/core';
// import { HttpClient, HttpParams } from '@angular/common/http';
// import { Observable } from 'rxjs';
// import { map } from 'rxjs/operators';
// import { User } from '../Model/user';

// @Injectable({
//   providedIn: 'root'
// })
// export class AuthService {
//   constructor(private http: HttpClient) {}
//   APIURL = 'https://localhost:44323/api';
//   login(cin: string, password: string): Observable<any> {
//     const params = new HttpParams()
//       .set('cin', cin)
//       .set('password', password);

//     return this.http.post<any>(`${this.APIURL}/Comptes/login`, {}, { params });
//   }

//   }

//   // logout(): void {
//   //   localStorage.removeItem('currentUser');
//   // }

