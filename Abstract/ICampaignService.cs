using System;
using System.Collections.Generic;
using System.Text;
using GameProject_K.Entities;

namespace GameProject_K.Abstract
    {
   public interface ICampaignService
        {
            void Add(Campaign campaingn) { }
            void Delete(Campaign campaign) { }
            void Update(Campaign campaign) { }
            void Edit(Campaign campaign) { }

        }
    }
