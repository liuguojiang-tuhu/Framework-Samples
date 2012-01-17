﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v6.0.2, CSLA Templates: v3.0.3.2430, CSLA Framework: v4.0.0.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'CategoryList.vb.
'
'     Template: EditableRootList.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
#If SILVERLIGHT Then
Imports Csla.Serialization
#Else
Imports Csla.Data
#End If

Namespace PetShop.Business
    <Serializable()> _
    Public Partial Class CategoryList 
        Inherits BusinessListBase(Of CategoryList, Category)
    
#Region "Contructor(s)"
        
    #If Not SILVERLIGHT Then
        Private Sub New()
            AllowNew = true
        End Sub
    #Else
        public Sub New()
            AllowNew = true
        End Sub
    #End If
    
#End Region
    
#If Not SILVERLIGHT Then
#Region "Method Overrides"
    
        Protected Overrides Function AddNewCore() As Category
            Dim item As Category = PetShop.Business.Category.NewCategory()

            Dim cancel As Boolean = False
            OnAddNewCore(item, cancel)
            If Not (cancel) Then
                ' Check to see if someone set the item to null in the OnAddNewCore.
                If(item Is Nothing) Then
                    item = PetShop.Business.Category.NewCategory()
                End If
                Add(item)
            End If

            Return item
        End Function
    
#End Region
    
#Region "Synchronous Factory Methods"
    
        Public Shared Function NewList() As CategoryList
            Return DataPortal.Create(Of CategoryList)()
        End Function
    
        Public Shared Function GetByCategoryId(ByVal categoryId As System.String) As CategoryList 
            Dim criteria As New CategoryCriteria()
            criteria.CategoryId = categoryId
    
            Return DataPortal.Fetch(Of CategoryList)(criteria)
        End Function
    
        Public Shared Function GetAll() As CategoryList
            Return DataPortal.Fetch(Of CategoryList)(New CategoryCriteria())
        End Function
    
#End Region
#Else

#Region "Method Overrides"
    
        Protected Overrides Sub AddNewCore() 
            PetShop.Business.Category.NewCategoryAsync(Sub(o, e)
                    Dim item As Category = e.Object
        
                    Dim cancel As Boolean = False
                    OnAddNewCore(item, cancel)
                    If Not (cancel) Then
                        ' Check to see if someone set the item to null in the OnAddNewCore.
                        If(item Is Nothing) Then
                            Return
                        End If
                        Add(item)
                    End If
                End Sub)
        End Sub
    
#End Region

#Region "Asynchronous Factory Methods"
            
        Public Shared Sub NewListAsync(ByVal handler As EventHandler(Of DataPortalResult(Of CategoryList)))
            Dim dp As New DataPortal(Of CategoryList)()
            AddHandler dp.CreateCompleted, handler
            dp.BeginCreate()
        End Sub
    
        Public Shared Sub GetByCategoryIdAsync(ByVal categoryId As System.String, ByVal handler As EventHandler(Of DataPortalResult(Of CategoryList)))
            Dim dp As New DataPortal(Of CategoryList)()
            AddHandler dp.FetchCompleted, handler
    
            Dim criteria As New CategoryCriteria()
            criteria.CategoryId = categoryId
    
            dp.BeginFetch(criteria)
        End Sub
    
        Public Shared Sub GetAllAsync(ByVal handler As EventHandler(Of DataPortalResult(Of CategoryList)))
            Dim dp As New DataPortal(Of CategoryList)()
            AddHandler dp.FetchCompleted, handler
            dp.BeginFetch(New CategoryCriteria())
        End Sub
    
#End Region
#End If
#Region "DataPortal partial methods"
    
#If Not SILVERLIGHT Then
        Partial Private Sub OnCreating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnCreated()
        End Sub
        Partial Private Sub OnFetching(ByVal criteria As CategoryCriteria, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnFetched()
        End Sub
        Partial Private Sub OnMapping(ByVal reader As SafeDataReader, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnMapped()
        End Sub
        Partial Private Sub OnUpdating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnUpdated()
        End Sub
#End If
        Partial Private Sub OnAddNewCore(ByVal item As Category, ByRef cancel As Boolean)
        End Sub
    
#End Region
#Region "Exists Command"
#If Not SILVERLIGHT Then

        Public Shared Function Exists(ByVal criteria As CategoryCriteria) As Boolean
            Return PetShop.Business.Category.Exists(criteria)
        End Function

#Else

        Public Shared Sub Exists(ByVal criteria As CategoryCriteria, ByVal handler As EventHandler(Of DataPortalResult(Of ExistsCommand)))
            PetShop.Business.Category.Exists(criteria, handler)
        End Sub

#End If
#End Region
    End Class
End Namespace