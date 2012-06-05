﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v6.5.0, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10.
//     Changes to this template will be lost.
//
//     Template: AsyncChildLoader.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Csla;
using Csla.Serialization;

namespace PetShop.Tests.ObjF.StoredProcedures
{
    [Serializable]
    public class AsyncChildLoader<T> : ReadOnlyBase<AsyncChildLoader<T>>
    {
        public static PropertyInfo<T> ChildProperty = RegisterProperty<T>(c => c.Child);
        public T Child
        {
            get { return ReadProperty(ChildProperty); }
            private set { LoadProperty(ChildProperty, value); }
        }

        protected void DataPortal_Fetch(object criteria)
        {
            Child = DataPortal.FetchChild<T>(criteria);
        }
    }
}
