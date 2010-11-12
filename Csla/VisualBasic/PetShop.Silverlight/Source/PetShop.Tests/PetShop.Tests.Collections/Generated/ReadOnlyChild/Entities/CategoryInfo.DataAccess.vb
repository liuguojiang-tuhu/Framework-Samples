﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.3, CSLA Templates: v3.0.1.1934, CSLA Framework: v4.0.0.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'CategoryInfo.vb.
'
'     Template: ReadOnlyChild.DataAccess.StoredProcedures.cst
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

Namespace PetShop.Tests.Collections.ReadOnlyChild
    Public Partial Class CategoryInfo
        Private Sub Child_Fetch(ByVal criteria As CategoryCriteria)
            Dim cancel As Boolean = False
            OnChildFetching(criteria, cancel)
            If (cancel) Then
                Return
            End If
    
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand("[dbo].[CSLA_Category_Select]", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                    command.Parameters.AddWithValue("@p_NameHasValue", criteria.NameHasValue)
					command.Parameters.AddWithValue("@p_DescnHasValue", criteria.DescriptionHasValue)
                    Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                        If reader.Read() Then
                            Map(reader)
                        Else
                            Throw New Exception(String.Format("The record was not found in 'Category' using the following criteria: {0}.", criteria))
                        End If
                    End Using
                End Using
            End Using
    
            OnChildFetched()
        End Sub
    
        Private Sub Map(ByVal reader As SafeDataReader)
            Dim cancel As Boolean = False
            OnMapping(reader, cancel)
            If (cancel) Then
                Return
            End If
    
            LoadProperty(_categoryIdProperty, reader.Item("CategoryId"))
            LoadProperty(_nameProperty, reader.Item("Name"))
            LoadProperty(_descriptionProperty, reader.Item("Descn"))
    
            OnMapped()
        End Sub
    End Class
End Namespace
