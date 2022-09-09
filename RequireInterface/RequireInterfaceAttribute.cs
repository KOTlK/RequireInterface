using System;
using UnityEngine;

namespace RequireInterface
{
    public class RequireInterfaceAttribute : PropertyAttribute
    {
        public Type Interface { get; }
        
        public RequireInterfaceAttribute(Type requiredInterface)
        {
            Interface = requiredInterface;
        }
    }
}