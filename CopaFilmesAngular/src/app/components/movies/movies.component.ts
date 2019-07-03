import { Component, OnInit, EventEmitter, Output } from '@angular/core';
import { MoviesService, Movie } from 'src/app/service/movies.service';

@Component({
  selector: 'app-movies',
  templateUrl: './movies.component.html',
  styleUrls: ['./movies.component.css']
})
export class MoviesComponent implements OnInit {
  
  @Output() changeTitle: EventEmitter<string> = new EventEmitter();
  @Output() changeDescription: EventEmitter<string> = new EventEmitter();
  moviesArray: Movie[] = [];

  totalSelecteds = 0;
  totalMovies = 0;

  
 
  constructor(private movieService: MoviesService) {    
  }


  ngOnInit() {
    this.changeTitle.emit('Fase de Seleção');
    this.changeDescription.emit('Selecione 8 filmes que você deseja que entrem na competição e depois pressione o botão Gerar Meu Campeonato para prosseguir.');


    this.movieService
    .getMovies().subscribe((data: Movie[]) =>   
      {
        this.totalMovies = data.length        
        this.moviesArray = data
      }
    );
  }
 
  toggleMovie(index: number){
    this.moviesArray[index].selected = !this.moviesArray[index].selected;
    this.updateTotalSelecteds();
  }

  updateTotalSelecteds() {    
    this.totalSelecteds = this.moviesArray.filter((el)=> el.selected).length
    console.log(this.totalSelecteds)
  }

}
