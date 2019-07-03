import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class MoviesService {

  url: string;
  path: string;

  getMoviesUrl = () => `${this.url}${this.path}`;

  constructor(private http: HttpClient) {
    this.url = "http://localhost:53515/api";
    this.path = "/Movie"
    
   }

   getMovies(){
    return this.http.get<Movie[]>(this.getMoviesUrl());
   }
}

export class Movie {
  id: string;
  titulo: string;
  ano: number;
  nota: number;
  selected: boolean = false;
}
