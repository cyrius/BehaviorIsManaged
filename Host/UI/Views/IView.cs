﻿#region License GNU GPL
// IView.cs
// 
// Copyright (C) 2012 - BehaviorIsManaged
// 
// This program is free software; you can redistribute it and/or modify it 
// under the terms of the GNU General Public License as published by the Free Software Foundation;
// either version 2 of the License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
// without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. 
// See the GNU General Public License for more details. 
// You should have received a copy of the GNU General Public License along with this program; 
// if not, write to the Free Software Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
#endregion
using System.Windows.Threading;
using BiM.Host.UI.ViewModels;

namespace BiM.Host.UI.Views
{
    public interface IView<T> : IView
        where T : IViewModel
    {
        new T ViewModel
        {
            get;
            set;
        }
    }

    public interface IView
    {
        object ViewModel
        {
            get;
            set;
        }

        Dispatcher Dispatcher
        {
            get;
        }
    }
}