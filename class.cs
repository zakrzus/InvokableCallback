using System;
using System.Linq;
using UnityEngine;
using Object = UnityEngine.Object;

namespace InvokableCallbackBaseNamespace
{
    public abstract class InvokableCallbackBase<TReturn>
    {
        public abstract TReturn Invoke(params object[] args);
    }
}
namespace InvokableCallbackNamespace
{
    using InvokableCallbackBaseNamespace;
    public class InvokableCallback<TReturn> : InvokableCallbackBase<TReturn>
    {

        public Func<TReturn> func;

        public TReturn Invoke()
        {
            return func();
        }

        public override TReturn Invoke(params object[] args)
        {
            return func();
        }

        /// <summary> Constructor </summary>
        public InvokableCallback(object target, string methodName)
        {
            if (target == null || string.IsNullOrEmpty(methodName))
            {
                func = () => default(TReturn);
            }
            else
            {
                func = (System.Func<TReturn>)System.Delegate.CreateDelegate(typeof(System.Func<TReturn>), target, methodName);
            }
        }
    }

    public class InvokableCallback<T0, TReturn> : InvokableCallbackBase<TReturn>
    {

        public Func<T0, TReturn> func;

        public TReturn Invoke(T0 arg0)
        {
            return func(arg0);
        }

        public override TReturn Invoke(params object[] args)
        {
            return func((T0)args[0]);
        }

        /// <summary> Constructor </summary>
        public InvokableCallback(object target, string methodName)
        {
            if (target == null || string.IsNullOrEmpty(methodName))
            {
                func = x => default(TReturn);
            }
            else
            {
                func = (System.Func<T0, TReturn>)System.Delegate.CreateDelegate(typeof(System.Func<T0, TReturn>), target, methodName);
            }
        }
    }

    public class InvokableCallback<T0, T1, TReturn> : InvokableCallbackBase<TReturn>
    {

        public Func<T0, T1, TReturn> func;

        public TReturn Invoke(T0 arg0, T1 arg1)
        {
            return func(arg0, arg1);
        }

        public override TReturn Invoke(params object[] args)
        {
            return func((T0)args[0], (T1)args[1]);
        }

        /// <summary> Constructor </summary>
        public InvokableCallback(object target, string methodName)
        {
            if (target == null || string.IsNullOrEmpty(methodName))
            {
                func = (x, y) => default(TReturn);
            }
            else
            {
                func = (System.Func<T0, T1, TReturn>)System.Delegate.CreateDelegate(typeof(System.Func<T0, T1, TReturn>), target, methodName);
            }
        }
    }

    public class InvokableCallback<T0, T1, T2, TReturn> : InvokableCallbackBase<TReturn>
    {

        public Func<T0, T1, T2, TReturn> func;

        public TReturn Invoke(T0 arg0, T1 arg1, T2 arg2)
        {
            return func(arg0, arg1, arg2);
        }

        public override TReturn Invoke(params object[] args)
        {
            return func((T0)args[0], (T1)args[1], (T2)args[2]);
        }

        /// <summary> Constructor </summary>
        public InvokableCallback(object target, string methodName)
        {
            if (target == null || string.IsNullOrEmpty(methodName))
            {
                func = (x, y, z) => default(TReturn);
            }
            else
            {
                func = (System.Func<T0, T1, T2, TReturn>)System.Delegate.CreateDelegate(typeof(System.Func<T0, T1, T2, TReturn>), target, methodName);
            }
        }
    }

    public class InvokableCallback<T0, T1, T2, T3, TReturn> : InvokableCallbackBase<TReturn>
    {

        public Func<T0, T1, T2, T3, TReturn> func;

        public TReturn Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3)
        {
            return func(arg0, arg1, arg2, arg3);
        }

        public override TReturn Invoke(params object[] args)
        {
            return func((T0)args[0], (T1)args[1], (T2)args[2], (T3)args[3]);
        }

        /// <summary> Constructor </summary>
        public InvokableCallback(object target, string methodName)
        {
            if (target == null || string.IsNullOrEmpty(methodName))
            {
                func = (x, y, z, w) => default(TReturn);
            }
            else
            {
                func = (System.Func<T0, T1, T2, T3, TReturn>)System.Delegate.CreateDelegate(typeof(System.Func<T0, T1, T2, T3, TReturn>), target, methodName);
            }
        }
    }
}
namespace InvokableEventBaseNamespace
{
    public abstract class InvokableEventBase
    {
        public abstract void Invoke(params object[] args);
    }
}
namespace InvokableEventNamespace
{
    using InvokableEventBaseNamespace;
    public class InvokableEvent : InvokableEventBase
    {

        public System.Action action;

        public void Invoke()
        {
            action();
        }

        public override void Invoke(params object[] args)
        {
            action();
        }

        /// <summary> Constructor </summary>
        public InvokableEvent(object target, string methodName)
        {
            if (target == null || string.IsNullOrEmpty(methodName))
            {
                action = () => { };
            }
            else
            {
                action = (System.Action)System.Delegate.CreateDelegate(typeof(System.Action), target, methodName);
            }
        }
    }

    public class InvokableEvent<T0> : InvokableEventBase
    {

        public Action<T0> action;

        public void Invoke(T0 arg0)
        {
            action(arg0);
        }

        public override void Invoke(params object[] args)
        {
            action((T0)args[0]);
        }

        /// <summary> Constructor </summary>
        public InvokableEvent(object target, string methodName)
        {
            if (target == null || string.IsNullOrEmpty(methodName))
            {
                action = x => { };
            }
            else
            {
                action = (System.Action<T0>)System.Delegate.CreateDelegate(typeof(System.Action<T0>), target, methodName);
            }
        }
    }

    public class InvokableEvent<T0, T1> : InvokableEventBase
    {

        public Action<T0, T1> action;

        public void Invoke(T0 arg0, T1 arg1)
        {
            action(arg0, arg1);
        }

        public override void Invoke(params object[] args)
        {
            action((T0)args[0], (T1)args[1]);
        }

        /// <summary> Constructor </summary>
        public InvokableEvent(object target, string methodName)
        {
            if (target == null || string.IsNullOrEmpty(methodName))
            {
                action = (x, y) => { };
            }
            else
            {
                action = (System.Action<T0, T1>)System.Delegate.CreateDelegate(typeof(System.Action<T0, T1>), target, methodName);
            }
        }
    }

    public class InvokableEvent<T0, T1, T2> : InvokableEventBase
    {

        public Action<T0, T1, T2> action;

        public void Invoke(T0 arg0, T1 arg1, T2 arg2)
        {
            action(arg0, arg1, arg2);
        }

        public override void Invoke(params object[] args)
        {
            action((T0)args[0], (T1)args[1], (T2)args[2]);
        }

        /// <summary> Constructor </summary>
        public InvokableEvent(object target, string methodName)
        {
            if (target == null || string.IsNullOrEmpty(methodName))
            {
                action = (x, y, z) => { };
            }
            else
            {
                action = (System.Action<T0, T1, T2>)System.Delegate.CreateDelegate(typeof(System.Action<T0, T1, T2>), target, methodName);
            }
        }
    }

    public class InvokableEvent<T0, T1, T2, T3> : InvokableEventBase
    {

        public Action<T0, T1, T2, T3> action;

        public void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3)
        {
            action(arg0, arg1, arg2, arg3);
        }

        public override void Invoke(params object[] args)
        {
            action((T0)args[0], (T1)args[1], (T2)args[2], (T3)args[3]);
        }

        /// <summary> Constructor </summary>
        public InvokableEvent(object target, string methodName)
        {
            if (target == null || string.IsNullOrEmpty(methodName))
            {
                action = (x, y, z, w) => { };
            }
            else
            {
                action = (System.Action<T0, T1, T2, T3>)System.Delegate.CreateDelegate(typeof(System.Action<T0, T1, T2, T3>), target, methodName);
            }
        }
    }

}
namespace SerializableCallbackBaseNamespace
{
    using InvokableCallbackBaseNamespace;
    using InvokableCallbackNamespace;
    public abstract class SerializableCallbackBase<TReturn> : SerializableCallbackBase
    {
        public InvokableCallbackBase<TReturn> func;

        public override void ClearCache()
        {
            base.ClearCache();
            func = null;
        }

        protected InvokableCallbackBase<TReturn> GetPersistentMethod()
        {
            Type[] types = new Type[ArgTypes.Length + 1];
            Array.Copy(ArgTypes, types, ArgTypes.Length);
            types[types.Length - 1] = typeof(TReturn);

            Type genericType = null;
            switch (types.Length)
            {
                case 1:
                    genericType = typeof(InvokableCallback<>).MakeGenericType(types);
                    break;
                case 2:
                    genericType = typeof(InvokableCallback<,>).MakeGenericType(types);
                    break;
                case 3:
                    genericType = typeof(InvokableCallback<,,>).MakeGenericType(types);
                    break;
                case 4:
                    genericType = typeof(InvokableCallback<,,,>).MakeGenericType(types);
                    break;
                case 5:
                    genericType = typeof(InvokableCallback<,,,,>).MakeGenericType(types);
                    break;
                default:
                    throw new ArgumentException(types.Length + "args");
            }
            return Activator.CreateInstance(genericType, new object[] { target, methodName }) as InvokableCallbackBase<TReturn>;
        }
    }

    /// <summary> An inspector-friendly serializable function </summary>
    [System.Serializable]
    public abstract class SerializableCallbackBase : ISerializationCallbackReceiver
    {

        /// <summary> Target object </summary>
        public Object target { get { return _target; } set { _target = value; ClearCache(); } }
        /// <summary> Target method name </summary>
        public string methodName { get { return _methodName; } set { _methodName = value; ClearCache(); } }
        public object[] Args { get { return args != null ? args : args = _args.Select(x => x.GetValue()).ToArray(); } }
        public object[] args;
        public Type[] ArgTypes { get { return argTypes != null ? argTypes : argTypes = _args.Select(x => Arg.RealType(x.argType)).ToArray(); } }
        public Type[] argTypes;
        public bool dynamic { get { return _dynamic; } set { _dynamic = value; ClearCache(); } }

        [SerializeField] protected Object _target;
        [SerializeField] protected string _methodName;
        [SerializeField] protected Arg[] _args;
        [SerializeField] protected bool _dynamic;
	    [SerializeField] private string _typeName;
	    [SerializeField] private bool dirty;

	    protected SerializableCallbackBase() {
		    _typeName = base.GetType().AssemblyQualifiedName;
	    }


        public virtual void ClearCache()
        {
            argTypes = null;
            args = null;
        }

        public void SetMethod(Object target, string methodName, bool dynamic, params Arg[] args)
        {
            _target = target;
            _methodName = methodName;
            _dynamic = dynamic;
            _args = args;
            ClearCache();
        }

        protected abstract void Cache();

        public void OnBeforeSerialize()
        {

		if (dirty) { ClearCache(); dirty = false; }
        }

        public void OnAfterDeserialize()
        {
		_typeName = base.GetType().AssemblyQualifiedName;

        }
    }

    [System.Serializable]
    public struct Arg
    {
        public enum ArgType { Unsupported, Bool, Int, Float, String, Object }
        public bool boolValue;
        public int intValue;
        public float floatValue;
        public string stringValue;
        public Object objectValue;
        public ArgType argType;

        public object GetValue()
        {
            return GetValue(argType);
        }

        public object GetValue(ArgType type)
        {
            switch (type)
            {
                case ArgType.Bool:
                    return boolValue;
                case ArgType.Int:
                    return intValue;
                case ArgType.Float:
                    return floatValue;
                case ArgType.String:
                    return stringValue;
                case ArgType.Object:
                    return objectValue;
                default:
                    return null;
            }
        }

        public static Type RealType(ArgType type)
        {
            switch (type)
            {
                case ArgType.Bool:
                    return typeof(bool);
                case ArgType.Int:
                    return typeof(int);
                case ArgType.Float:
                    return typeof(float);
                case ArgType.String:
                    return typeof(string);
                case ArgType.Object:
                    return typeof(Object);
                default:
                    return null;
            }
        }

        public static ArgType FromRealType(Type type)
        {
            if (type == typeof(bool)) return ArgType.Bool;
            else if (type == typeof(int)) return ArgType.Int;
            else if (type == typeof(float)) return ArgType.Float;
            else if (type == typeof(String)) return ArgType.String;
            else if (type == typeof(Object)) return ArgType.Object;
            else return ArgType.Unsupported;
        }

        public static bool IsSupported(Type type)
        {
            return FromRealType(type) != ArgType.Unsupported;
        }
    }
}
namespace SerializableCallbackNamespace
{
    using SerializableCallbackBaseNamespace;
    using InvokableCallbackNamespace;
    public abstract class SerializableCallback<TReturn> : SerializableCallbackBase<TReturn>
    {
        public TReturn Invoke()
        {
            if (func == null) Cache();
            if (_dynamic)
            {
                InvokableCallback<TReturn> call = func as InvokableCallback<TReturn>;
                return call.Invoke();
            }
            else
            {
                return func.Invoke(Args);
            }
        }

        protected override void Cache()
        {
            if (_target == null || string.IsNullOrEmpty(_methodName))
            {
                func = new InvokableCallback<TReturn>(null, null);
            }
            else
            {
                if (_dynamic)
                {
                    func = new InvokableCallback<TReturn>(target, methodName);
                }
                else
                {
                    func = GetPersistentMethod();
                }
            }
        }
    }

    public abstract class SerializableCallback<T0, TReturn> : SerializableCallbackBase<TReturn>
    {
        public TReturn Invoke(T0 arg0)
        {
            if (func == null) Cache();
            if (_dynamic)
            {
                InvokableCallback<T0, TReturn> call = func as InvokableCallback<T0, TReturn>;
                return call.Invoke(arg0);
            }
            else
            {
                return func.Invoke(Args);
            }
        }

        protected override void Cache()
        {
            if (_target == null || string.IsNullOrEmpty(_methodName))
            {
                func = new InvokableCallback<T0, TReturn>(null, null);
            }
            else
            {
                if (_dynamic)
                {
                    func = new InvokableCallback<T0, TReturn>(target, methodName);
                }
                else
                {
                    func = GetPersistentMethod();
                }
            }
        }
    }

    public abstract class SerializableCallback<T0, T1, TReturn> : SerializableCallbackBase<TReturn>
    {
        public TReturn Invoke(T0 arg0, T1 arg1)
        {
            if (func == null) Cache();
            if (_dynamic)
            {
                InvokableCallback<T0, T1, TReturn> call = func as InvokableCallback<T0, T1, TReturn>;
                return call.Invoke(arg0, arg1);
            }
            else
            {
                return func.Invoke(Args);
            }
        }

        protected override void Cache()
        {
            if (_target == null || string.IsNullOrEmpty(_methodName))
            {
                func = new InvokableCallback<T0, T1, TReturn>(null, null);
            }
            else
            {
                if (_dynamic)
                {
                    func = new InvokableCallback<T0, T1, TReturn>(target, methodName);
                }
                else
                {
                    func = GetPersistentMethod();
                }
            }
        }
    }

    public abstract class SerializableCallback<T0, T1, T2, TReturn> : SerializableCallbackBase<TReturn>
    {
        public TReturn Invoke(T0 arg0, T1 arg1, T2 arg2)
        {
            if (func == null) Cache();
            if (_dynamic)
            {
                InvokableCallback<T0, T1, T2, TReturn> call = func as InvokableCallback<T0, T1, T2, TReturn>;
                return call.Invoke(arg0, arg1, arg2);
            }
            else
            {
                return func.Invoke(Args);
            }
        }

        protected override void Cache()
        {
            if (_target == null || string.IsNullOrEmpty(_methodName))
            {
                func = new InvokableCallback<T0, T1, T2, TReturn>(null, null);
            }
            else
            {
                if (_dynamic)
                {
                    func = new InvokableCallback<T0, T1, T2, TReturn>(target, methodName);
                }
                else
                {
                    func = GetPersistentMethod();
                }
            }
        }
    }

    public abstract class SerializableCallback<T0, T1, T2, T3, TReturn> : SerializableCallbackBase<TReturn>
    {
        public TReturn Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3)
        {
            if (func == null) Cache();
            if (_dynamic)
            {
                InvokableCallback<T0, T1, T2, T3, TReturn> call = func as InvokableCallback<T0, T1, T2, T3, TReturn>;
                return call.Invoke(arg0, arg1, arg2, arg3);
            }
            else
            {
                return func.Invoke(Args);
            }
        }

        protected override void Cache()
        {
            if (_target == null || string.IsNullOrEmpty(_methodName))
            {
                func = new InvokableCallback<T0, T1, T2, T3, TReturn>(null, null);
            }
            else
            {
                if (_dynamic)
                {
                    func = new InvokableCallback<T0, T1, T2, T3, TReturn>(target, methodName);
                }
                else
                {
                    func = GetPersistentMethod();
                }
            }
        }
    }
}
namespace SerializableEventBaseNamespace
{
    using SerializableCallbackBaseNamespace;
    using InvokableEventBaseNamespace;
    using InvokableEventNamespace;
    public abstract class SerializableEventBase : SerializableCallbackBase
    {
        public InvokableEventBase invokable;

        public override void ClearCache()
        {
            base.ClearCache();
            invokable = null;
        }

        protected InvokableEventBase GetPersistentMethod()
        {
            Type[] types = new Type[ArgTypes.Length];
            Array.Copy(ArgTypes, types, ArgTypes.Length);

            Type genericType = null;
            switch (types.Length)
            {
                case 0:
                    genericType = typeof(InvokableEvent).MakeGenericType(types);
                    break;
                case 1:
                    genericType = typeof(InvokableEvent<>).MakeGenericType(types);
                    break;
                case 2:
                    genericType = typeof(InvokableEvent<,>).MakeGenericType(types);
                    break;
                case 3:
                    genericType = typeof(InvokableEvent<,,>).MakeGenericType(types);
                    break;
                case 4:
                    genericType = typeof(InvokableEvent<,,,>).MakeGenericType(types);
                    break;
                default:
                    throw new ArgumentException(types.Length + "args");
            }
            return Activator.CreateInstance(genericType, new object[] { target, methodName }) as InvokableEventBase;
        }
    }
}
namespace SerializableEventNamespace
{
    using SerializableEventBaseNamespace;
    using InvokableEventNamespace;
    [System.Serializable]
    public class SerializableEvent : SerializableEventBase
    {
        public void Invoke()
        {
            if (invokable == null) Cache();
            if (_dynamic)
            {
                InvokableEvent call = invokable as InvokableEvent;
                call.Invoke();
            }
            else
            {
                invokable.Invoke(Args);
            }
        }

        protected override void Cache()
        {
            if (_target == null || string.IsNullOrEmpty(_methodName))
            {
                invokable = new InvokableEvent(null, null);
            }
            else
            {
                if (_dynamic)
                {
                    invokable = new InvokableEvent(target, methodName);
                }
                else
                {
                    invokable = GetPersistentMethod();
                }
            }
        }
    }

    public abstract class SerializableEvent<T0> : SerializableEventBase
    {
        public void Invoke(T0 arg0)
        {
            if (invokable == null) Cache();
            if (_dynamic)
            {
                InvokableEvent<T0> call = invokable as InvokableEvent<T0>;
                call.Invoke(arg0);
            }
            else
            {
                invokable.Invoke(Args);
            }
        }

        protected override void Cache()
        {
            if (_target == null || string.IsNullOrEmpty(_methodName))
            {
                invokable = new InvokableEvent<T0>(null, null);
            }
            else
            {
                if (_dynamic)
                {
                    invokable = new InvokableEvent<T0>(target, methodName);
                }
                else
                {
                    invokable = GetPersistentMethod();
                }
            }
        }
    }

    public abstract class SerializableEvent<T0, T1> : SerializableEventBase
    {
        public void Invoke(T0 arg0, T1 arg1)
        {
            if (invokable == null) Cache();
            if (_dynamic)
            {
                InvokableEvent<T0, T1> call = invokable as InvokableEvent<T0, T1>;
                call.Invoke(arg0, arg1);
            }
            else
            {
                invokable.Invoke(Args);
            }
        }

        protected override void Cache()
        {
            if (_target == null || string.IsNullOrEmpty(_methodName))
            {
                invokable = new InvokableEvent<T0, T1>(null, null);
            }
            else
            {
                if (_dynamic)
                {
                    invokable = new InvokableEvent<T0, T1>(target, methodName);
                }
                else
                {
                    invokable = GetPersistentMethod();
                }
            }
        }
    }

    public abstract class SerializableEvent<T0, T1, T2> : SerializableEventBase
    {
        public void Invoke(T0 arg0, T1 arg1, T2 arg2)
        {
            if (invokable == null) Cache();
            if (_dynamic)
            {
                InvokableEvent<T0, T1, T2> call = invokable as InvokableEvent<T0, T1, T2>;
                call.Invoke(arg0, arg1, arg2);
            }
            else
            {
                invokable.Invoke(Args);
            }
        }

        protected override void Cache()
        {
            if (_target == null || string.IsNullOrEmpty(_methodName))
            {
                invokable = new InvokableEvent<T0, T1, T2>(null, null);
            }
            else
            {
                if (_dynamic)
                {
                    invokable = new InvokableEvent<T0, T1, T2>(target, methodName);
                }
                else
                {
                    invokable = GetPersistentMethod();
                }
            }
        }
    }

    public abstract class SerializableEvent<T0, T1, T2, T3> : SerializableEventBase
    {
        public void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3)
        {
            if (invokable == null) Cache();
            if (_dynamic)
            {
                InvokableEvent<T0, T1, T2, T3> call = invokable as InvokableEvent<T0, T1, T2, T3>;
                call.Invoke(arg0, arg1, arg2, arg3);
            }
            else
            {
                invokable.Invoke(Args);
            }
        }

        protected override void Cache()
        {
            if (_target == null || string.IsNullOrEmpty(_methodName))
            {
                invokable = new InvokableEvent<T0, T1, T2, T3>(null, null);
            }
            else
            {
                if (_dynamic)
                {
                    invokable = new InvokableEvent<T0, T1, T2, T3>(target, methodName);
                }
                else
                {
                    invokable = GetPersistentMethod();
                }
            }
        }
    }
}
namespace SerializableClassEditor
{
    public class TargetConstraintAttribute : PropertyAttribute
    {
        public Type targetType;

        /// <summary> Add to fields of your class extending SerializableCallbackBase<T,..> to limit which types can be assigned to it. </summary>
        public TargetConstraintAttribute(Type targetType)
        {
            this.targetType = targetType;
        }
    }
}
