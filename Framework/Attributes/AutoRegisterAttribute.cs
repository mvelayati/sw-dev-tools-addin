﻿//**********************
//SwEx.AddIn - development tools for SOLIDWORKS add-ins
//Copyright(C) 2018 www.codestack.net
//License: https://github.com/codestack-net-dev/sw-dev-tools-addin/blob/master/LICENSE
//Product URL: https://www.codestack.net/labs/solidworks/swex/add-in/
//**********************

using System;

namespace CodeStack.SwEx.AddIn.Attributes
{
    /// <summary>
    /// Automatically adds the information about the add-in into the registry
    /// </summary>
    /// <remarks>The registration is triggered when the add-in is registered as COM assembly using the regasm utility</remarks>
    [AttributeUsage(AttributeTargets.Class)]
    public class AutoRegisterAttribute : Attribute
    {
        /// <summary>
        /// Title of the add-in
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// Description of the add-in
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Indicates if the add-in should be loaded at startup
        /// </summary>
        public bool LoadAtStartup { get; private set; }

        public AutoRegisterAttribute(string title = "", string desc = "", bool loadAtStartup = true)
        {
            Title = title;
            Description = desc;
            LoadAtStartup = loadAtStartup;
        }
    }
}
