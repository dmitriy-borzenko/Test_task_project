import { User } from './../models/user';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient) { }

  baseURL: string = "https://localhost:44337/api/users";

  getUsers() {
    return this.http.get(this.baseURL);
  }

  putUsers(user: User) {
    return this.http.put(`${this.baseURL}/${user.id}`, user)
  }
}
