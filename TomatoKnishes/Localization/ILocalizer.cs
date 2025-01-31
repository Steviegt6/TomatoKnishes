﻿#region License
// Copyright (C) 2021 Tomat and Contributors, MIT License
#endregion

using System;

namespace TomatoKnishes.Localization
{
    /// <summary>
    ///     Provides localization for an assembly.
    /// </summary>
    public interface ILocalizer
    {
        /// <summary>
        ///     Add a provider instance.
        /// </summary>
        void AddProvider<T, TInner>() where T : ILocalizationProvider<TInner>, new() where TInner : Enum;

        T? GetProvider<T, TInner>() where T : ILocalizationProvider<TInner> where TInner : Enum;

        /// <summary>
        ///     Retrieves a localized text entry.
        /// </summary>
        ILocalizedTextEntry GetLocalizedTextEntry<T>(T key) where T : Enum;

        /// <summary>
        ///     Retrieves a localized text entry's string value.
        /// </summary>
        string GetLocalizedText<T>(T key) where T : Enum;
    }
}