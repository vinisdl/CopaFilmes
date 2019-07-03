import { NgModule }             from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
 
import { MoviesComponent }   from './components/movies/movies.component';
import { WorldCupComponent }   from './components/world-cup/world-cup.component';

const routes: Routes = [
  { path: '', redirectTo: '/movie', pathMatch: 'full' },
  { path: 'movie', component: MoviesComponent },
  { path: 'world-cup/:selectedIds', component: WorldCupComponent },
];
 
@NgModule({
  imports: [ RouterModule.forRoot(routes) ],
  exports: [ RouterModule ]
})
export class AppRoutingModule {}