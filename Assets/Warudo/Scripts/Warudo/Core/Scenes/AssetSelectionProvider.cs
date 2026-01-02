using System;
using System.Linq;
using Cysharp.Threading.Tasks;
using Newtonsoft.Json;
using Warudo.Core.Data;
using Warudo.Core.Localization;
using Warudo.Core.Serializations;
using Warudo.Core.Utils;

namespace Warudo.Core.Scenes {
    public static class AssetSelectionProvider {
        
        public static Func<UniTask<AutoCompleteList>> For(Type type, Predicate<Asset> filter = default) {
            // TODO: Cache and reuse provider for the same type
            return async () =>
            {
                var assets = Context.OpenedScene.GetAssets()
                    .Where(it => it.Value.GetType().InheritsFrom(type))
                    .ToList();
                
                if (filter != default) {
                    assets = assets.Where(it => filter(it.Value)).ToList();
                }

                if (assets.Count == 0) {
                    return AutoCompleteList.Message("NO_COMPATIBLE_ASSETS_FOUND_IN_SCENE");
                }
                
                var section = new AutoCompleteCategory {
                    title = null,
                    entries = new()
                };
                
                foreach (var (id, asset) in assets) {
                    section.entries.Add(new AutoCompleteEntry {
                        label = asset.Name + (asset.Active ? "" : "INACTIVE_SUFFIX".Localized()),
                        value = JsonConvert.SerializeObject(new AssetIdentifier {
                            name = asset.Name,
                            id = id
                        })
                    });
                }

                return new AutoCompleteList {
                    categories = new() {
                        section
                    }
                };
            };
        }

    }
}
