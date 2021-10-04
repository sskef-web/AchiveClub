﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace AchiveClub.Shared
{
    public class Achive
    {
        [BsonId]
        public int Id { get; set; }
        public int Xp { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string LogoURL { get; set; }

        [BsonIgnore]
        public string XpString
        {
            get => Xp.ToString();
            set => Xp = int.Parse(value);
        }
    }
}
