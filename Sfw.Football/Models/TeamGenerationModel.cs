﻿using Sfw.Football.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sfw.Football.Models
{
    public class TeamGenerationModel
    {
        public IEnumerable<Player> AllPlayers { get; set; }
    }
}