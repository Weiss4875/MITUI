using System;
using System.Collections.Generic;
using System.IO;
using AnimatedImages;
using UMod;
using UniGLTF;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using VRM;
using Warudo.Core;
using Warudo.Core.Resource;
using Warudo.Core.Utils;
using Warudo.Plugins.Core.Utils;
using Object = UnityEngine.Object;
using System;

namespace Warudo.Plugins.Core
{
    public partial class CorePlugin
    {
        public abstract class LocalCharacterResourceUriResolver : IResourceUriResolver
        {
            public abstract object Resolve(Uri uri);
            protected object Resolve(Uri resourceUri, string localPath)
            {
                throw new NotImplementedException();
            }
        }

        public class PersistentDataDirectoryCharacterResourceUriResolver : LocalCharacterResourceUriResolver
        {
            public override object Resolve(Uri uri)
            {
                throw new NotImplementedException();
            }
        }

        public abstract class LocalCharacterAnimationResourceUriResolver : IResourceUriResolver
        {
            public abstract object Resolve(Uri uri);
            protected object Resolve(string localPath)
            {
                throw new NotImplementedException();
            }
        }

        public class PersistentDataDirectoryCharacterAnimationResourceUriResolver : LocalCharacterAnimationResourceUriResolver
        {
            public override object Resolve(Uri uri)
            {
                throw new NotImplementedException();
            }
        }

        public abstract class LocalPropResourceUriResolver : IResourceUriResolver
        {
            public abstract object Resolve(Uri uri);
            public object Resolve(Uri resourceUri, string localPath)
            {
                throw new NotImplementedException();
            }
        }

        public class PersistentDataDirectoryPropResourceUriResolver : LocalPropResourceUriResolver
        {
            public override object Resolve(Uri uri)
            {
                throw new NotImplementedException();
            }
        }

        public abstract class LocalParticleResourceUriResolver : IResourceUriResolver
        {
            public abstract object Resolve(Uri uri);
            public object Resolve(Uri resourceUri, string localPath)
            {
                throw new NotImplementedException();
            }
        }

        public class PersistentDataDirectoryParticleResourceUriResolver : LocalParticleResourceUriResolver
        {
            public override object Resolve(Uri uri)
            {
                throw new NotImplementedException();
            }
        }

        public abstract class LocalEnvironmentResourceUriResolver : IResourceUriResolver
        {
            public abstract object Resolve(Uri uri);
            public object Resolve(string localPath)
            {
                throw new NotImplementedException();
            }
        }

        public class PersistentDataDirectoryEnvironmentResourceUriResolver : LocalEnvironmentResourceUriResolver
        {
            public override object Resolve(Uri uri)
            {
                throw new NotImplementedException();
            }
        }

        public abstract class LocalSoundResourceUriResolver : IResourceUriResolver
        {
            public abstract object Resolve(Uri uri);
            public object Resolve(string localPath)
            {
                throw new NotImplementedException();
            }
        }

        public class PersistentDataDirectorySoundResourceUriResolver : LocalSoundResourceUriResolver
        {
            public override object Resolve(Uri uri)
            {
                throw new NotImplementedException();
            }
        }

        public abstract class LocalImageResourceUriResolver : IResourceUriResolver
        {
            public abstract object Resolve(Uri uri);
            public object Resolve(string localPath)
            {
                throw new NotImplementedException();
            }
        }

        public class PersistentDataDirectoryImageResourceUriResolver : LocalImageResourceUriResolver
        {
            public override object Resolve(Uri uri)
            {
                throw new NotImplementedException();
            }
        }

        public abstract class LocalVideoResourceUriResolver : IResourceUriResolver
        {
            public abstract object Resolve(Uri uri);
            public object Resolve(string localPath)
            {
                throw new NotImplementedException();
            }
        }

        public class PersistentDataDirectoryVideoResourceUriResolver : LocalVideoResourceUriResolver
        {
            public override object Resolve(Uri uri)
            {
                throw new NotImplementedException();
            }
        }

        public class ResourceDirectoryCharacterAnimationResourceUriResolver : IResourceUriResolver
        {
            public object Resolve(Uri uri)
            {
                throw new NotImplementedException();
            }
        }

        public class ResourceDirectoryGameObjectResourceUriResolver : IResourceUriResolver
        {
            public object Resolve(Uri uri)
            {
                throw new NotImplementedException();
            }
        }

        public class ResourceDirectoryTexture2DResourceUriResolver : IResourceUriResolver
        {
            public object Resolve(Uri uri)
            {
                throw new NotImplementedException();
            }
        }

        public class ResourceDirectoryAudioClipResourceUriResolver : IResourceUriResolver
        {
            public object Resolve(Uri uri)
            {
                throw new NotImplementedException();
            }
        }

        public class DebugCharacterResourceUriResolver : IResourceUriResolver
        {
            public object Resolve(Uri uri)
            {
                throw new NotImplementedException();
            }
        }

        public class DebugPropResourceUriResolver : IResourceUriResolver
        {
            public object Resolve(Uri uri)
            {
                throw new NotImplementedException();
            }
        }
    }
}