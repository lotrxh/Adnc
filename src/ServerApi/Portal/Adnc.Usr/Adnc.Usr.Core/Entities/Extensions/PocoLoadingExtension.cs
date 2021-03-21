﻿using System;
using System.Runtime.CompilerServices;

namespace Adnc.Usr.Core.Entities
{
    /// <summary>
    /// 延时加载扩展方法
    /// </summary>
    public static class PocoLoadingExtension
    {
        public static TRelated Load<TRelated>(
             this Action<object, string> loader,
             object entity,
             ref TRelated navigationField,
             [CallerMemberName] string navigationName = null)
             where TRelated : class
        {
            loader?.Invoke(entity, navigationName);

            return navigationField;
        }

    }
}
