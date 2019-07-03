import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/service/shared.service';
import { ActivatedRoute } from '@angular/router';
import { WorldCupService } from 'src/app/service/world-cup.service';
import { Movie } from 'src/app/service/movies.service';

@Component({
  selector: 'app-world-cup',
  templateUrl: './world-cup.component.html',
  styleUrls: ['./world-cup.component.css']
})
export class WorldCupComponent implements OnInit {

  winners: Movie[] = [];

  constructor(private _worldCupService: WorldCupService, private _sharedService: SharedService, private _route: ActivatedRoute,
    ) {    
  }

  ngOnInit() {
    this._sharedService.emitChange({
      Title: 'Resultado Final',
      Description: 'Veja o resultado final do Campeonado de filmes de forma simples e rápida.'
    });

    this._route.paramMap.subscribe(params => {
      // This is never executed, for route is not recognized
      let myArray=params.get("selectedIds");
      
      this._worldCupService.getWinner(myArray)
      .subscribe((data: Movie[]) =>   
      {
        this.winners = data;
      });
    });
  }
}
