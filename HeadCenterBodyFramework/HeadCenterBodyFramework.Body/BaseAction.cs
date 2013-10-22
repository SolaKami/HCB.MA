using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HeadCenterBodyFramework.Model;
using HeadCenterBodyFramework.Enum;
using HeadCenterBodyFramework.Work;
using HeadCenterBodyFramework.Common;

namespace HeadCenterBodyFramework.Body
{
    /// <summary>
    /// 基础动作类，作为一切动作的基准，被所有动作所继承
    /// </summary>
    public abstract class BaseAction
    {
        #region 属性

        public PlayerModel Player { get; set; }

        #endregion

        #region 构造函数

        public BaseAction()
        { }

        public BaseAction(PlayerModel model)
        {
            this.Player = model;
        }
        #endregion

        #region 方法

        public virtual void DoAct(ActModeEnum act)
        {
            HttpRequestParameter reqPara = GetMAGameHttpParameter.GetParameter(act, Player);

            HttpResponseParameter resPara = DoHttp.HttpRequest(reqPara);
        }

        #endregion

    }
}
