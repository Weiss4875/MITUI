using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class AvatarPartsAttachEvent : UnityEngine.Events.UnityEvent<MagicaAvatar, MagicaAvatarParts>
    {
    }

    public class AvatarPartsDetachEvent : UnityEngine.Events.UnityEvent<MagicaAvatar>
    {
    }

    public class PhysicsManagerPreUpdateEvent : UnityEngine.Events.UnityEvent
    {
    }

    public class PhysicsManagerPostUpdateEvent : UnityEngine.Events.UnityEvent
    {
    }
}