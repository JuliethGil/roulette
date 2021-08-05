﻿using BusinessLayer.Interfaces;
using DataAccess.Entities;
using DataAccess.Interfaces;
using System.Threading.Tasks;

namespace BusinessLayer.BusinessLogic
{
    public class RouletteLogic : IRouletteLogic
    {
        private readonly IRouletteQuery _dnaSequenceQuery;
        public RouletteLogic(IRouletteQuery rouletteQuery) => _dnaSequenceQuery = rouletteQuery;

        public int NewRoulette(Roulette roulette)
        {
            roulette.State = true;
            return _dnaSequenceQuery.CreateRoulette(roulette);

        }

    }
}
