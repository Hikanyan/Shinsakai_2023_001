using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hikanyan.Core
{
    public abstract class View : MonoBehaviour
    {
        public virtual void Initialize()
        {
        }
        public virtual void Show()
        {
            gameObject.SetActive(true);
        }
        public virtual void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}