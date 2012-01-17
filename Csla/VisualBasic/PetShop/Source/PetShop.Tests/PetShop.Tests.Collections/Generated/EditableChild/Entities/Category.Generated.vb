﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v6.0.2, CSLA Templates: v3.0.3.2430, CSLA Framework: v4.0.0.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Category.vb.
'
'     Template: EditableChild.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Rules
Imports Csla.Data
Imports System.Data.SqlClient

Namespace PetShop.Tests.Collections.EditableChild
    <Serializable()> _
    Public Partial Class Category
        Inherits BusinessBase(Of Category)
    
#Region "Contructor(s)"
    
        Private Sub New()
            ' require use of factory method.
            MarkAsChild()
        End Sub
    
        Friend Sub New(ByVal categoryId As System.String)
            Using(BypassPropertyChecks)
            LoadProperty(_categoryIdProperty, categoryId)
            End Using
    
            MarkAsChild()
        End Sub
    
        Friend Sub New(Byval reader As SafeDataReader)
            Map(reader)
    
            MarkAsChild()
        End Sub
#End Region    
#Region "Business Rules"
    
        Protected Overrides Sub AddBusinessRules()
            ' Call the base class, if this call isn't made than any declared System.ComponentModel.DataAnnotations rules will not work.
            MyBase.AddBusinessRules()

            If AddBusinessValidationRules() Then Exit Sub
    
            BusinessRules.AddRule(New Csla.Rules.CommonRules.Required(_categoryIdProperty))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_categoryIdProperty, 10))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_nameProperty, 80))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_descriptionProperty, 255))
        End Sub
    
#End Region
#Region "Properties"
    
        Private Shared ReadOnly _categoryIdProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Category) p.CategoryId, String.Empty)
        
		<System.ComponentModel.DataObjectField(true, false)> _
        Public Property CategoryId() As System.String
            Get 
                Return GetProperty(_categoryIdProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_categoryIdProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _originalCategoryIdProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Category) p.OriginalCategoryId, String.Empty)
        ''' <summary>
        ''' Holds the original value for CategoryId. This is used for non identity primary keys.
        ''' </summary>
        Friend Property OriginalCategoryId() As System.String
            Get 
                Return GetProperty(_originalCategoryIdProperty) 
            End Get
            Set (value As System.String)
                SetProperty(_originalCategoryIdProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _nameProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Category) p.Name, String.Empty, vbNullString)
        
        Public Property Name() As System.String
            Get 
                Return GetProperty(_nameProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_nameProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _descriptionProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Category) p.Description, String.Empty, vbNullString)
        
        Public Property Description() As System.String
            Get 
                Return GetProperty(_descriptionProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_descriptionProperty, value)
            End Set
        End Property

    
    
    
#End Region
    
#Region "Synchronous Factory Methods"

        Friend Shared Function NewCategory() As Category 
            Return DataPortal.Create(Of Category)()
        End Function
    
        Friend Shared Function GetByCategoryId(ByVal categoryId As System.String) As Category
            Dim criteria As New CategoryCriteria()
            criteria.CategoryId = categoryId
    
            Return DataPortal.FetchChild(Of Category)(criteria)
        End Function
    
#End Region
    
#Region "ChildPortal partial methods"
    
        Partial Private Sub OnChildCreating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildCreated()
        End Sub
        Partial Private Sub OnChildFetching(ByVal criteria As CategoryCriteria, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildFetched()
        End Sub
        Partial Private Sub OnMapping(ByVal reader As SafeDataReader, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnMapped()
        End Sub
        Partial Private Sub OnChildInserting(ByVal connection As SqlConnection, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildInserted()
        End Sub
        Partial Private Sub OnChildUpdating(ByVal connection As SqlConnection, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildUpdated()
        End Sub
        Partial Private Sub OnChildSelfDeleting(ByVal connection As SqlConnection, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildSelfDeleted()
        End Sub
        Partial Private Sub OnDeleting(ByVal criteria As CategoryCriteria, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnDeleting(ByVal criteria As CategoryCriteria, ByVal connection As SqlConnection, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnDeleted()
        End Sub
        Private Partial Sub OnChildLoading(ByVal childProperty As Csla.Core.IPropertyInfo, ByRef cancel As Boolean)
        End Sub
    
#End Region
#Region "Exists Command"

        Public Shared Function Exists(ByVal criteria As CategoryCriteria) As Boolean
            Return PetShop.Tests.Collections.EditableChild.ExistsCommand.Execute(criteria)
        End Function


#End Region
    End Class
End Namespace
