﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v6.0.3, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Cart.vb'.
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
    Public Partial Class CartListFactory
        Inherits ObjectFactory
    
#Region "Create"
    
        ''' <summary>
        ''' Creates New CartList with default values.
        ''' </summary>
        ''' <Returns>New CartList.</Returns>
        <RunLocal()> _
        Public Function Create() As CartList
            Dim item As CartList = CType(Activator.CreateInstance(GetType(CartList), True), CartList)
    
            Dim cancel As Boolean = False
            OnCreating(cancel)
            If (cancel) Then
                Return item
            End If
    
            CheckRules(item)
            MarkNew(item)
            MarkAsChild(item)
    
            OnCreated()
    
            Return item
        End Function
    
#End Region
    
#Region "Fetch
    
        ''' <summary>
        ''' Fetch CartList.
        ''' </summary>
        ''' <param name="criteria">The criteria.</param>
        ''' <Returns></Returns>
        Public Function Fetch(ByVal criteria As CartCriteria) As CartList
            Dim item As CartList = CType(Activator.CreateInstance(GetType(CartList), True), CartList)
    
            Dim cancel As Boolean = False
            OnFetching(criteria, cancel)
            If (cancel) Then
                Return item
            End If
    
            ' Fetch Child objects.
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand("[dbo].[CSLA_Cart_Select]", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                    
                    Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                        If reader.Read() Then
                            Do
                                item.Add(new CartFactory().Map(reader))
                            Loop While reader.Read()
                        End If
                    End Using
                End Using
            End Using
    
            MarkOld(item)
            MarkAsChild(item)
    
            OnFetched()
    
            Return item
        End Function
    
#End Region
    
#Region "DataPortal partial methods"
    
        ''' <summary>
        ''' Codesmith generated stub method that is called when creating the child <see cref="Cart"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        Partial Private Sub OnCreating(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called after the child <see cref="Cart"/> object has been created. 
        ''' </summary>
        Partial Private Sub OnCreated()
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called when fetching the child <see cref="Cart"/> object. 
        ''' </summary>
        ''' <param name="criteria"><see cref="CartCriteria"/> object containg the criteria of the object to fetch.</param>
        ''' <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        Partial Private Sub OnFetching(ByVal criteria As CartCriteria, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called after the child <see cref="Cart"/> object has been fetched. 
        ''' </summary>
        Partial Private Sub OnFetched()
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called when mapping the child <see cref="Cart"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        Partial Private Sub OnMapping(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called when mapping the child <see cref="Cart"/> object. 
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        Partial Private Sub OnMapping(ByVal reader As SafeDataReader, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called after the child <see cref="Cart"/> object has been mapped. 
        ''' </summary>
        Partial Private Sub OnMapped()
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called when updating the <see cref="Cart"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        Partial Private Sub OnUpdating(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called after the <see cref="Cart"/> object has been updated. 
        ''' </summary>
        Partial Private Sub OnUpdated()
        End Sub
        Partial Private Sub OnAddNewCore(ByRef item As Cart, ByRef cancel As Boolean)
        End Sub
    
#End Region
    End Class
End Namespace