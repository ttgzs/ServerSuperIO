﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServerSuperIO.Communicate;
using ServerSuperIO.Communicate.NET;

namespace ServerSuperIO.Config
{
    [Serializable]
    public class ServerConfig:IServerConfig
    {
        public ServerConfig():this("Server-" + DateTime.Now.ToString("yyyyMMddHHmmss"))
        {
           
        }

        public ServerConfig(string serverName)
        {
            ServerSession = Guid.NewGuid().ToString();
            ServerName = serverName;
            if (String.IsNullOrEmpty(ServerName))
            {
                ServerName = "Server-" + DateTime.Now.ToString("yyyyMMddHHmmss");
            }
            ComReadBufferSize = 1024;
            ComWriteBufferSize = 1024;
            ComReadTimeout = 1000;
            ComWriteTimeout = 1000;
            ComLoopInterval = 1000;
            NetReceiveBufferSize = 1024;
            NetSendBufferSize = 1024;
            NetReceiveTimeout = 1024;
            NetSendTimeout = 1024;
            NetLoopInterval = 1000;
            MaxConnects = 10000;
            ControlMode=ControlMode.Loop;
            ListenPort = 6699;
            BackLog = 1000;
            CheckSameSocketSession = true;
            SocketMode=SocketMode.Tcp;
            DeliveryMode=DeliveryMode.DeviceIP;
            StartReceiveDataFliter = false;
            ClearSocketSession = true;
            ClearSocketSessionInterval = 5;
            ClearSocketSessionTimeOut = 30;
        }

        public string ServerSession { get; set; }

        public string ServerName { get; set; }

        public int ComReadBufferSize { get; set; }

        public int ComWriteBufferSize { get; set; }

        public int ComReadTimeout { get; set; }

        public int ComWriteTimeout { get; set; }

        public int ComLoopInterval { get; set; }

        public int NetReceiveBufferSize { get; set; }

        public int NetSendBufferSize { get; set; }

        public int NetReceiveTimeout { get; set; }

        public int NetSendTimeout { get; set; }

        public int NetLoopInterval { get; set; }

        public int MaxConnects { get; set; }

        public ControlMode ControlMode { get; set; }

        public uint KeepAlive { get; set; }

        public int ListenPort { get; set; }

        public int BackLog { get; set; }

        public bool CheckSameSocketSession { get; set; }

        public SocketMode SocketMode { get; set; }

        public DeliveryMode DeliveryMode { get; set; }

        public bool StartReceiveDataFliter { get; set; }

        public bool ClearSocketSession { get; set; }

        public int ClearSocketSessionInterval { get; set; }

        public int ClearSocketSessionTimeOut { get; set; }
    }
}
