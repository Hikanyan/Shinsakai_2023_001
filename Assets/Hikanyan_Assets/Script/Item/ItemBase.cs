using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemBase : MonoBehaviour
{
    // Start is called before the first frame update
    protected abstract void Activate();//protectedは自分のクラスと派生クラスでのみ参照できる

}
