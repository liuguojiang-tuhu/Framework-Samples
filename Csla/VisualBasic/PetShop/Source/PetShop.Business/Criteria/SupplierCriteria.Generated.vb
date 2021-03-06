﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v6.5.0, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Supplier.vb.
'
'     Template: Criteria.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Collections.Generic
Imports System.Runtime.InteropServices

#If Not SILVERLIGHT Then
Imports System.Data.SqlClient
#End If

Imports Csla
Imports Csla.Core
#If SILVERLIGHT Then
Imports Csla.Serialization
#End If
Imports Csla.Serialization.Mobile

Namespace PetShop.Business
    <Serializable(), ClassInterface(ClassInterfaceType.None)> _
    Public Partial Class SupplierCriteria
        Inherits CriteriaBase(Of SupplierCriteria)
        Implements IGeneratedCriteria
    
#Region "Private Read-Only Properties"
        
        Private ReadOnly _bag As New Dictionary(Of String, Object)()
        
#End Region
    
#Region "Constructors"
    
        Public Sub New()
        
        End Sub

        Public Sub New(ByVal suppId As System.Int32) 
            
            
            Me.SuppId = suppId
        End Sub

#End Region

#Region "Public Properties"

#Region "Read-Write"
        
        Public Property SuppId() As System.Int32
            Get
                Return GetValue(Of System.Int32)("SuppId")
            End Get
            Set
                _bag("SuppId") = value
            End Set
        End Property
        
        Public Property Name() As System.String
            Get
                Return GetValue(Of System.String)("Name")
            End Get
            Set
                _bag("Name") = value
            End Set
        End Property
        
        Public Property Status() As System.String
            Get
                Return GetValue(Of System.String)("Status")
            End Get
            Set
                _bag("Status") = value
            End Set
        End Property
        
        Public Property Addr1() As System.String
            Get
                Return GetValue(Of System.String)("Addr1")
            End Get
            Set
                _bag("Addr1") = value
            End Set
        End Property
        
        Public Property Addr2() As System.String
            Get
                Return GetValue(Of System.String)("Addr2")
            End Get
            Set
                _bag("Addr2") = value
            End Set
        End Property
        
        Public Property City() As System.String
            Get
                Return GetValue(Of System.String)("City")
            End Get
            Set
                _bag("City") = value
            End Set
        End Property
        
        Public Property State() As System.String
            Get
                Return GetValue(Of System.String)("State")
            End Get
            Set
                _bag("State") = value
            End Set
        End Property
        
        Public Property Zip() As System.String
            Get
                Return GetValue(Of System.String)("Zip")
            End Get
            Set
                _bag("Zip") = value
            End Set
        End Property
        
        Public Property Phone() As System.String
            Get
                Return GetValue(Of System.String)("Phone")
            End Get
            Set
                _bag("Phone") = value
            End Set
        End Property

#End Region
        
#Region "Read-Only"
    
        ''' <summary>
        ''' Returns a list of all the modified properties and values.
        ''' </summary>
        Public ReadOnly Property StateBag() As Dictionary(Of String, Object) Implements IGeneratedCriteria.StateBag
            Get
                Return _bag
            End Get
        End Property
    
        ''' <summary>
        ''' Returns a list of all the modified properties and values.
        ''' </summary>
        Public ReadOnly Property TableFullName() As String Implements IGeneratedCriteria.TableFullName
            Get
                Return "Supplier"
            End Get
        End Property
    
#End Region
    
#End Region
    
#Region "Overrides"
    
        Public Overrides Function ToString() As String
            Dim result As String = String.Empty
            Dim cancel As Boolean = False
            
            OnToString(result, cancel)
            If(cancel AndAlso Not String.IsNullOrEmpty(result)) Then
                Return result
            End If
        
            If _bag.Count = 0 Then
                Return "No criterion was specified."
            End If
    
            For Each key As KeyValuePair(Of String, Object) In _bag
                result += String.Format("[{0}] = '{1}' AND ", key.Key, key.Value)
            Next
    
            Return result.Remove(result.Length - 5, 5)
        End Function
    
#End Region
    
#Region "Private Methods"
        
        Private Function GetValue(Of T)(name As String) As T
            Dim value As New Object
            If _bag.TryGetValue(name, value) Then
                Return DirectCast(value, T)
            End If
        
            Return Nothing
        End Function
        
#End Region
        
#Region "Partial Methods"

        Partial Private Sub OnToString(ByRef result As String, ByRef cancel As Boolean)
        End Sub

#End Region

#Region "Serialization"

        Protected Overrides Sub OnGetState(ByVal info As SerializationInfo, ByVal mode As StateMode)
            MyBase.OnGetState(info, mode)
            
            If _bag.ContainsKey("SuppId") Then
                info.AddValue("SuppId", GetValue(Of System.Int32)("SuppId"))
            End If
            If _bag.ContainsKey("Name") Then
                info.AddValue("Name", GetValue(Of System.String)("Name"))
            End If
            If _bag.ContainsKey("Status") Then
                info.AddValue("Status", GetValue(Of System.String)("Status"))
            End If
            If _bag.ContainsKey("Addr1") Then
                info.AddValue("Addr1", GetValue(Of System.String)("Addr1"))
            End If
            If _bag.ContainsKey("Addr2") Then
                info.AddValue("Addr2", GetValue(Of System.String)("Addr2"))
            End If
            If _bag.ContainsKey("City") Then
                info.AddValue("City", GetValue(Of System.String)("City"))
            End If
            If _bag.ContainsKey("State") Then
                info.AddValue("State", GetValue(Of System.String)("State"))
            End If
            If _bag.ContainsKey("Zip") Then
                info.AddValue("Zip", GetValue(Of System.String)("Zip"))
            End If
            If _bag.ContainsKey("Phone") Then
                info.AddValue("Phone", GetValue(Of System.String)("Phone"))
            End If
        End Sub
        
        Protected Overrides Sub OnSetState(ByVal info As SerializationInfo, ByVal mode As StateMode)
            MyBase.OnSetState(info, mode)
            
            If info.Values.ContainsKey("SuppId") Then
                _bag("SuppId") = info.GetValue(Of System.Int32)("SuppId")
            End If
            If info.Values.ContainsKey("Name") Then
                _bag("Name") = info.GetValue(Of System.String)("Name")
            End If
            If info.Values.ContainsKey("Status") Then
                _bag("Status") = info.GetValue(Of System.String)("Status")
            End If
            If info.Values.ContainsKey("Addr1") Then
                _bag("Addr1") = info.GetValue(Of System.String)("Addr1")
            End If
            If info.Values.ContainsKey("Addr2") Then
                _bag("Addr2") = info.GetValue(Of System.String)("Addr2")
            End If
            If info.Values.ContainsKey("City") Then
                _bag("City") = info.GetValue(Of System.String)("City")
            End If
            If info.Values.ContainsKey("State") Then
                _bag("State") = info.GetValue(Of System.String)("State")
            End If
            If info.Values.ContainsKey("Zip") Then
                _bag("Zip") = info.GetValue(Of System.String)("Zip")
            End If
            If info.Values.ContainsKey("Phone") Then
                _bag("Phone") = info.GetValue(Of System.String)("Phone")
            End If
        End Sub

#End Region

    End Class
End Namespace