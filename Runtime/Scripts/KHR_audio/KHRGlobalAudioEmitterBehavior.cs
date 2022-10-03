using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ThirdRoom
{
    public class KHRGlobalAudioEmitterBehavior : MonoBehaviour
    {
        public List<AudioSourceScriptableObject> sources;
        public float gain = 1.0f;
    }
}