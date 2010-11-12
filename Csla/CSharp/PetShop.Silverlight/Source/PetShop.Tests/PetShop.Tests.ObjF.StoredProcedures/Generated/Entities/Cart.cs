﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.1817, CSLA Framework: v4.0.0.
//       Changes to this template will not be lost.
//
//     Template: EditableChild.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;

using Csla;
using Csla.Security;
using Csla.Rules;

#endregion

namespace PetShop.Tests.ObjF.StoredProcedures
{
    public partial class Cart
    {
        #region Business Rules

        /// <summary>
        /// All custom rules need to be placed in this method.
        /// </summary>
        /// <returns>Return true to override the generated rules; If false generated rules will be run.</returns>
        protected bool AddBusinessValidationRules()
        {
            // TODO: add validation rules
            //ValidationRules.AddRule(RuleMethod, "");

            return false;
        }

        #endregion

        #region Authorization Rules

        protected static void AddObjectAuthorizationRules()
        {
            //Csla.Rules.BusinessRules.AddRule(typeof(Cart), new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.CreateObject, "SomeRole"));
            //Csla.Rules.BusinessRules.AddRule(typeof(Cart), new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.EditObject, "SomeRole"));
            //Csla.Rules.BusinessRules.AddRule(typeof(Cart), new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.DeleteObject, "SomeRole", "SomeAdminRole"));
        }
        #endregion
    }
}