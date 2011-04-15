﻿using System;
using OpenCover.Framework.Common;

namespace OpenCover.Framework.Model
{
    ///<summary>
    /// An instrumentedpoint that has been visited
    ///</summary>
    public class VisitPoint
    {
        public VisitType VisitType { get; set; }
        public UInt32 UniqueId { get; set; }
    }
}