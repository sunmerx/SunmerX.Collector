using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HslCommunication;
using HslCommunication.Core;
using Sunmerx.Interactive.Abstract;
using Sunmerx.Interactive.Config;

namespace Sunmerx.Interactive.Antetype
{
    /// <summary>
    /// 心跳设置
    /// </summary>
    public class HeartbeatSetting
    {
        public int IntervalSec
        {
            get; set;
        }
        public byte[] Message
        {
            get; set;
        }
        public CancellationTokenSource TokenSource
        {
            get; set;
        }
    }
    /// <summary>
    /// 原型基类
    /// </summary>
    public class AntetypeBase
    {
        public virtual IClient Client
        {
            get;set;
        }
        #region 网口设备

        public virtual OperateResult Connect()
        {
            throw new NotImplementedException();
        }

        public virtual OperateResult Disconnect()
        {
            throw new NotImplementedException();
        }

        public virtual OperateResult HeartbeatControl(bool enable , HeartbeatSetting? heartbeatSetting = null)
        {
            throw new NotImplementedException();
        }

        #endregion
        #region 串口

        public virtual IClient Initialize()
        {
            throw new NotImplementedException();
        }
        public virtual OperateResult Open()
        {
            throw new NotImplementedException();
        }
        public virtual OperateResult Close()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region 通用
        public virtual OperateResult Run()
        {
            throw new NotImplementedException();
        }
        public virtual OperateResult Stop()
        {
            throw new NotImplementedException();
        }
        public virtual OperateResult Reset()
        {
            throw new NotImplementedException();
        }
        public virtual OperateResult Command(string cmd , params object[] args)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
