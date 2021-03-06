﻿//**********************
//SwEx.AddIn - development tools for SOLIDWORKS add-ins
//Copyright(C) 2018 www.codestack.net
//License: https://github.com/codestack-net-dev/sw-dev-tools-addin/blob/master/LICENSE
//Product URL: https://www.codestack.net/labs/solidworks/swex/add-in/
//**********************

using System;
using System.ComponentModel;

namespace CodeStack.SwEx.AddIn.Attributes
{
    /// <summary>
    /// Decorates the display name for the element (e.g. command)
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    public class TitleAttribute : DisplayNameAttribute
    {   
        public TitleAttribute(string dispName) : base(dispName)
        {
        }
    }
}
