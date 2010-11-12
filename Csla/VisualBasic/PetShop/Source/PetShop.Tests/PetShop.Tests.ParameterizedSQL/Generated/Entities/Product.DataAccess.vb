﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.3, CSLA Templates: v3.0.1.1934, CSLA Framework: v3.8.4.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Product.vb.
'
'     Template: SwitchableObject.DataAccess.ParameterizedSQL.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq

Imports Csla
Imports Csla.Data

Namespace PetShop.Tests.ParameterizedSQL
    Public Partial Class Product
    
#Region "Root Data Access"
    
        <RunLocal()> _
        Protected Overrides Sub DataPortal_Create()
            Dim cancel As Boolean = False
            OnCreating(cancel)
            If (cancel) Then
                Return
            End If
    
            CategoryId = "BN"
            ValidationRules.CheckRules()
    
            OnCreated()
        End Sub
    
        Private Shadows Sub DataPortal_Fetch(ByVal criteria As ProductCriteria )
            Dim cancel As Boolean = False
            OnFetching(criteria, cancel)
            If (cancel) Then
                Return
            End If
    
            Dim commandText As String = String.Format("SELECT [ProductId], [CategoryId], [Name], [Descn], [Image] FROM [dbo].[Product] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                    Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                        If reader.Read() Then
                            Map(reader)
                        Else
                            Throw New Exception(String.Format("The record was not found in 'Product' using the following criteria: {0}.", criteria))
                        End If
                    End Using
                End Using
            End Using
    
            OnFetched()
        End Sub
    
        <Transactional(TransactionalTypes.TransactionScope)> _
        Protected Overrides Sub DataPortal_Insert()
            Dim cancel As Boolean = False
            OnInserting(cancel)
            If (cancel) Then
                Return
            End If
    
            Const commandText As String = "INSERT INTO [dbo].[Product] ([ProductId], [CategoryId], [Name], [Descn], [Image]) VALUES (@p_ProductId, @p_CategoryId, @p_Name, @p_Descn, @p_Image)"
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddWithValue("@p_ProductId", Me.ProductId)
				command.Parameters.AddWithValue("@p_CategoryId", Me.CategoryId)
				command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(Me.Name))
				command.Parameters.AddWithValue("@p_Descn", ADOHelper.NullCheck(Me.Description))
				command.Parameters.AddWithValue("@p_Image", ADOHelper.NullCheck(Me.Image))
    
                    'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    Dim result As Integer = command.ExecuteNonQuery()
                    If (result = 0) Then
                        throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                    End If
                End Using
    
                _originalProductId = Me.ProductId
    
    
                FieldManager.UpdateChildren(Me, connection)
            End Using
    
            OnInserted()
        End Sub
    
        <Transactional(TransactionalTypes.TransactionScope)> _
        Protected Overrides Sub DataPortal_Update()
            Dim cancel As Boolean = False
            OnUpdating(cancel)
            If (cancel) Then
                Return
            End If
    
            If Not OriginalProductId = ProductId Then
                ' Insert new child.
                Dim item As New Product()
                item.ProductId = ProductId
			item.CategoryId = CategoryId
			item.Name = Name
			item.Description = Description
			item.Image = Image
                item = item.Save()
    
                ' Mark child lists as dirty. This code may need to be updated to one-to-one relationships.
                For Each itemToUpdate As Item In Items
    		itemToUpdate.ProductId = ProductId
                Next
    
                ' Create a new connection.
                Using connection As New SqlConnection(ADOHelper.ConnectionString)
                    connection.Open()
                    FieldManager.UpdateChildren(Me, connection)
                End Using
    
                ' Delete the old.
                Dim criteria As New ProductCriteria()
                criteria.ProductId = OriginalProductId
                DataPortal_Delete(criteria)
    
                ' Mark the original as the new one.
                OriginalProductId = ProductId
                OnUpdated()
    
                Return
            End If
    
            Const commandText As String = "UPDATE [dbo].[Product]  SET [ProductId] = @p_ProductId, [CategoryId] = @p_CategoryId, [Name] = @p_Name, [Descn] = @p_Descn, [Image] = @p_Image WHERE [ProductId] = @p_OriginalProductId; SELECT [ProductId] FROM [dbo].[Product] WHERE [ProductId] = @p_OriginalProductId"
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddWithValue("@p_OriginalProductId", Me.OriginalProductId)
				command.Parameters.AddWithValue("@p_ProductId", Me.ProductId)
				command.Parameters.AddWithValue("@p_CategoryId", Me.CategoryId)
				command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(Me.Name))
				command.Parameters.AddWithValue("@p_Descn", ADOHelper.NullCheck(Me.Description))
				command.Parameters.AddWithValue("@p_Image", ADOHelper.NullCheck(Me.Image))
    
                'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                Dim result As Integer = command.ExecuteNonQuery()
                If (result = 0) Then
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                End If
                End Using
                _originalProductId = Me.ProductId
    
    
                FieldManager.UpdateChildren(Me, connection)
            End Using
    
            OnUpdated()
        End Sub
    
        Protected Overrides Sub DataPortal_DeleteSelf()
            Dim cancel As Boolean = False
            OnSelfDeleting(cancel)
            If (cancel) Then
                Return
            End If
        
            DataPortal_Delete(New ProductCriteria (_productId))
        
            OnSelfDeleted()
        End Sub
    
        <Transactional(TransactionalTypes.TransactionScope)> _
        Protected Shadows Sub DataPortal_Delete(ByVal criteria As ProductCriteria)
            Dim cancel As Boolean = False
            OnDeleting(criteria, cancel)
            If (cancel) Then
                Return
            End If
    
            Dim commandText As String = String.Format("DELETE FROM [dbo].[Product] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
    
                    'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    Dim result As Integer = command.ExecuteNonQuery()
                    If (result = 0) Then
                        Throw New DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                    End If
                End Using
            End Using
    
            OnDeleted()
        End Sub
    
        '<Transactional(TransactionalTypes.TransactionScope)> _
        Protected Shadows Sub DataPortal_Delete(ByVal criteria As ProductCriteria, ByVal connection As SqlConnection)
            Dim cancel As Boolean = False
            OnDeleting(criteria, cancel)
            If (cancel) Then
                Return
            End If
    
            Dim commandText As String = String.Format("DELETE FROM [dbo].[Product] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
    
                    'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    Dim result As Integer = command.ExecuteNonQuery()
                    If (result = 0) Then
                        Throw New DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                    End If
                End Using
    
            OnDeleted()
        End Sub
    
#End Region
    
#Region "Child Data Access"
    
        <RunLocal()> _
        Protected Overrides Sub Child_Create()
            Dim cancel As Boolean = False
            OnChildCreating(cancel)
            If (cancel) Then
                Return
            End If
    
            CategoryId = "BN"
            ValidationRules.CheckRules()
    
            OnChildCreated()
        End Sub
    
        Private Sub Child_Fetch(ByVal criteria As ProductCriteria)
            Dim cancel As Boolean = False
            OnChildFetching(criteria, cancel)
            If (cancel) Then
                Return
            End If
    
            Dim commandText As String = String.Format("SELECT [ProductId], [CategoryId], [Name], [Descn], [Image] FROM [dbo].[Product] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                    Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                        If reader.Read() Then
                            Map(reader)
                        Else
                            Throw New Exception(String.Format("The record was not found in 'Product' using the following criteria: {0}.", criteria))
                        End If
                    End Using
                End Using
            End Using
    
            OnChildFetched()
    
            MarkAsChild()
        End Sub
    
#Region "Child_Insert"
    
        Private Sub Child_Insert(ByVal connection as SqlConnection)
            Dim cancel As Boolean = False
            OnChildInserting(connection, cancel)
            If (cancel) Then
                Return
            End If
    
            If Not (connection.State = ConnectionState.Open) Then connection.Open()
            Const commandText As String = "INSERT INTO [dbo].[Product] ([ProductId], [CategoryId], [Name], [Descn], [Image]) VALUES (@p_ProductId, @p_CategoryId, @p_Name, @p_Descn, @p_Image)"
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@p_ProductId", Me.ProductId)
				command.Parameters.AddWithValue("@p_CategoryId", Me.CategoryId)
				command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(Me.Name))
				command.Parameters.AddWithValue("@p_Descn", ADOHelper.NullCheck(Me.Description))
				command.Parameters.AddWithValue("@p_Image", ADOHelper.NullCheck(Me.Image))
    
                'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                Dim result As Integer = command.ExecuteNonQuery()
                If (result = 0) Then
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                End If
            End Using
    
        ' Update non-identity primary key value.
        _originalProductId = Me.ProductId
    
            FieldManager.UpdateChildren(Me, connection)
    
            OnChildInserted()
        End Sub
    
        Private Sub Child_Insert(ByVal category As Category, ByVal connection As SqlConnection)
            Dim cancel As Boolean = False
            OnChildInserting(connection, cancel)
            If (cancel) Then
                Return
            End If
    
            If Not (connection.State = ConnectionState.Open) Then connection.Open()
            Const commandText As String = "INSERT INTO [dbo].[Product] ([ProductId], [CategoryId], [Name], [Descn], [Image]) VALUES (@p_ProductId, @p_CategoryId, @p_Name, @p_Descn, @p_Image)"
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@p_ProductId", Me.ProductId)
				command.Parameters.AddWithValue("@p_CategoryId", If(Not(category Is Nothing), category.CategoryId, Me.CategoryId))
				command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(Me.Name))
				command.Parameters.AddWithValue("@p_Descn", ADOHelper.NullCheck(Me.Description))
				command.Parameters.AddWithValue("@p_Image", ADOHelper.NullCheck(Me.Image))
    
                'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                Dim result As Integer = command.ExecuteNonQuery()
                If (result = 0) Then
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                End If
            End Using
    
            ' Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
            If(Not IsNothing(category) AndAlso Not category.CategoryId = Me.CategoryId) Then
                _categoryId = category.CategoryId
            End If
    
        ' Update non-identity primary key value.
        _originalProductId = Me.ProductId
    
            ' A child relationship exists on this Business Object but its type is not a child type (E.G. EditableChild). 
            ' TODO: Please override OnChildInserted() and insert this child manually.
            'FieldManager.UpdateChildren(Me, Nothing, connection)
    
            OnChildInserted()
        End Sub
    
    
#End Region
    
#Region "Child_Update"
    
        Private Sub Child_Update(ByVal connection as SqlConnection)
            Dim cancel As Boolean = False
            OnChildUpdating(connection, cancel)
            If (cancel) Then
                Return
            End If
    
            If Not connection.State = ConnectionState.Open Then connection.Open()
            Const commandText As String = "UPDATE [dbo].[Product]  SET [ProductId] = @p_ProductId, [CategoryId] = @p_CategoryId, [Name] = @p_Name, [Descn] = @p_Descn, [Image] = @p_Image WHERE [ProductId] = @p_OriginalProductId; SELECT [ProductId] FROM [dbo].[Product] WHERE [ProductId] = @p_OriginalProductId"
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@p_OriginalProductId", Me.OriginalProductId)
				command.Parameters.AddWithValue("@p_ProductId", Me.ProductId)
				command.Parameters.AddWithValue("@p_CategoryId", Me.CategoryId)
				command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(Me.Name))
				command.Parameters.AddWithValue("@p_Descn", ADOHelper.NullCheck(Me.Description))
				command.Parameters.AddWithValue("@p_Image", ADOHelper.NullCheck(Me.Image))
    
                'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                Dim result As Integer = command.ExecuteNonQuery()
                If (result = 0) Then
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                End If
    
                ' Update non-identity primary key value.
                _originalProductId = Me.ProductId
            End Using
            FieldManager.UpdateChildren(Me, connection)
    
            OnChildUpdated()
        End Sub
    
        Private Sub Child_Update(ByVal category As Category, ByVal connection As SqlConnection)
            Dim cancel As Boolean = False
            OnChildUpdating(connection, cancel)
            If (cancel) Then
                Return
            End If
    
            If Not connection.State = ConnectionState.Open Then connection.Open()
            Const commandText As String = "UPDATE [dbo].[Product]  SET [ProductId] = @p_ProductId, [CategoryId] = @p_CategoryId, [Name] = @p_Name, [Descn] = @p_Descn, [Image] = @p_Image WHERE [ProductId] = @p_OriginalProductId; SELECT [ProductId] FROM [dbo].[Product] WHERE [ProductId] = @p_OriginalProductId"
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@p_OriginalProductId", Me.OriginalProductId)
				command.Parameters.AddWithValue("@p_ProductId", Me.ProductId)
				command.Parameters.AddWithValue("@p_CategoryId", If(Not(category Is Nothing), category.CategoryId, Me.CategoryId))
				command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(Me.Name))
				command.Parameters.AddWithValue("@p_Descn", ADOHelper.NullCheck(Me.Description))
				command.Parameters.AddWithValue("@p_Image", ADOHelper.NullCheck(Me.Image))
    
                'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                Dim result As Integer = command.ExecuteNonQuery()
                If (result = 0) Then
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                End If
    
                ' Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
                If(Not IsNothing(category) AndAlso Not category.CategoryId = Me.CategoryId) Then
                    _categoryId = category.CategoryId
                End If
    
                ' Update non-identity primary key value.
                _originalProductId = Me.ProductId
            End Using
            FieldManager.UpdateChildren(Me, Nothing, connection)
    
            OnChildUpdated()
        End Sub
    
    
#End Region
    
        Private Sub Child_DeleteSelf()
            Dim cancel As Boolean = False
            OnChildSelfDeleting(cancel)
            If (cancel) Then
                Return
            End If
        
            DataPortal_Delete(New ProductCriteria (_productId))
        
            OnChildSelfDeleted()
        End Sub
        
        Private Sub Child_DeleteSelf(ParamArray args As Object())
        Dim connection As SqlConnection = args.OfType(Of SqlConnection)().FirstOrDefault()
        If connection Is Nothing Then
            Throw New ArgumentNullException("args", "Must contain a SqlConnection parameter.")
        End If
        
            Dim cancel As Boolean = False
            OnChildSelfDeleting(cancel)
            If (cancel) Then
                Return
            End If
        
            DataPortal_Delete(New ProductCriteria (_productId), connection)
        
            OnChildSelfDeleted()
        End Sub
    
#End Region
    
        Private Sub Map(ByVal reader As SafeDataReader)
            Dim cancel As Boolean = False
            OnMapping(reader, cancel)
            If (cancel) Then
                Return
            End If
    
            Using(BypassPropertyChecks)
                _productId = reader.GetString("ProductId")
                _originalProductId = reader.GetString("ProductId")
                _categoryId = reader.GetString("CategoryId")
                _name = reader.GetString("Name")
                _description = reader.GetString("Descn")
                _image = reader.GetString("Image")
            End Using
    
            OnMapped()
    
            MarkOld()
        End Sub
    End Class
End Namespace
