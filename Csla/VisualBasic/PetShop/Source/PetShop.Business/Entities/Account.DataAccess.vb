﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v6.5.0, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Account.vb.
'
'     Template: EditableChild.DataAccess.ParameterizedSQL.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On
#If Not SILVERLIGHT Then

Imports System
Imports System.Data
Imports System.Data.SqlClient

Imports Csla
Imports Csla.Data

Namespace PetShop.Business
    Public Partial Class Account
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
        
        Private Sub Child_Fetch(ByVal criteria As AccountCriteria)
            Dim cancel As Boolean = False
            OnChildFetching(criteria, cancel)
            If (cancel) Then
                Return
            End If
    
            Dim commandText As String = String.Format("SELECT [AccountId], [UniqueID], [Email], [FirstName], [LastName], [Address1], [Address2], [City], [State], [Zip], [Country], [Phone] FROM [dbo].[Account] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                    Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                        If reader.Read() Then
                            Map(reader)
                        Else
                            Throw New Exception(String.Format("The record was not found In 'dbo.Account' using the following criteria: {0}.", criteria))
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
            Const commandText As String = "INSERT INTO [dbo].[Account] ([UniqueID], [Email], [FirstName], [LastName], [Address1], [Address2], [City], [State], [Zip], [Country], [Phone]) VALUES (@p_UniqueID, @p_Email, @p_FirstName, @p_LastName, @p_Address1, @p_Address2, @p_City, @p_State, @p_Zip, @p_Country, @p_Phone); SELECT [AccountId] FROM [dbo].[Account] WHERE AccountId = SCOPE_IDENTITY()"
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@p_UniqueID", Me.UniqueID)
                command.Parameters.AddWithValue("@p_Email", Me.Email)
                command.Parameters.AddWithValue("@p_FirstName", Me.FirstName)
                command.Parameters.AddWithValue("@p_LastName", Me.LastName)
                command.Parameters.AddWithValue("@p_Address1", Me.Address1)
                command.Parameters.AddWithValue("@p_Address2", ADOHelper.NullCheck(Me.Address2))
                command.Parameters.AddWithValue("@p_City", Me.City)
                command.Parameters.AddWithValue("@p_State", Me.State)
                command.Parameters.AddWithValue("@p_Zip", Me.Zip)
                command.Parameters.AddWithValue("@p_Country", Me.Country)
                command.Parameters.AddWithValue("@p_Phone", ADOHelper.NullCheck(Me.Phone))
    
                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    If reader.Read() Then
    
                        ' Update identity or guid primary key value.
                        LoadProperty(_accountIdProperty, reader.GetInt32("AccountId"))
                    End If
                End Using
            End Using
    
            FieldManager.UpdateChildren(Me, connection)
    
            OnChildInserted()
        End Sub
    
        Private Sub Child_Insert(ByVal profile As Profile, ByVal connection As SqlConnection)
            Dim cancel As Boolean = False
            OnChildInserting(profile, connection, cancel)
            If (cancel) Then
                Return
            End If

            If Not (connection.State = ConnectionState.Open) Then connection.Open()
            Const commandText As String = "INSERT INTO [dbo].[Account] ([UniqueID], [Email], [FirstName], [LastName], [Address1], [Address2], [City], [State], [Zip], [Country], [Phone]) VALUES (@p_UniqueID, @p_Email, @p_FirstName, @p_LastName, @p_Address1, @p_Address2, @p_City, @p_State, @p_Zip, @p_Country, @p_Phone); SELECT [AccountId] FROM [dbo].[Account] WHERE AccountId = SCOPE_IDENTITY()"
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@p_UniqueID", If(Not(profile Is Nothing), profile.UniqueID, Me.UniqueID))
                command.Parameters.AddWithValue("@p_Email", Me.Email)
                command.Parameters.AddWithValue("@p_FirstName", Me.FirstName)
                command.Parameters.AddWithValue("@p_LastName", Me.LastName)
                command.Parameters.AddWithValue("@p_Address1", Me.Address1)
                command.Parameters.AddWithValue("@p_Address2", ADOHelper.NullCheck(Me.Address2))
                command.Parameters.AddWithValue("@p_City", Me.City)
                command.Parameters.AddWithValue("@p_State", Me.State)
                command.Parameters.AddWithValue("@p_Zip", Me.Zip)
                command.Parameters.AddWithValue("@p_Country", Me.Country)
                command.Parameters.AddWithValue("@p_Phone", ADOHelper.NullCheck(Me.Phone))
    
                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    If reader.Read() Then
    
                        ' Update identity or guid primary key value.
                        LoadProperty(_accountIdProperty, reader.GetInt32("AccountId"))
                    End If
                End Using
            End Using
    
            ' Update foreign keys values. This code will update the values passed In from the parent only if no errors occurred after executing the query.
            If(Not IsNothing(profile) AndAlso Not profile.UniqueID = Me.UniqueID) Then
                LoadProperty(_uniqueIDProperty, profile.UniqueID)
            End If
    
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
            Const commandText As String = "UPDATE [dbo].[Account] SET [UniqueID] = @p_UniqueID, [Email] = @p_Email, [FirstName] = @p_FirstName, [LastName] = @p_LastName, [Address1] = @p_Address1, [Address2] = @p_Address2, [City] = @p_City, [State] = @p_State, [Zip] = @p_Zip, [Country] = @p_Country, [Phone] = @p_Phone WHERE [AccountId] = @p_AccountId"
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@p_AccountId", Me.AccountId)
                command.Parameters.AddWithValue("@p_UniqueID", Me.UniqueID)
                command.Parameters.AddWithValue("@p_Email", Me.Email)
                command.Parameters.AddWithValue("@p_FirstName", Me.FirstName)
                command.Parameters.AddWithValue("@p_LastName", Me.LastName)
                command.Parameters.AddWithValue("@p_Address1", Me.Address1)
                command.Parameters.AddWithValue("@p_Address2", ADOHelper.NullCheck(Me.Address2))
                command.Parameters.AddWithValue("@p_City", Me.City)
                command.Parameters.AddWithValue("@p_State", Me.State)
                command.Parameters.AddWithValue("@p_Zip", Me.Zip)
                command.Parameters.AddWithValue("@p_Country", Me.Country)
                command.Parameters.AddWithValue("@p_Phone", ADOHelper.NullCheck(Me.Phone))
    
                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    If reader.Read() Then
                    End If
                End Using
    
            End Using
            FieldManager.UpdateChildren(Me, connection)
    
            OnChildUpdated()
        End Sub
    
        Private Sub Child_Update(ByVal profile As Profile, ByVal connection As SqlConnection)
            Dim cancel As Boolean = False
            OnChildUpdating(profile, connection, cancel)
            If (cancel) Then
                Return
            End If

            If Not connection.State = ConnectionState.Open Then connection.Open()
            Const commandText As String = "UPDATE [dbo].[Account] SET [UniqueID] = @p_UniqueID, [Email] = @p_Email, [FirstName] = @p_FirstName, [LastName] = @p_LastName, [Address1] = @p_Address1, [Address2] = @p_Address2, [City] = @p_City, [State] = @p_State, [Zip] = @p_Zip, [Country] = @p_Country, [Phone] = @p_Phone WHERE [AccountId] = @p_AccountId"
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@p_AccountId", Me.AccountId)
                command.Parameters.AddWithValue("@p_UniqueID", If(Not(profile Is Nothing), profile.UniqueID, Me.UniqueID))
                command.Parameters.AddWithValue("@p_Email", Me.Email)
                command.Parameters.AddWithValue("@p_FirstName", Me.FirstName)
                command.Parameters.AddWithValue("@p_LastName", Me.LastName)
                command.Parameters.AddWithValue("@p_Address1", Me.Address1)
                command.Parameters.AddWithValue("@p_Address2", ADOHelper.NullCheck(Me.Address2))
                command.Parameters.AddWithValue("@p_City", Me.City)
                command.Parameters.AddWithValue("@p_State", Me.State)
                command.Parameters.AddWithValue("@p_Zip", Me.Zip)
                command.Parameters.AddWithValue("@p_Country", Me.Country)
                command.Parameters.AddWithValue("@p_Phone", ADOHelper.NullCheck(Me.Phone))
    
                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    If reader.Read() Then
                    End If
                End Using
    
                ' Update foreign keys values. This code will update the values passed In from the parent only if no errors occurred after executing the query.
                If(Not IsNothing(profile) AndAlso Not profile.UniqueID = Me.UniqueID) Then
                    LoadProperty(_uniqueIDProperty, profile.UniqueID)
                End If
    
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
        
            DataPortal_Delete(New AccountCriteria (AccountId), connection)
        
            OnChildSelfDeleted()
        End Sub
        
        Protected Shadows Sub DataPortal_Delete(ByVal criteria As AccountCriteria, ByVal connection as SqlConnection)
            Dim cancel As Boolean = False
            OnDeleting(criteria, connection, cancel)
            If (cancel) Then
                Return
            End If

            Dim commandText As String = String.Format("DELETE FROM [dbo].[Account] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
    
                'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                Dim result As Integer = command.ExecuteNonQuery()
                If result = 0 Then
                    Throw New DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                End If
    
            End Using
    
        OnDeleted()
        End Sub
        
#Region "Map"

        Private Sub Map(ByVal reader As SafeDataReader)
            Dim cancel As Boolean = False
            OnMapping(reader, cancel)
            If (cancel) Then
                Return
            End If
    
            Using(BypassPropertyChecks)
                LoadProperty(_accountIdProperty, reader.Item("AccountId"))
                LoadProperty(_uniqueIDProperty, reader.Item("UniqueID"))
                LoadProperty(_emailProperty, reader.Item("Email"))
                LoadProperty(_firstNameProperty, reader.Item("FirstName"))
                LoadProperty(_lastNameProperty, reader.Item("LastName"))
                LoadProperty(_address1Property, reader.Item("Address1"))
                LoadProperty(_address2Property, reader.Item("Address2"))
                LoadProperty(_cityProperty, reader.Item("City"))
                LoadProperty(_stateProperty, reader.Item("State"))
                LoadProperty(_zipProperty, reader.Item("Zip"))
                LoadProperty(_countryProperty, reader.Item("Country"))
                LoadProperty(_phoneProperty, reader.Item("Phone"))
            End Using
    
            OnMapped()
        End Sub

        Private Sub Child_Fetch(reader As SafeDataReader)
            Map(reader)
        End Sub

#End Region
    End Class
End Namespace
#End If
