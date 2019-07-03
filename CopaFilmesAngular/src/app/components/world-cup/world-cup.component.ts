import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/service/shared.service';

@Component({
  selector: 'app-world-cup',
  templateUrl: './world-cup.component.html',
  styleUrls: ['./world-cup.component.css']
})
export class WorldCupComponent implements OnInit {

  constructor(private _sharedService: SharedService) {    
  }

  ngOnInit() {
    this._sharedService.emitChange({
      Title: 'Resultado Final',
      Description: 'Veja o resultado final do Campeonado de filmes de forma simples e rápida.'
    });
  }
}
