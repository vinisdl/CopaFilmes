import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from './../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class WorldCupService {

  url: string;
  path: string;

  getWinnerUrl = () => `${this.url}${this.path}`;

  constructor(private http: HttpClient) {
    this.url = environment.worldCupUrl;
    this.path = "/WorldCup/GetWinner"
   }

   getWinner(moviesIds: string) {
      let paramsArray = new HttpParams();  
      //i dont now why this 
      moviesIds.toString()
      .split(',').forEach((id)=>{
        paramsArray = paramsArray.append('moviesIds', id.toString())
      })
      return this.http.get(this.getWinnerUrl(), { params: paramsArray})
   }
}
