const API_KEY = 'api_key=d3e67a133f00175108a86ecb790842a6&language=pt-BR';
const BASE_URL = 'https://api.themoviedb.org/3';
const API_URL = BASE_URL + '/discover/movie?sort_by=popularity.desc&' + API_KEY;
const img_URL = 'https://image.tmdb.org/t/p/w500';
const pesquisa_URL = BASE_URL + '/search/movie?' + API_KEY;

const main = document.getElementById('main');
const form = document.getElementById('form');
const pesquisa = document.getElementById('pesquisa');


getmovies(API_URL);


function getmovies(url) {
    fetch(url).then(res => res.json()).then(data => {
        showMovies(data.results);
    })
}

function showMovies(data) {
    main.innerHTML = '';


    data.forEach(movie => {
        const {title, poster_path, vote_average, overview} = movie
        const movieEl = document.createElement('div');
        movieEl.classList.add('movie');
        movieEl.innerHTML = `
        <img src="${img_URL + poster_path}" alt="${title}">


      <div class="movie-info">
        <h1>${title}</h1>
        <span class="${getcolor(vote_average)}">${vote_average}</span>
      </div>


      <div class="overview">
        <h1>overview</h1>
        ${overview}
      </div>
        
        `
        main.appendChild(movieEl);
    })

    function getcolor(vote) {
        if(vote >= 8)
            return 'blue';
        else if(vote >= 5)
            return 'orange'
        else 
            return 'red'
    }
}

form.addEventListener('submit', (e) => {
    e.preventDefault();
    const TermoPesquisa = pesquisa.value;

    if(TermoPesquisa){
        getmovies(pesquisa_URL + '&query=' + TermoPesquisa);
    } else {
        getmovies(url);
    }
})