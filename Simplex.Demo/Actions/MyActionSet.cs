﻿using System;
using System.Collections.Generic;
using System.Reactive;
using System.Text;
using Tmon.Simplex.Actions;
using Tmon.Simplex.Demo.Models;

namespace Tmon.Simplex.Demo.Actions
{
    public class MyActionSet : AbstractActionBinderSet
    {
        public IActionBinder<SendSignal, Unit> SendSignal
            => GetOrAdd<SendSignal, Unit>();

        public IActionBinder<GetBoolean, bool, bool> GetBoolean
            => GetOrAdd<GetBoolean, bool, bool>();

        public IActionBinder<GetIntegerString, int, string> GetInteger
            => GetOrAdd<GetIntegerString, int, string>();

        public SecondActionSet SecondsSet
            => GetOrAdd<SecondActionSet>();
    }

    public class SecondActionSet : AbstractActionBinderSet
    {
        public IActionBinder<GetBoolean, bool, bool> GetBoolean2
            => GetOrAdd<GetBoolean, bool, bool>();

        public IActionBinder<GetRealtimeKeywordList, IEnumerable<PopularKeyword>> GetRealtimeKeywordList
            => GetOrAdd<GetRealtimeKeywordList, IEnumerable<PopularKeyword>>();
    }
}
