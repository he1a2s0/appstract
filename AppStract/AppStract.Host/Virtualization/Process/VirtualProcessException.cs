﻿#region Copyright (C) 2009-2010 Simon Allaeys

/*
    Copyright (C) 2009-2010 Simon Allaeys
 
    This file is part of AppStract

    AppStract is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    AppStract is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with AppStract.  If not, see <http://www.gnu.org/licenses/>.
*/

#endregion

using System;
using System.Runtime.Serialization;

namespace AppStract.Host.Virtualization.Process
{
  /// <summary>
  /// Represents errors related to a <see cref="VirtualizedProcess"/>.
  /// </summary>
  [Serializable]
  public class VirtualProcessException : HostException
  {

    #region Constructors

    public VirtualProcessException()
    { }

    public VirtualProcessException(string message)
      : base(message)
    { }

    public VirtualProcessException(string message, Exception innerException)
      : base (message, innerException)
    { }

    protected VirtualProcessException(SerializationInfo info, StreamingContext ctxt)
      : base(info, ctxt) { }

    #endregion

  }
}
