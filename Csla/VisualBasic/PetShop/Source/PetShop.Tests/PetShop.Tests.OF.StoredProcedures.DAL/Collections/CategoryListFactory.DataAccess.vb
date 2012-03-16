﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v6.0.3, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Category.vb'.
'
'     Template: ObjectFactoryList.DataAccess.StoredProcedures.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Data
Imports System.Data.SqlClient

Imports Csla
Imports Csla.Data
Imports Csla.Server

Imports PetShop.Tests.OF.StoredProcedures

Namespace PetShop.Tests.OF.StoredProcedures.DAL
    Public Partial Class CategoryListFactory
        Inherits ObjectFactory
    
#Region "Create"
    
        ''' <summary>
        ''' Creates New CategoryList with default values.
        ''' </summary>
        ''' <Returns>New CategoryList.</Returns>
        <RunLocal()> _
        Public Function Create() As CategoryList
            Dim item As CategoryList = CType(Activator.CreateInstance(GetType(CategoryList), True), CategoryList)
    
            Dim cancel As Boolean = False
            OnCreating(cancel)
            If (cancel) Then
                Return item
            End If
    
            CheckRules(item)
            MarkNew(item)
    
            OnCreated()
    
            Return item
        End Function
    
#End Region
    
#Region "Fetch
    
        ''' <summary>
        ''' Fetch CategoryList.
        ''' </summary>
        ''' <param name="criteria">The criteria.</param>
        ''' <Returns></Returns>
        Public Function Fetch(ByVal criteria As CategoryCriteria) As CategoryList
            Dim item As CategoryList = CType(Activator.CreateInstance(GetType(CategoryList), True), CategoryList)
    
            Dim cancel As Boolean = False
            OnFetching(criteria, cancel)
            If (cancel) Then
                Return item
            End If
    
            ' Fetch Child objects.
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand("[dbo].[CSLA_Category_Select]", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                    command.Parameters.AddWithValue("@p_NameHasValue", criteria.NameHasValue)
                command.Parameters.AddWithValue("@p_DescnHasValue", criteria.DescriptionHasValue)
                    Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                        If reader.Read() Then
                            Do
                                item.Add(new CategoryFactory().Map(reader))
                            Loop While reader.Read()
                        End If
                    End Using
                End Using
            End Using
    
            MarkOld(item)
    
            OnFetched()
    
            Return item
        End Function
    
#End Region
    
#Region "DataPortal partial methods"
    
        ''' <summary>
        ''' Codesmith generated stub method that is called when creating the child <see cref="Category"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        Partial Private Sub OnCreating(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called after the child <see cref="Category"/> object has been created. 
        ''' </summary>
        Partial Private Sub OnCreated()
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called when fetching the child <see cref="Category"/> object. 
        ''' </summary>
        ''' <param name="criteria"><see cref="CategoryCriteria"/> object containg the criteria of the object to fetch.</param>
        ''' <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        Partial Private Sub OnFetching(ByVal criteria As CategoryCriteria, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called after the child <see cref="Category"/> object has been fetched. 
        ''' </summary>
        Partial Private Sub OnFetched()
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called when mapping the child <see cref="Category"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        Partial Private Sub OnMapping(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called when mapping the child <see cref="Category"/> object. 
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        Partial Private Sub OnMapping(ByVal reader As SafeDataReader, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called after the child <see cref="Category"/> object has been mapped. 
        ''' </summary>
        Partial Private Sub OnMapped()
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
        Partial Private Sub OnAddNewCore(ByRef item As Category, ByRef cancel As Boolean)
        End Sub
    
#End Region
    End Class
End Namespace