using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HslCommunication;
using HslCommunication.Core;
using HslCommunication.Profinet.Siemens;
using Sunmerx.Interactive.Config;

namespace Sunmerx.Interactive.Antetype
{
    public class SiemensAnte:AntetypeBase
    {
        public SiemensAnte(ConfigBase config)
        {
            this._config = (SiemensConfig) config;
        }
        private SiemensConfig _config;
        public override IReadWriteNet Initialize()
        {
            SiemensS7Net client = new SiemensS7Net(_config.PlcType , _config.IPAddress);
            client.Port = _config.Port;
            client.Rack = _config.Rack;
            client.Slot = _config.Slot;
            client.ConnectTimeOut = _config.ConnectTimeOut;
            client.ReceiveTimeOut = _config.ReceiveTimeOut;
            client.ConnectionType = _config.ConnectionType;
            client.LocalTSAP = _config.LocalTSAP;
            client.SetPersistentConnection();
            base.Client = client;
            return client;
        }
        public override OperateResult Connect()
        {
            return ( (SiemensS7Net) Client! ).ConnectServer();
        }
        public override OperateResult Disconnect()
        {
            return ((SiemensS7Net)Client! ).ConnectClose();
        }
    }
}
