﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeadCenterBodyFramework.Model
{
    /// <summary>
    /// 游戏中的其他玩家实体类
    /// </summary>
    public class OtherUserModel
    {
        public string id { get; set; }

        public string name { get; set; }

        public string country_id { get; set; }

        public string cost { get; set; }

        public string town_level { get; set; }

        public CardModel leader_card { get; set; }

        public string friends { get; set; }

        public string friend_max { get; set; }

        public string last_login { get; set; }
    }
}
