﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.3, CSLA Templates: v3.0.1.1934, CSLA Framework: v3.8.4.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'OrderStatus.vb.
'
'     Template: EditableChild.DataAccess.StoredProcedures.cst
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

Namespace PetShop.Tests.StoredProcedures
    Public Partial Class OrderStatus
        <RunLocal()> _
        Protected Overrides Sub Child_Create()
            Dim cancel As Boolean = False
            OnChildCreating(cancel)
            If (cancel) Then
                Return
            End If
    
            ValidationRules.CheckRules()
    
            OnChildCreated()
        End Sub
        
        Private Sub Child_Fetch(ByVal criteria As OrderStatusCriteria)
            Dim cancel As Boolean = False
            OnChildFetching(criteria, cancel)
            If (cancel) Then
                Return
            End If
    
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand("[dbo].[CSLA_OrderStatus_Select]", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                    
                    Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                        If reader.Read() Then
                            Map(reader)
                        Else
                            Throw New Exception(String.Format("The record was not found in 'OrderStatus' using the following criteria: {0}.", criteria))
                        End If
                    End Using
                End Using
            End Using
    
            OnChildFetched()
        End Sub
    
#Region "Child_Insert"
    
        Private Sub Child_Insert(ByVal connection as SqlConnection)
            Dim cancel As Boolean = False
            OnChildInserting(connection, cancel)
            If (cancel) Then
                Return
            End If
    
            If Not (connection.State = ConnectionState.Open) Then connection.Open()
            Using command As New SqlCommand("[dbo].[CSLA_OrderStatus_Insert]", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@p_OrderId", Me.OrderId)
				command.Parameters.AddWithValue("@p_LineNum", Me.LineNum)
				command.Parameters.AddWithValue("@p_Timestamp", Me.Timestamp)
				command.Parameters.AddWithValue("@p_Status", Me.Status)
    
                command.ExecuteNonQuery()
    
    
                ' Update the original non-identity primary key value.
                _originalOrderId = Me.OrderId
    
                ' Update the original non-identity primary key value.
                _originalLineNum = Me.LineNum
    
            End Using
    
            FieldManager.UpdateChildren(Me, connection)
    
            OnChildInserted()
        End Sub
    
        Private Sub Child_Insert(ByVal order As Order, ByVal connection As SqlConnection)
            Dim cancel As Boolean = False
            OnChildInserting(connection, cancel)
            If (cancel) Then
                Return
            End If
    
            If Not (connection.State = ConnectionState.Open) Then connection.Open()
            Using command As New SqlCommand("[dbo].[CSLA_OrderStatus_Insert]", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@p_OrderId", If(Not(order Is Nothing), order.OrderId, Me.OrderId))
				command.Parameters.AddWithValue("@p_LineNum", Me.LineNum)
				command.Parameters.AddWithValue("@p_Timestamp", Me.Timestamp)
				command.Parameters.AddWithValue("@p_Status", Me.Status)
    
                command.ExecuteNonQuery()
    
    
                ' Update the original non-identity primary key value.
                _originalOrderId = Me.OrderId
    
                ' Update the original non-identity primary key value.
                _originalLineNum = Me.LineNum
    
            End Using
    
            ' A child relationship exists on this Business Object but its type is not a child type (E.G. EditableChild). 
            ' TODO: Please override OnChildInserted() and insert this child manually.
            'FieldManager.UpdateChildren(Me, connection)
    
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
            Using command As New SqlCommand("[dbo].[CSLA_OrderStatus_Update]", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@p_OriginalOrderId", Me.OriginalOrderId)
				command.Parameters.AddWithValue("@p_OrderId", Me.OrderId)
				command.Parameters.AddWithValue("@p_OriginalLineNum", Me.OriginalLineNum)
				command.Parameters.AddWithValue("@p_LineNum", Me.LineNum)
				command.Parameters.AddWithValue("@p_Timestamp", Me.Timestamp)
				command.Parameters.AddWithValue("@p_Status", Me.Status)
    
                'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                Dim result As Integer = command.ExecuteNonQuery()
                If (result = 0) Then
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                End If
    
                ' Update non-identity primary key value.
                _orderId = DirectCast(command.Parameters("@p_OrderId").Value, System.Int32)
                ' Update non-identity primary key value.
                _lineNum = DirectCast(command.Parameters("@p_LineNum").Value, System.Int32)
                ' Update non-identity primary key value.
                _originalOrderId = Me.OrderId
                ' Update non-identity primary key value.
                _originalLineNum = Me.LineNum
            End Using
            FieldManager.UpdateChildren(Me, connection)
    
            OnChildUpdated()
        End Sub
    
        Private Sub Child_Update(ByVal order As Order, ByVal connection As SqlConnection)
            Dim cancel As Boolean = False
            OnChildUpdating(connection, cancel)
            If (cancel) Then
                Return
            End If
    
            If Not connection.State = ConnectionState.Open Then connection.Open()
            Using command As New SqlCommand("[dbo].[CSLA_OrderStatus_Update]", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@p_OriginalOrderId", If(Not(order Is Nothing), order.OrderId, Me.OriginalOrderId))
				command.Parameters.AddWithValue("@p_OrderId", If(Not(order Is Nothing), order.OrderId, Me.OrderId))
				command.Parameters.AddWithValue("@p_OriginalLineNum", Me.OriginalLineNum)
				command.Parameters.AddWithValue("@p_LineNum", Me.LineNum)
				command.Parameters.AddWithValue("@p_Timestamp", Me.Timestamp)
				command.Parameters.AddWithValue("@p_Status", Me.Status)
    
                'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                Dim result As Integer = command.ExecuteNonQuery()
                If (result = 0) Then
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                End If
    
                ' Update non-identity primary key value.
                _orderId = DirectCast(command.Parameters("@p_OrderId").Value, System.Int32)
                ' Update non-identity primary key value.
                _lineNum = DirectCast(command.Parameters("@p_LineNum").Value, System.Int32)
    
                'Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
                If(Not IsNothing(order) AndAlso Not order.OrderId = Me.OrderId) Then
                        _orderId = order.OrderId
                End If
                ' Update non-identity primary key value.
                _originalOrderId = Me.OrderId
                ' Update non-identity primary key value.
                _originalLineNum = Me.LineNum
            End Using
            ' A child relationship exists on this Business Object but its type is not a child type (E.G. EditableChild). 
            ' TODO: Please override OnChildUpdated() and update this child manually.
            'FieldManager.UpdateChildren(Me, connection)
    
            OnChildUpdated()
        End Sub
    
    
#End Region
    
    
        Private Sub Child_DeleteSelf(ByVal connection as SqlConnection)
            Dim cancel As Boolean = False
            OnChildSelfDeleting(connection, cancel)
            If (cancel) Then
                Return
            End If
        
            DataPortal_Delete(New OrderStatusCriteria (_orderId, _lineNum), connection)
        
            OnChildSelfDeleted()
        End Sub
        
        Protected Shadows Sub DataPortal_Delete(ByVal criteria As OrderStatusCriteria, ByVal connection as SqlConnection)
            Dim cancel As Boolean = False
            OnDeleting(criteria, connection, cancel)
            If (cancel) Then
                Return
            End If
    
        Using command As New SqlCommand("[dbo].[CSLA_OrderStatus_Delete]", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
    
            'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
            Dim result As Integer = command.ExecuteNonQuery()
            If result = 0 Then
                Throw New DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
            End If
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
                _orderId = reader.GetInt32("OrderId")
                _originalOrderId = reader.GetInt32("OrderId")
                _lineNum = reader.GetInt32("LineNum")
                _originalLineNum = reader.GetInt32("LineNum")
                _timestamp = reader.GetDateTime("Timestamp")
                _status = reader.GetString("Status")
            End Using
    
            OnMapped()
    
            MarkAsChild()
            MarkOld()
        End Sub
    End Class
End Namespace
