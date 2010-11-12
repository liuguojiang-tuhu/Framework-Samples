﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.3, CSLA Templates: v3.0.1.1934, CSLA Framework: v3.8.4.
'     Changes to Me file will be lost after each regeneration.
'     To extend the functionality of Me class, please modify the partial class 'Inventory.vb.
'
'     Template: EditableRoot.DataAccess.ParameterizedSQL.cst
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
Imports Csla.Validation

Namespace PetShop.Business
    Public Partial Class Inventory
        <RunLocal()> _
        Protected Shadows Sub DataPortal_Create()
            Dim cancel As Boolean = False
            OnCreating(cancel)
            If (cancel) Then
                Return
            End If
    
            ValidationRules.CheckRules()
    
            OnCreated()
        End Sub
    
        Private Shadows Sub DataPortal_Fetch(ByVal criteria As InventoryCriteria)
            Dim cancel As Boolean = False
            OnFetching(criteria, cancel)
            If (cancel) Then
                Return
            End If
    
            Dim commandText As String = String.Format("SELECT [ItemId], [Qty] FROM [dbo].[Inventory] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                    Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                        If reader.Read() Then
                            Map(reader)
                        Else
                            Throw New Exception(String.Format("The record was not found in 'Inventory' using the following criteria: {0}.", criteria))
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
    
            Const commandText As String = "INSERT INTO [dbo].[Inventory] ([ItemId], [Qty]) VALUES (@p_ItemId, @p_Qty)"
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddWithValue("@p_ItemId", Me.ItemId)
				command.Parameters.AddWithValue("@p_Qty", Me.Qty)
    
                    'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    Dim result As Integer = command.ExecuteNonQuery()
                    If (result = 0) Then
                        throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                    End If
                End Using
    
                LoadProperty(_originalItemIdProperty, Me.ItemId)
    
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
    
            If Not OriginalItemId = ItemId Then
                ' Insert new child.
                Dim item As New Inventory()
                item.ItemId = ItemId
			item.Qty = Qty
                item = item.Save()
    
                ' Mark child lists as dirty. This code may need to be updated to one-to-one relationships.
    
                ' Create a new connection.
                Using connection As New SqlConnection(ADOHelper.ConnectionString)
                    connection.Open()
                    FieldManager.UpdateChildren(Me, connection)
                End Using
    
                ' Delete the old.
                Dim criteria As New InventoryCriteria()
                criteria.ItemId = OriginalItemId
                DataPortal_Delete(criteria)
    
                ' Mark the original as the new one.
                OriginalItemId = ItemId
                OnUpdated()
    
                Return
            End If
    
            Const commandText As String = "UPDATE [dbo].[Inventory]  SET [ItemId] = @p_ItemId, [Qty] = @p_Qty WHERE [ItemId] = @p_OriginalItemId; SELECT [ItemId] FROM [dbo].[Inventory] WHERE [ItemId] = @p_OriginalItemId"
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddWithValue("@p_OriginalItemId", Me.OriginalItemId)
				command.Parameters.AddWithValue("@p_ItemId", Me.ItemId)
				command.Parameters.AddWithValue("@p_Qty", Me.Qty)
    
                'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                Dim result As Integer = command.ExecuteNonQuery()
                If (result = 0) Then
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                End If
                End Using
                LoadProperty(_originalItemIdProperty, Me.ItemId)
    
            End Using
    
            OnUpdated()
        End Sub
    
        Protected Overrides Sub DataPortal_DeleteSelf()
            Dim cancel As Boolean = False
            OnSelfDeleting(cancel)
            If (cancel) Then
                Return
            End If
        
            DataPortal_Delete(New InventoryCriteria (ItemId))
        
            OnSelfDeleted()
        End Sub
    
        <Transactional(TransactionalTypes.TransactionScope)> _
        Protected Shadows Sub DataPortal_Delete(ByVal criteria As InventoryCriteria)
            Dim cancel As Boolean = False
            OnDeleting(criteria, cancel)
            If (cancel) Then
                Return
            End If
    
            Dim commandText As String = String.Format("DELETE FROM [dbo].[Inventory] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
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
    
        Private Sub Map(ByVal reader As SafeDataReader)
            Dim cancel As Boolean = False
            OnMapping(reader, cancel)
            If (cancel) Then
                Return
            End If
    
            Using(BypassPropertyChecks)
                LoadProperty(_itemIdProperty, reader.Item("ItemId"))
                LoadProperty(_originalItemIdProperty, reader.Item("ItemId"))
                LoadProperty(_qtyProperty, reader.Item("Qty"))
            End Using
    
            OnMapped()
    
            MarkOld()
        End Sub
    End Class
End Namespace
