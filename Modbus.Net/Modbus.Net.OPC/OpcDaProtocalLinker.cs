﻿using System.Text;

namespace Modbus.Net.OPC
{
    /// <summary>
    /// Opc Da协议连接器
    /// </summary>
    public class OpcDaProtocalLinker : OpcProtocalLinker
    {
        public OpcDaProtocalLinker() : this(ConfigurationManager.OpcDaHost)
        {
        }

        public OpcDaProtocalLinker(string host)
        {
            BaseConnector = OpcDaConnector.Instance(host);
        }
    }
}