import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class WorldCupService {

  url: string;
  path: string;

  getWinnerUrl = () => `${this.url}${this.path}`;

  constructor(private http: HttpClient) {
    this.url = "http://localhost:53515/api";
    this.path = "/WorldCup/GetWinner"
   }

   getWinner(moviesIds: string[]) {
      return this.http.get(this.getWinnerUrl(), { params: {moviesIds: moviesIds}})
   }

}
