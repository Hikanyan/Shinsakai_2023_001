using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gameplay
{
    public class BootLoader : MonoBehaviour
    {
        [SerializeField]
        SequenceManager _sequenceManagerPrefab;
        void Start()
        {
            Instantiate(_sequenceManagerPrefab);
            SequenceManager.Instance.Initialize();
        }
}

