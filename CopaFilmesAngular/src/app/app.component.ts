import { Component } from '@angular/core';
import { SharedService } from './service/shared.service';
import { Movie } from './service/movies.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = '';
  description = '';

  constructor(_sharedService: SharedService) {    
      _sharedService.changeEmitted$.subscribe(
        page => {
          this.changeTitle(page.Title);
          this.changeDescription(page.Description);
        });
  }

  changeTitle(val: string) {
    this.title=val;
  }

  changeDescription(val: string){
    this.description = val;    
  }
}


