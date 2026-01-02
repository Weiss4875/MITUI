using System;
using System.Collections.Generic;
using Warudo.Core.Localization;
using Warudo.Core.Utils;

namespace Warudo.Core.Serializations {
    public abstract class SerializedEntity : ILocalizable {
        public Guid id;
        
        public Dictionary<string, SerializedDataInputPort> dataInputs;
        public Dictionary<string, SerializedTriggerPort> triggers;
        
        public virtual void Localize() {
            dataInputs.ForEach(it => it.Value.Localize());
            triggers.ForEach(it => it.Value.Localize());
        }
    }
}
