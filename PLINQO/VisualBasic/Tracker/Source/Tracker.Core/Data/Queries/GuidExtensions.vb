﻿
'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a CodeSmith Template.
'
'     DO NOT MODIFY contents of this file. Changes to this
'     file will be lost if the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Linq
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports CodeSmith.Data.Linq
Imports CodeSmith.Data.Linq.Dynamic

Namespace Tracker.Core.Data
    ''' <summary>
    ''' The query extension class for Guid.
    ''' </summary>
    Public Module GuidExtensions
        ''' <summary>
        ''' Gets an instance by the primary key.
        ''' </summary>
        <System.Runtime.CompilerServices.Extension()> _
        Public Function GetByKey(ByVal queryable As IQueryable(Of Tracker.Core.Data.Guid), ByVal id As System.Guid) As Tracker.Core.Data.Guid

            Dim entity As System.Data.Linq.Table(Of Tracker.Core.Data.Guid) = CType(queryable, Table(Of Tracker.Core.Data.Guid))
            If (entity IsNot Nothing AndAlso entity.Context.LoadOptions Is Nothing) Then
                Return Query.GetByKey.Invoke(DirectCast(entity.Context, Tracker.Core.Data.TrackerDataContext), id)
            End If

            Return queryable.FirstOrDefault(Function(g)g.Id = id)
        End Function
        
        ''' <summary>
        ''' Immediately deletes the entity by the primary key from the underlying data source with a single delete command.
        ''' </summary>
        ''' <param name="table">Represents a table for a particular type in the underlying database containing rows are to be deleted.</param>
        ''' <returns>The number of rows deleted from the database.</returns>
        <System.Runtime.CompilerServices.Extension()> _
        Public Function Delete(ByVal table As System.Data.Linq.Table(Of Tracker.Core.Data.Guid), ByVal id As System.Guid) As Integer
            Return table.Delete(Function(g)g.Id = id)
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.Guid"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="id">Id to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension()> _
        Public Function ById(ByVal queryable As IQueryable(Of Tracker.Core.Data.Guid), ByVal id As System.Guid) As IQueryable(Of Tracker.Core.Data.Guid)
            Return queryable.Where(Function(g)g.Id = id)
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.Guid"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="id">Id to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension()> _
        Public Function ById(ByVal queryable As IQueryable(Of Tracker.Core.Data.Guid), ByVal id As System.Guid, ByVal ParamArray additionalValues As System.Guid()) As IQueryable(Of Tracker.Core.Data.Guid)
            Dim values = New List(Of System.Guid)()
            values.Add(id)
        
            If additionalValues IsNot Nothing Then
                values.AddRange(additionalValues)
            End If
        
            If values.Count = 1 Then
                Return queryable.ById(values(0))
            End If
        
            Return queryable.ById(values)
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.Guid"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="values">The values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension()> _
        Public Function ById(ByVal queryable As IQueryable(Of Tracker.Core.Data.Guid), ByVal values As IEnumerable(Of System.Guid)) As IQueryable(Of Tracker.Core.Data.Guid)
                Return queryable.Where(Function(g) values.Contains(g.Id))
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.Guid"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="id">Id to search for.</param>
        ''' <param name="comparison">The comparison operator.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension()> _
        Public Function ById(ByVal queryable As IQueryable(Of Tracker.Core.Data.Guid), ByVal comparison As ComparisonOperator, ByVal id As System.Guid) As IQueryable(Of Tracker.Core.Data.Guid)
            Select Case comparison
                Case ComparisonOperator.GreaterThan, ComparisonOperator.GreaterThanOrEquals, ComparisonOperator.LessThan, ComparisonOperator.LessThanOrEquals
                    Throw New ArgumentException("Parameter 'comparison' must be ComparisonOperator.Equals or ComparisonOperator.NotEquals to support System.Guid type.", "comparison")
                Case ComparisonOperator.NotEquals
                    Return queryable.Where(Function(g) g.Id <> id)
                Case Else
                    Return queryable.Where(Function(g) g.Id = id)
            End Select
        End Function


        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.Guid"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="alternateId">AlternateId to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension()> _
        Public Function ByAlternateId(ByVal queryable As IQueryable(Of Tracker.Core.Data.Guid), ByVal alternateId As System.Guid?) As IQueryable(Of Tracker.Core.Data.Guid)
            Return queryable.Where(Function(g) Object.Equals(g.AlternateId, alternateId))
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.Guid"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="alternateId">AlternateId to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension()> _
        Public Function ByAlternateId(ByVal queryable As IQueryable(Of Tracker.Core.Data.Guid), ByVal alternateId As System.Guid?, ByVal ParamArray additionalValues As System.Guid?()) As IQueryable(Of Tracker.Core.Data.Guid)
            Dim values = New List(Of System.Guid?)()
            values.Add(alternateId)
        
            If additionalValues IsNot Nothing Then
                values.AddRange(additionalValues)
            Else
                values.Add(Nothing)
            End If
        
            If values.Count = 1 Then
                Return queryable.ByAlternateId(values(0))
            End If
        
            Return queryable.ByAlternateId(values)
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.Guid"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="values">The values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension()> _
        Public Function ByAlternateId(ByVal queryable As IQueryable(Of Tracker.Core.Data.Guid), ByVal values As IEnumerable(Of System.Guid?)) As IQueryable(Of Tracker.Core.Data.Guid)
                ' creating dynmic expression to support nulls
                Dim expression = DynamicExpression.BuildExpression(Of Tracker.Core.Data.Guid, Boolean)("AlternateId", values)
                Return queryable.Where(expression)
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.Guid"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="alternateId">AlternateId to search for.</param>
        ''' <param name="comparison">The comparison operator.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension()> _
        Public Function ByAlternateId(ByVal queryable As IQueryable(Of Tracker.Core.Data.Guid), ByVal comparison As ComparisonOperator, ByVal alternateId As System.Guid?) As IQueryable(Of Tracker.Core.Data.Guid)
            If alternateId Is Nothing AndAlso comparison <> ComparisonOperator.Equals AndAlso comparison <> ComparisonOperator.NotEquals Then
                Throw New ArgumentNullException("alternateId", "Parameter 'alternateId' cannot be null with the specified ComparisonOperator.  Parameter 'comparison' must be ComparisonOperator.Equals or ComparisonOperator.NotEquals to support null.")
            End If
            
            Select Case comparison
                Case ComparisonOperator.GreaterThan, ComparisonOperator.GreaterThanOrEquals, ComparisonOperator.LessThan, ComparisonOperator.LessThanOrEquals
                    Throw New ArgumentException("Parameter 'comparison' must be ComparisonOperator.Equals or ComparisonOperator.NotEquals to support System.Guid? type.", "comparison")
                Case ComparisonOperator.NotEquals
                    Return queryable.Where(Function(g) Object.Equals(g.AlternateId, alternateId) = False)
                Case Else
                    Return queryable.Where(Function(g) Object.Equals(g.AlternateId, alternateId))
            End Select
        End Function


        'Insert User Defined Extensions here.
        'Anything outside of this Region will be lost at regeneration
        #Region "User Extensions"


        #End Region

        #Region "Query"
        ''' <summary>
        ''' A private class for lazy loading static compiled queries.
        ''' </summary>
        Private Partial Class Query


            Friend Shared ReadOnly GetByKey As Func(Of TrackerDataContext, System.Guid, Tracker.Core.Data.Guid) = _
                CompiledQuery.Compile( _
                    Function(db As TrackerDataContext , ByVal id As System.Guid) _
                        db.Guid.FirstOrDefault(Function(g)g.Id = id))

            ' Add your compiled queries here.
            'Anything outside of this Region will be lost at regeneration
            #Region "User Queries"

            #End Region

        End Class
        #End Region
    End Module
End Namespace

