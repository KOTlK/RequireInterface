# RequireInterface
Simple package for interface injection through inspector.


# Usage

Use `RequireInterface` attribute on `MonoBehaviour` component.
``` c#
[RequireInterface(typeof(ISomeInterface))]
[SerializeField] private MonoBehaviour _someComponent;
```

If object, you put in inspector field, doesn't implement interface, error will occur.