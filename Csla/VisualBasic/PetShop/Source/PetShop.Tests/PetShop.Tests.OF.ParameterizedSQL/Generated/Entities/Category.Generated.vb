﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v6.0.3, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Category.vb.
'
'     Template path: EditableRoot.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Data

Imports Csla.Rules

Namespace PetShop.Tests.OF.ParameterizedSQL
    <Serializable()> _
    <Csla.Server.ObjectFactory(FactoryNames.CategoryFactoryName)> _
    Public Partial Class Category
        Inherits BusinessBase(Of Category)
    
#Region "Contructor(s)"

        public Sub New()
            ' require use of factory method 
        End Sub

#End Region    
#Region "Business Rules"

        ''' <summary>
        ''' Contains the Codesmith generated validation rules.
        ''' </summary>
        Protected Overrides Sub AddBusinessRules()
            ' Call the base class, if this call isn't made than any declared System.ComponentModel.DataAnnotations rules will not work.
            MyBase.AddBusinessRules()

            If AddBusinessValidationRules() Then Exit Sub
    
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.Required(_categoryIdProperty))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.MaxLength(_categoryIdProperty, 10))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.MaxLength(_nameProperty, 80))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.MaxLength(_descriptionProperty, 255))
        End Sub
    
#End Region

#Region "Properties"
    
        Private Shared ReadOnly _categoryIdProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Category) p.CategoryId, "Category Id")
        
        <System.ComponentModel.DataObjectField(true, false)> _
        Public Property CategoryId() As System.String
            Get 
                Return GetProperty(_categoryIdProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_categoryIdProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _originalCategoryIdProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Category) p.OriginalCategoryId, "Original Category Id")
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

        Private Shared ReadOnly _nameProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Category) p.Name, "Name", vbNullString)
        
        Public Property Name() As System.String
            Get 
                Return GetProperty(_nameProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_nameProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _descriptionProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Category) p.Description, "Description", vbNullString)
        
        Public Property Description() As System.String
            Get 
                Return GetProperty(_descriptionProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_descriptionProperty, value)
            End Set
        End Property

    
    
    
        'OneToMany
        Private Shared ReadOnly _productsProperty As PropertyInfo(Of ProductList) = RegisterProperty(Of ProductList)(Function(p As Category) p.Products, Csla.RelationshipTypes.Child)
    Public ReadOnly Property Products() As ProductList
            Get
                Dim cancel As Boolean = False
                OnChildLoading(_productsProperty, cancel)
                
                If Not cancel Then
                    If Not (FieldManager.FieldExists(_productsProperty)) Then
                        Dim criteria As New PetShop.Tests.OF.ParameterizedSQL.ProductCriteria()
                        criteria.CategoryId = CategoryId
    
                        If (Not PetShop.Tests.OF.ParameterizedSQL.ProductList.Exists(criteria)) Then
                            LoadProperty(_productsProperty, PetShop.Tests.OF.ParameterizedSQL.ProductList.NewList())
                        Else
                            LoadProperty(_productsProperty, PetShop.Tests.OF.ParameterizedSQL.ProductList.GetByCategoryId(CategoryId))
                        End If
                    End If
                End If

                Return GetProperty(_productsProperty) 
            End Get
        End Property

#End Region
    
#Region "Synchronous Factory Methods"

        ''' <summary>
        ''' Creates a new object of type <see cref="Category"/>. 
        ''' </summary>
        ''' <returns>Returns a newly instantiated collection of type <see cref="Category"/>.</returns>    
        Public Shared Function NewCategory() As Category
            Return DataPortal.Create(Of Category)()
        End Function
        ''' <summary>
        ''' Returns a <see cref="Category"/> object of the specified criteria. 
        ''' </summary>
        ''' <param name="categoryId">No additional detail available.</param>
        ''' <returns>A <see cref="Category"/> object of the specified criteria.</returns>
        Public Shared Function GetByCategoryId(ByVal categoryId As System.String) As Category
            Dim criteria As New CategoryCriteria()
                        criteria.CategoryId = categoryId
            
            Return DataPortal.Fetch(Of Category)(criteria)
        End Function
    
        Public Shared Sub DeleteCategory(ByVal categoryId As System.String)
            DataPortal.Delete(Of Category)(New CategoryCriteria(categoryId))
        End Sub

#End Region

#Region "Asynchronous Factory Methods"

        Public Shared Sub NewCategoryAsync(ByVal handler As EventHandler(Of DataPortalResult(Of Category)))
            Dim dp As New DataPortal(Of Category)()
            AddHandler dp.CreateCompleted, handler
            dp.BeginCreate()
        End Sub
    
        Public Shared Sub GetByCategoryIdAsync(ByVal categoryId As System.String, ByVal handler As EventHandler(Of DataPortalResult(Of Category)))
            Dim dp As New DataPortal(Of Category)()
            AddHandler dp.FetchCompleted, handler
        
            Dim criteria As New CategoryCriteria()
            criteria.CategoryId = categoryId
    
            dp.BeginFetch(criteria)
        End Sub
    
        Public Shared Sub DeleteCategoryDeleteCategoryAsync(ByVal categoryId As System.String, ByVal handler As EventHandler(Of DataPortalResult(Of Category)))
            Dim dp As New DataPortal(Of Category)()
            AddHandler dp.DeleteCompleted, handler
            dp.BeginDelete(New CategoryCriteria (categoryId))
        End Sub
    

#End Region

#Region "Overridden properties"
    
            ''' <summary>
            ''' Returns true if the business object or any of its children properties are dirty.
            ''' </summary>
            Public Overloads Overrides ReadOnly Property IsDirty() As Boolean
                Get
                    If MyBase.IsDirty Then
                        Return True
                    End If
    
    
    
    
                    If (FieldManager.FieldExists(_productsProperty) AndAlso Products.IsDirty) Then
                        Return True
                    End If
                    Return False
                End Get
            End Property
    
#End Region
    
#Region "DataPortal partial methods"
    
        ''' <summary>
        ''' Codesmith generated stub method that is called when creating the <see cref="Category"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        Partial Private Sub OnCreating(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called after the <see cref="Category"/> object has been created. 
        ''' </summary>
        Partial Private Sub OnCreated()
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called when fetching the <see cref="Category"/> object. 
        ''' </summary>
        ''' <param name="criteria"><see cref="CategoryCriteria"/> object containg the criteria of the object to fetch.</param>
        ''' <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        Partial Private Sub OnFetching(ByVal criteria As CategoryCriteria, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called after the <see cref="Category"/> object has been fetched. 
        ''' </summary>    
        Partial Private Sub OnFetched()
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called when mapping the <see cref="Category"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        Partial Private Sub OnMapping(ByRef cancel As Boolean)
        End Sub
 
        ''' <summary>
        ''' Codesmith generated stub method that is called when mapping the <see cref="Category"/> object. 
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        Partial Private Sub OnMapping(ByVal reader As SafeDataReader, ByRef cancel As Boolean)
        End Sub
        ''' <summary>
        ''' Codesmith generated stub method that is called after the <see cref="Category"/> object has been mapped. 
        ''' </summary>
        Partial Private Sub OnMapped()
        End Sub
        ''' <summary>
        ''' Codesmith generated stub method that is called when inserting the <see cref="Category"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        Partial Private Sub OnInserting(ByRef cancel As Boolean)
        End Sub
        ''' <summary>
        ''' Codesmith generated stub method that is called after the <see cref="Category"/> object has been inserted. 
        ''' </summary>
        Partial Private Sub OnInserted()
        End Sub
        ''' <summary>
        ''' Codesmith generated stub method that is called when updating the <see cref="Category"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        Partial Private Sub OnUpdating(ByRef cancel As Boolean)
        End Sub
        ''' <summary>
        ''' Codesmith generated stub method that is called after the <see cref="Category"/> object has been updated. 
        ''' </summary>
        Partial Private Sub OnUpdated()
        End Sub
        ''' <summary>
        ''' Codesmith generated stub method that is called when self deleting the <see cref="Category"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        Partial Private Sub OnSelfDeleting(ByRef cancel As Boolean)
        End Sub
        ''' <summary>
        ''' Codesmith generated stub method that is called after the <see cref="Category"/> object has been deleted. 
        ''' </summary>
        Partial Private Sub OnSelfDeleted()
        End Sub
        ''' <summary>
        ''' Codesmith generated stub method that is called when deleting the <see cref="Category"/> object. 
        ''' </summary>
        ''' <param name="criteria"><see cref="CategoryCriteria"/> object containg the criteria of the object to delete.</param>
        ''' <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        Partial Private Sub OnDeleting(ByVal criteria As CategoryCriteria, ByRef cancel As Boolean)
        End Sub
        ''' <summary>
        ''' Codesmith generated stub method that is called after the <see cref="Category"/> object with the specified criteria has been deleted. 
        ''' </summary>
        Partial Private Sub OnDeleted()
        End Sub
        Private Partial Sub OnChildLoading(ByVal childProperty As Global.Csla.Core.IPropertyInfo, ByRef cancel As Boolean)
        End Sub
    
#End Region
#Region "Exists Command"

        ''' <summary>
        ''' Determines if a record exists in the [dbo].[Category] table in the database for the specified criteria. 
        ''' </summary>
        ''' <param name="criteria">The criteria parameter is an <see cref="Category"/> object.</param>
        ''' <returns>A boolean value of true is returned if a record is found.</returns>
        Public Shared Function Exists(ByVal criteria As CategoryCriteria) As Boolean
            Return PetShop.Tests.OF.ParameterizedSQL.ExistsCommand.Execute(criteria)
        End Function

        ''' <summary>
        ''' Determines if a record exists in the [dbo].[Category] table in the database for the specified criteria. 
        ''' </summary>
        Public Shared Sub ExistsAsync(ByVal criteria As CategoryCriteria, ByVal handler As EventHandler(Of DataPortalResult(Of ExistsCommand)))
            PetShop.Tests.OF.ParameterizedSQL.ExistsCommand.ExecuteAsync(criteria, handler)
        End Sub

#End Region
    End Class
End Namespace
