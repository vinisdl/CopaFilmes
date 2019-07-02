using CopaFIlmes.Domain.Entity;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CopaFilmes.Test.Entity
{
    public class WorldCupTests
    {
        [Test]
        public void IsValid()
        {
            var movies = GetListOfMovies(8);
            var worldCup = new WorldCup(movies);
            Assert.IsTrue(worldCup.IsValid());
        }

        [Test]
        public void IsNotValid()
        {
            var movies = GetListOfMovies(7);
            var worldCup = new WorldCup(movies);
            Assert.IsFalse(worldCup.IsValid());
        }

        [Test]
        public void GetWinner()
        {
            var top1 = new Movie() { Title = "Vingadores: Guerra Infinita", Score = 8.8M };
            var top2 = new Movie() { Title = "Os Incríveis 2", Score = 8.5M };
            var winner = WorldCup.GetWinner(top1, top2).FirstOrDefault();
            Assert.AreEqual(top1, winner);
        }

        [Test]
        public void GetWinnerWithSameScore()
        {
            var top1 = new Movie() { Title = "Toy Story 1", Score = 10 };
            var top2 = new Movie() { Title = "Toy Story 4", Score = 10 };
            var winner = WorldCup.GetWinner(top1, top2).FirstOrDefault();
            Assert.AreEqual(top1, winner);
        }

        [Test]
        public void RunWorldCup()
        {
            var top1 = new Movie() { Title = "Vingadores: Guerra Infinita", Score = 8.8M };
            var top2 = new Movie() { Title = "Os Incríveis 2", Score = 8.5M };

            var listMovies = new List<Movie>()
            {
                top2,
                new Movie(){ Title ="Jurassic World: Reino Ameaçado" , Score= 6.7M },
                new Movie(){ Title ="Oito Mulheres e um Segredo" , Score= 6.3M},
                new Movie(){ Title ="Hereditário" , Score= 7.8M},
                top1,
                new Movie(){ Title ="Deadpool 2" , Score= 8.1M},
                new Movie(){ Title ="Han Solo: Uma História Star Wars" , Score= 7.2M},
                new Movie(){ Title ="Thor: Ragnarok", Score=7.9M},
            };

            var worldCup = new WorldCup(listMovies);
            

            var rankTopTwo = worldCup.RunCup();
            Assert.AreEqual(2, rankTopTwo.Count);
            Assert.AreEqual(top1, rankTopTwo.FirstOrDefault());
            Assert.AreEqual(top2, rankTopTwo.LastOrDefault());

        }

        
        private static List<Movie> GetListOfMovies(int max)
        {
            return Enumerable
                .Range(1, max)
                .Select(a => new Movie())
                .ToList();
        }

    }
}
