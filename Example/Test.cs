using RequireInterface.Editor;
using UnityEngine;

namespace RequireInterface
{
    public class Test : MonoBehaviour
    {
        [RequireInterface(typeof(ISomeInterface))]
        [SerializeField] private MonoBehaviour _someObject;
    }
}