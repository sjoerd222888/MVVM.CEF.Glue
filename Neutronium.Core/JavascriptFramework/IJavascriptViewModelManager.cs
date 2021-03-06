﻿using System;

namespace Neutronium.Core.JavascriptFramework 
{
    public interface IJavascriptViewModelManager: IDisposable 
    {

        /// <summary>
        /// Returns an IJavascriptSessionInjector 
        /// </summary>
        IJavascriptSessionInjector Injector { get; }

        /// <summary>
        /// Returns an IJavascriptViewModelUpdater 
        /// </summary>
        IJavascriptViewModelUpdater ViewModelUpdater { get; }
    }
}
