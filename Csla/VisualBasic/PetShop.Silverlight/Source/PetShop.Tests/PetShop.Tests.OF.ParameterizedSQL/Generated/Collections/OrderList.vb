﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.0, CSLA Framework: v4.0.0.
'       Changes to this template will not be lost.
'
'     Template: EditableRootList.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Collections.Generic

Imports Csla

Namespace PetShop.Tests.OF.ParameterizedSQL
    Public Partial Class OrderList
#Region "Authorization Rules"
    
        Private Sub AddAuthorizationRules()
            'Csla.Rules.BusinessRules.AddRule(GetType(OrderList), New Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.CreateObject, "SomeRole"))
            'Csla.Rules.BusinessRules.AddRule(GetType(OrderList), New Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.EditObject, "SomeRole"))
            'Csla.Rules.BusinessRules.AddRule(GetType(OrderList), New Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.DeleteObject, "SomeRole", "SomeAdminRole"))
        End Sub
    
#End Region
    End Class
End Namespace