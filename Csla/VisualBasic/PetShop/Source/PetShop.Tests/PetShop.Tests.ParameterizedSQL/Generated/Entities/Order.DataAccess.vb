﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v6.0.3, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Order.vb.
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
    Public Partial Class Order
    
#Region "Root Data Access"
    
        <RunLocal()> _
        Protected Overrides Sub DataPortal_Create()
            Dim cancel As Boolean = False
            OnCreating(cancel)
            If (cancel) Then
                Return
            End If
    

            BusinessRules.CheckRules()
    
            OnCreated()
        End Sub
    
        Private Shadows Sub DataPortal_Fetch(ByVal criteria As OrderCriteria )
            Dim cancel As Boolean = False
            OnFetching(criteria, cancel)
            If (cancel) Then
                Return
            End If
    
            Dim commandText As String = String.Format("SELECT [OrderId], [UserId], [OrderDate], [ShipAddr1], [ShipAddr2], [ShipCity], [ShipState], [ShipZip], [ShipCountry], [BillAddr1], [BillAddr2], [BillCity], [BillState], [BillZip], [BillCountry], [Courier], [TotalPrice], [BillToFirstName], [BillToLastName], [ShipToFirstName], [ShipToLastName], [AuthorizationNumber], [Locale] FROM [dbo].[Orders] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                    Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                        If reader.Read() Then
                            Map(reader)
                        Else
                            Throw New Exception(String.Format("The record was not found In 'dbo.Orders' using the following criteria: {0}.", criteria))
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

            Const commandText As String = "INSERT INTO [dbo].[Orders] ([UserId], [OrderDate], [ShipAddr1], [ShipAddr2], [ShipCity], [ShipState], [ShipZip], [ShipCountry], [BillAddr1], [BillAddr2], [BillCity], [BillState], [BillZip], [BillCountry], [Courier], [TotalPrice], [BillToFirstName], [BillToLastName], [ShipToFirstName], [ShipToLastName], [AuthorizationNumber], [Locale]) VALUES (@p_UserId, @p_OrderDate, @p_ShipAddr1, @p_ShipAddr2, @p_ShipCity, @p_ShipState, @p_ShipZip, @p_ShipCountry, @p_BillAddr1, @p_BillAddr2, @p_BillCity, @p_BillState, @p_BillZip, @p_BillCountry, @p_Courier, @p_TotalPrice, @p_BillToFirstName, @p_BillToLastName, @p_ShipToFirstName, @p_ShipToLastName, @p_AuthorizationNumber, @p_Locale); SELECT [OrderId] FROM [dbo].[Orders] WHERE OrderId = SCOPE_IDENTITY()"
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddWithValue("@p_UserId", Me.UserId)
                command.Parameters.AddWithValue("@p_OrderDate", Me.OrderDate)
                command.Parameters.AddWithValue("@p_ShipAddr1", Me.ShipAddr1)
                command.Parameters.AddWithValue("@p_ShipAddr2", ADOHelper.NullCheck(Me.ShipAddr2))
                command.Parameters.AddWithValue("@p_ShipCity", Me.ShipCity)
                command.Parameters.AddWithValue("@p_ShipState", Me.ShipState)
                command.Parameters.AddWithValue("@p_ShipZip", Me.ShipZip)
                command.Parameters.AddWithValue("@p_ShipCountry", Me.ShipCountry)
                command.Parameters.AddWithValue("@p_BillAddr1", Me.BillAddr1)
                command.Parameters.AddWithValue("@p_BillAddr2", ADOHelper.NullCheck(Me.BillAddr2))
                command.Parameters.AddWithValue("@p_BillCity", Me.BillCity)
                command.Parameters.AddWithValue("@p_BillState", Me.BillState)
                command.Parameters.AddWithValue("@p_BillZip", Me.BillZip)
                command.Parameters.AddWithValue("@p_BillCountry", Me.BillCountry)
                command.Parameters.AddWithValue("@p_Courier", Me.Courier)
                command.Parameters.AddWithValue("@p_TotalPrice", Me.TotalPrice)
                command.Parameters.AddWithValue("@p_BillToFirstName", Me.BillToFirstName)
                command.Parameters.AddWithValue("@p_BillToLastName", Me.BillToLastName)
                command.Parameters.AddWithValue("@p_ShipToFirstName", Me.ShipToFirstName)
                command.Parameters.AddWithValue("@p_ShipToLastName", Me.ShipToLastName)
                command.Parameters.AddWithValue("@p_AuthorizationNumber", Me.AuthorizationNumber)
                command.Parameters.AddWithValue("@p_Locale", Me.Locale)
    
                    Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                        If reader.Read() Then
                            Using(BypassPropertyChecks)
                                LoadProperty(_orderIdProperty, reader.GetInt32("OrderId"))
                End Using
                        End If
                    End Using
                End Using
    
    
    
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
    
            Const commandText As String = "UPDATE [dbo].[Orders] SET [UserId] = @p_UserId, [OrderDate] = @p_OrderDate, [ShipAddr1] = @p_ShipAddr1, [ShipAddr2] = @p_ShipAddr2, [ShipCity] = @p_ShipCity, [ShipState] = @p_ShipState, [ShipZip] = @p_ShipZip, [ShipCountry] = @p_ShipCountry, [BillAddr1] = @p_BillAddr1, [BillAddr2] = @p_BillAddr2, [BillCity] = @p_BillCity, [BillState] = @p_BillState, [BillZip] = @p_BillZip, [BillCountry] = @p_BillCountry, [Courier] = @p_Courier, [TotalPrice] = @p_TotalPrice, [BillToFirstName] = @p_BillToFirstName, [BillToLastName] = @p_BillToLastName, [ShipToFirstName] = @p_ShipToFirstName, [ShipToLastName] = @p_ShipToLastName, [AuthorizationNumber] = @p_AuthorizationNumber, [Locale] = @p_Locale WHERE [OrderId] = @p_OrderId"
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddWithValue("@p_OrderId", Me.OrderId)
                command.Parameters.AddWithValue("@p_UserId", Me.UserId)
                command.Parameters.AddWithValue("@p_OrderDate", Me.OrderDate)
                command.Parameters.AddWithValue("@p_ShipAddr1", Me.ShipAddr1)
                command.Parameters.AddWithValue("@p_ShipAddr2", ADOHelper.NullCheck(Me.ShipAddr2))
                command.Parameters.AddWithValue("@p_ShipCity", Me.ShipCity)
                command.Parameters.AddWithValue("@p_ShipState", Me.ShipState)
                command.Parameters.AddWithValue("@p_ShipZip", Me.ShipZip)
                command.Parameters.AddWithValue("@p_ShipCountry", Me.ShipCountry)
                command.Parameters.AddWithValue("@p_BillAddr1", Me.BillAddr1)
                command.Parameters.AddWithValue("@p_BillAddr2", ADOHelper.NullCheck(Me.BillAddr2))
                command.Parameters.AddWithValue("@p_BillCity", Me.BillCity)
                command.Parameters.AddWithValue("@p_BillState", Me.BillState)
                command.Parameters.AddWithValue("@p_BillZip", Me.BillZip)
                command.Parameters.AddWithValue("@p_BillCountry", Me.BillCountry)
                command.Parameters.AddWithValue("@p_Courier", Me.Courier)
                command.Parameters.AddWithValue("@p_TotalPrice", Me.TotalPrice)
                command.Parameters.AddWithValue("@p_BillToFirstName", Me.BillToFirstName)
                command.Parameters.AddWithValue("@p_BillToLastName", Me.BillToLastName)
                command.Parameters.AddWithValue("@p_ShipToFirstName", Me.ShipToFirstName)
                command.Parameters.AddWithValue("@p_ShipToLastName", Me.ShipToLastName)
                command.Parameters.AddWithValue("@p_AuthorizationNumber", Me.AuthorizationNumber)
                command.Parameters.AddWithValue("@p_Locale", Me.Locale)
    
                    Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                        'RecordsAffected: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                        If reader.RecordsAffected = 0 Then
                            Throw New DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                        End If
    
                        If reader.Read() Then
                            Using (BypassPropertyChecks)
                            End Using
                        End If
                    End Using
                End Using
    
    
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
        
            DataPortal_Delete(New OrderCriteria (OrderId))
        
            OnSelfDeleted()
        End Sub
    
        <Transactional(TransactionalTypes.TransactionScope)> _
        Protected Shadows Sub DataPortal_Delete(ByVal criteria As OrderCriteria)
            Dim cancel As Boolean = False
            OnDeleting(criteria, cancel)
            If (cancel) Then
                Return
            End If
    
            Dim commandText As String = String.Format("DELETE FROM [dbo].[Orders] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
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
        Protected Shadows Sub DataPortal_Delete(ByVal criteria As OrderCriteria, ByVal connection As SqlConnection)
            Dim cancel As Boolean = False
            OnDeleting(criteria, cancel)
            If (cancel) Then
                Return
            End If
    
            Dim commandText As String = String.Format("DELETE FROM [dbo].[Orders] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
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
    

            BusinessRules.CheckRules()
    
            OnChildCreated()
        End Sub
    
        Private Sub Child_Fetch(ByVal criteria As OrderCriteria)
            Dim cancel As Boolean = False
            OnChildFetching(criteria, cancel)
            If (cancel) Then
                Return
            End If
    
            Dim commandText As String = String.Format("SELECT [OrderId], [UserId], [OrderDate], [ShipAddr1], [ShipAddr2], [ShipCity], [ShipState], [ShipZip], [ShipCountry], [BillAddr1], [BillAddr2], [BillCity], [BillState], [BillZip], [BillCountry], [Courier], [TotalPrice], [BillToFirstName], [BillToLastName], [ShipToFirstName], [ShipToLastName], [AuthorizationNumber], [Locale] FROM [dbo].[Orders] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                    Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                        If reader.Read() Then
                            Map(reader)
                        Else
                            Throw New Exception(String.Format("The record was not found In 'dbo.Orders' using the following criteria: {0}.", criteria))
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
            Const commandText As String = "INSERT INTO [dbo].[Orders] ([UserId], [OrderDate], [ShipAddr1], [ShipAddr2], [ShipCity], [ShipState], [ShipZip], [ShipCountry], [BillAddr1], [BillAddr2], [BillCity], [BillState], [BillZip], [BillCountry], [Courier], [TotalPrice], [BillToFirstName], [BillToLastName], [ShipToFirstName], [ShipToLastName], [AuthorizationNumber], [Locale]) VALUES (@p_UserId, @p_OrderDate, @p_ShipAddr1, @p_ShipAddr2, @p_ShipCity, @p_ShipState, @p_ShipZip, @p_ShipCountry, @p_BillAddr1, @p_BillAddr2, @p_BillCity, @p_BillState, @p_BillZip, @p_BillCountry, @p_Courier, @p_TotalPrice, @p_BillToFirstName, @p_BillToLastName, @p_ShipToFirstName, @p_ShipToLastName, @p_AuthorizationNumber, @p_Locale); SELECT [OrderId] FROM [dbo].[Orders] WHERE OrderId = SCOPE_IDENTITY()"
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@p_UserId", Me.UserId)
                command.Parameters.AddWithValue("@p_OrderDate", Me.OrderDate)
                command.Parameters.AddWithValue("@p_ShipAddr1", Me.ShipAddr1)
                command.Parameters.AddWithValue("@p_ShipAddr2", ADOHelper.NullCheck(Me.ShipAddr2))
                command.Parameters.AddWithValue("@p_ShipCity", Me.ShipCity)
                command.Parameters.AddWithValue("@p_ShipState", Me.ShipState)
                command.Parameters.AddWithValue("@p_ShipZip", Me.ShipZip)
                command.Parameters.AddWithValue("@p_ShipCountry", Me.ShipCountry)
                command.Parameters.AddWithValue("@p_BillAddr1", Me.BillAddr1)
                command.Parameters.AddWithValue("@p_BillAddr2", ADOHelper.NullCheck(Me.BillAddr2))
                command.Parameters.AddWithValue("@p_BillCity", Me.BillCity)
                command.Parameters.AddWithValue("@p_BillState", Me.BillState)
                command.Parameters.AddWithValue("@p_BillZip", Me.BillZip)
                command.Parameters.AddWithValue("@p_BillCountry", Me.BillCountry)
                command.Parameters.AddWithValue("@p_Courier", Me.Courier)
                command.Parameters.AddWithValue("@p_TotalPrice", Me.TotalPrice)
                command.Parameters.AddWithValue("@p_BillToFirstName", Me.BillToFirstName)
                command.Parameters.AddWithValue("@p_BillToLastName", Me.BillToLastName)
                command.Parameters.AddWithValue("@p_ShipToFirstName", Me.ShipToFirstName)
                command.Parameters.AddWithValue("@p_ShipToLastName", Me.ShipToLastName)
                command.Parameters.AddWithValue("@p_AuthorizationNumber", Me.AuthorizationNumber)
                command.Parameters.AddWithValue("@p_Locale", Me.Locale)
    
                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    If reader.Read() Then
    
                        ' Update identity or guid primary key value.
                        LoadProperty(_orderIdProperty, reader.GetInt32("OrderId"))
                    End If
                End Using
            End Using
    
            FieldManager.UpdateChildren(Me, connection)
    
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
            Const commandText As String = "UPDATE [dbo].[Orders] SET [UserId] = @p_UserId, [OrderDate] = @p_OrderDate, [ShipAddr1] = @p_ShipAddr1, [ShipAddr2] = @p_ShipAddr2, [ShipCity] = @p_ShipCity, [ShipState] = @p_ShipState, [ShipZip] = @p_ShipZip, [ShipCountry] = @p_ShipCountry, [BillAddr1] = @p_BillAddr1, [BillAddr2] = @p_BillAddr2, [BillCity] = @p_BillCity, [BillState] = @p_BillState, [BillZip] = @p_BillZip, [BillCountry] = @p_BillCountry, [Courier] = @p_Courier, [TotalPrice] = @p_TotalPrice, [BillToFirstName] = @p_BillToFirstName, [BillToLastName] = @p_BillToLastName, [ShipToFirstName] = @p_ShipToFirstName, [ShipToLastName] = @p_ShipToLastName, [AuthorizationNumber] = @p_AuthorizationNumber, [Locale] = @p_Locale WHERE [OrderId] = @p_OrderId"
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@p_OrderId", Me.OrderId)
                command.Parameters.AddWithValue("@p_UserId", Me.UserId)
                command.Parameters.AddWithValue("@p_OrderDate", Me.OrderDate)
                command.Parameters.AddWithValue("@p_ShipAddr1", Me.ShipAddr1)
                command.Parameters.AddWithValue("@p_ShipAddr2", ADOHelper.NullCheck(Me.ShipAddr2))
                command.Parameters.AddWithValue("@p_ShipCity", Me.ShipCity)
                command.Parameters.AddWithValue("@p_ShipState", Me.ShipState)
                command.Parameters.AddWithValue("@p_ShipZip", Me.ShipZip)
                command.Parameters.AddWithValue("@p_ShipCountry", Me.ShipCountry)
                command.Parameters.AddWithValue("@p_BillAddr1", Me.BillAddr1)
                command.Parameters.AddWithValue("@p_BillAddr2", ADOHelper.NullCheck(Me.BillAddr2))
                command.Parameters.AddWithValue("@p_BillCity", Me.BillCity)
                command.Parameters.AddWithValue("@p_BillState", Me.BillState)
                command.Parameters.AddWithValue("@p_BillZip", Me.BillZip)
                command.Parameters.AddWithValue("@p_BillCountry", Me.BillCountry)
                command.Parameters.AddWithValue("@p_Courier", Me.Courier)
                command.Parameters.AddWithValue("@p_TotalPrice", Me.TotalPrice)
                command.Parameters.AddWithValue("@p_BillToFirstName", Me.BillToFirstName)
                command.Parameters.AddWithValue("@p_BillToLastName", Me.BillToLastName)
                command.Parameters.AddWithValue("@p_ShipToFirstName", Me.ShipToFirstName)
                command.Parameters.AddWithValue("@p_ShipToLastName", Me.ShipToLastName)
                command.Parameters.AddWithValue("@p_AuthorizationNumber", Me.AuthorizationNumber)
                command.Parameters.AddWithValue("@p_Locale", Me.Locale)
    
                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    If reader.Read() Then
                    End If
                End Using
    
            End Using
            FieldManager.UpdateChildren(Me, connection)
    
            OnChildUpdated()
        End Sub
    
#End Region
    
        Private Sub Child_DeleteSelf()
            Dim cancel As Boolean = False
            OnChildSelfDeleting(cancel)
            If (cancel) Then
                Return
            End If
        
            DataPortal_Delete(New OrderCriteria (OrderId))
        
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
        
            DataPortal_Delete(New OrderCriteria (OrderId), connection)
        
            OnChildSelfDeleted()
        End Sub
    
#End Region
    
#Region "Map"

        Private Sub Map(ByVal reader As SafeDataReader)
            Dim cancel As Boolean = False
            OnMapping(reader, cancel)
            If (cancel) Then
                Return
            End If
    
            Using(BypassPropertyChecks)
                LoadProperty(_orderIdProperty, reader.Item("OrderId"))
                LoadProperty(_userIdProperty, reader.Item("UserId"))
                LoadProperty(_orderDateProperty, reader.Item("OrderDate"))
                LoadProperty(_shipAddr1Property, reader.Item("ShipAddr1"))
                LoadProperty(_shipAddr2Property, reader.Item("ShipAddr2"))
                LoadProperty(_shipCityProperty, reader.Item("ShipCity"))
                LoadProperty(_shipStateProperty, reader.Item("ShipState"))
                LoadProperty(_shipZipProperty, reader.Item("ShipZip"))
                LoadProperty(_shipCountryProperty, reader.Item("ShipCountry"))
                LoadProperty(_billAddr1Property, reader.Item("BillAddr1"))
                LoadProperty(_billAddr2Property, reader.Item("BillAddr2"))
                LoadProperty(_billCityProperty, reader.Item("BillCity"))
                LoadProperty(_billStateProperty, reader.Item("BillState"))
                LoadProperty(_billZipProperty, reader.Item("BillZip"))
                LoadProperty(_billCountryProperty, reader.Item("BillCountry"))
                LoadProperty(_courierProperty, reader.Item("Courier"))
                LoadProperty(_totalPriceProperty, reader.Item("TotalPrice"))
                LoadProperty(_billToFirstNameProperty, reader.Item("BillToFirstName"))
                LoadProperty(_billToLastNameProperty, reader.Item("BillToLastName"))
                LoadProperty(_shipToFirstNameProperty, reader.Item("ShipToFirstName"))
                LoadProperty(_shipToLastNameProperty, reader.Item("ShipToLastName"))
                LoadProperty(_authorizationNumberProperty, reader.Item("AuthorizationNumber"))
                LoadProperty(_localeProperty, reader.Item("Locale"))
            End Using
    
            OnMapped()
        End Sub

        Private Sub Child_Fetch(reader As SafeDataReader)
            Map(reader)
        End Sub

#End Region
    End Class
End Namespace
