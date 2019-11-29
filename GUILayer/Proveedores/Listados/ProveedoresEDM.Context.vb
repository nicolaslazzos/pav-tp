﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.Core.Objects
Imports System.Linq

Partial Public Class ProveedoresEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=ProveedoresEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub


    Public Overridable Function ListadoProveedores(fechaDesde As Nullable(Of Date), fechaHasta As Nullable(Of Date), provincia As Nullable(Of Integer)) As ObjectResult(Of ListadoProveedores_Result)
        Dim fechaDesdeParameter As ObjectParameter = If(fechaDesde.HasValue, New ObjectParameter("fechaDesde", fechaDesde), New ObjectParameter("fechaDesde", GetType(Date)))

        Dim fechaHastaParameter As ObjectParameter = If(fechaHasta.HasValue, New ObjectParameter("fechaHasta", fechaHasta), New ObjectParameter("fechaHasta", GetType(Date)))

        Dim provinciaParameter As ObjectParameter = If(provincia.HasValue, New ObjectParameter("provincia", provincia), New ObjectParameter("provincia", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of ListadoProveedores_Result)("ListadoProveedores", fechaDesdeParameter, fechaHastaParameter, provinciaParameter)
    End Function

End Class