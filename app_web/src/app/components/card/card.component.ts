import { Component, OnInit } from '@angular/core';
import { Movie } from 'src/app/models/movie.model';
import { MovieService } from 'src/app/services/movie.service';
import { environment } from 'src/environments/environment.development';

@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.css']
})
export class CardComponent implements OnInit {
  movies:Movie[]=[];
  baseimagenUrl:string=environment.baseImageURL;
  constructor(private service:MovieService){}

 ngOnInit(): void {
    this.service.getMovieAll().subscribe(Movie=>{
        this.movies=Movie.results
    });
 }
}
