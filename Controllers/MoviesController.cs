﻿using Microsoft.AspNetCore.Mvc;
using netcore5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore5.Data {
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase {

        private CinemaDbContext _dbContext;

        public MoviesController(CinemaDbContext dbContext) {
            _dbContext = dbContext;
        }

        // GET: api/<MoviesController>
        [HttpGet]
        public IEnumerable<Movie> Get() {
            return _dbContext.Movies;
        }

        // GET: api/<MoviesController>/5
        [HttpGet("{id}")]
        public Movie Get(int id) {
            var movie = _dbContext.Movies.Find(id);
            return movie;
        }

        // POST api/<MoviesController>
        [HttpPost]
        public void Post([FromBody] Movie movieObj) {
            _dbContext.Movies.Add(movieObj);
            _dbContext.SaveChanges();
        }

        // PUT api/<MoviesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Movie movieObj) {
            var movie = _dbContext.Movies.Find(id);
            movie.Name = movieObj.Name;
            movie.Language = movieObj.Language;
            _dbContext.SaveChanges();
        }

        // DELETE api/<MoviesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
            var movie = _dbContext.Movies.Find(id);
            _dbContext.Movies.Remove(movie);
            _dbContext.SaveChanges();
        }
    }
}
