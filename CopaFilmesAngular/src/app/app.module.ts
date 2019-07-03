import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { MoviesComponent } from './components/movies/movies.component';

import { AppRoutingModule }     from './app-routing.module';
import { WorldCupComponent } from './components/world-cup/world-cup.component';
 
@NgModule({
  declarations: [
    AppComponent,
    MoviesComponent,
    WorldCupComponent  
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
