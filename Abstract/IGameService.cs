using System;
using System.Collections.Generic;
using System.Text;
using GameProject_K.Entities;

namespace GameProject_K.Abstract
    {
    public interface IGameService
        {
        void addGame(Game game) { }
        void deleteGame(Game game) { }
        void updateGame(Game game) { }
        void editGame(Game game) { }
        }
    }
