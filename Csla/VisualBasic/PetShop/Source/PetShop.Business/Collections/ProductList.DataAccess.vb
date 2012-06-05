﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v6.5.0, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'ProductList.vb.
'
'     Template: DynamicRootList.DataAccess.ParameterizedSQL.cst
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
    Public Partial Class ProductList
        Private Sub DataPortal_Create()
        End Sub
    
        Private Shadows Sub DataPortal_Fetch(ByVal criteria As ProductCriteria)
            Dim cancel As Boolean = False
            OnFetching(criteria, cancel)
            If (cancel) Then
                Return
            End If
    
            RaiseListChangedEvents = False
    
            ' Fetch Child objects.
            Dim commandText As String = String.Format("SELECT [ProductId], [CategoryId], [Name], [Descn], [Image] FROM [dbo].[Product] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                    Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                        If reader.Read() Then
                            Do
                                Me.Add(PetShop.Business.Product.GetProduct(reader))
                            Loop While reader.Read()
                        End If
                    End Using
                End Using
            End Using
    
            RaiseListChangedEvents = True
    
            OnFetched()
        End Sub
    End Class
End Namespace
#End If
