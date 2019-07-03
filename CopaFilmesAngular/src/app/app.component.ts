import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = '';
  description = '';



  changeTitle(val: string) {
    console.log(val);
    this.title=val;
  }

  changeDescription(val: string){
    this.description = val;    
  }
}


