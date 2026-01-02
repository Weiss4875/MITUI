using UnityEngine;
using UnityEngine.UI;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class UIPartsItem : MonoBehaviour
    {
        public Text text;
        public Button prefButton;
        public Button nextButton;
        void Start()
        {
            throw new NotImplementedException();
        }

        public void Init(string title, int id, System.Action<int, int> onClick)
        {
            throw new NotImplementedException();
        }
    }
}