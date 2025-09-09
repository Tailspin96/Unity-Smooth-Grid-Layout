using System;
using UnityEngine;

namespace Tailspin96.SmoothGridLayout
{
    public class ItemHolderManager : MonoBehaviour
    {
        public static event Action ItemLayoutChanged;

        private void OnTransformChildrenChanged()
        {
            ItemLayoutChanged?.Invoke();
        }
    }
}
