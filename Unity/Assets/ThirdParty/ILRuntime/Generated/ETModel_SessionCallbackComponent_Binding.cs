using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class ETModel_SessionCallbackComponent_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(ETModel.SessionCallbackComponent);

            field = type.GetField("DisposeCallback", flag);
            app.RegisterCLRFieldGetter(field, get_DisposeCallback_0);
            app.RegisterCLRFieldSetter(field, set_DisposeCallback_0);
            field = type.GetField("MessageCallback", flag);
            app.RegisterCLRFieldGetter(field, get_MessageCallback_1);
            app.RegisterCLRFieldSetter(field, set_MessageCallback_1);


        }



        static object get_DisposeCallback_0(ref object o)
        {
            return ((ETModel.SessionCallbackComponent)o).DisposeCallback;
        }
        static void set_DisposeCallback_0(ref object o, object v)
        {
            ((ETModel.SessionCallbackComponent)o).DisposeCallback = (System.Action<ETModel.Session>)v;
        }
        static object get_MessageCallback_1(ref object o)
        {
            return ((ETModel.SessionCallbackComponent)o).MessageCallback;
        }
        static void set_MessageCallback_1(ref object o, object v)
        {
            ((ETModel.SessionCallbackComponent)o).MessageCallback = (System.Action<ETModel.Session, ETModel.Packet>)v;
        }


    }
}
