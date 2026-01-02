using System;
using System.Collections.Generic;

namespace Warudo.Core.Serializations {
    [Serializable]
    public class SerializedFlow {
        public List<SerializedFlowConnection> activeFlowConnections;
        public List<SerializedDataConnection> activeDataConnections;
    }
}
