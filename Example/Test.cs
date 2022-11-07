using Kotik.RequireInterface;
using UnityEngine;

namespace Kotik.Example
{
    public class Test : MonoBehaviour
    {
        [RequireInterface(typeof(ISomeInterface))]
        [SerializeField] private MonoBehaviour _someObject;
    }
}