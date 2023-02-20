import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment.development';
import { GenreModel } from '../models/genre.model';
import { MovieDetailModel } from '../models/movie-detail.model';
import { Movie } from '../models/movie.model';
import { TopRated } from '../models/top_rated.model';

@Injectable({
  providedIn: 'root',
})
export class MovieService {
  private movies: Movie[] = [];
  private genres: GenreModel[] = [];

  baseURL = environment.baseApiURL;
  apiKey = environment.apiKey;
  baseImg = environment.baseImageURL;
  private language:string='en-US';

  private favourites: Movie[] | MovieDetailModel[] | any[] = this.movies.filter(
    (m) => m.favorite === true
  );
  constructor(private http: HttpClient) {}

  getMovieAll(): Observable<TopRated> {
    return this.http.get<TopRated>(
      `${this.baseURL}movie/top_rated?api_key=${this.apiKey}&language=${this.language}&page=1`
    );
  }
  setMovies(movies: Movie[]) {
    if (this.favourites.length > 0) {
      this.favourites.forEach((fav) => {
        const movie = movies.find((mov) => {
          return mov.id === fav.id;
        });
        if (movie) {
          movie.favorite = true;
        }
      });
    }

    this.movies = movies;
  }
  addMovie(movie: Movie) {
    this.movies.push(...[movie]);
  }
  getImage(path: string, size: string) {
    return this.baseImg + size + path;
  }

}
