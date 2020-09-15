﻿using CarService.Data.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarService.WebAPI.Services
{
    public interface IRecommenderService
    {
        Data.Model.CarServicesRecommenderModel Get(UserRecommendationRequest req);
    }
}