﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.1378
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<System.Data.Linq.Mapping.DatabaseAttribute(Name:="C:\VISUAL STUDIO PROJECTS\CSLA\DEEPDATA\DEEPDATA\DEEPDATASTORE.MDF")>  _
Partial Public Class DataClasses1DataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertOrder(instance As [Order])
    End Sub
  Partial Private Sub UpdateOrder(instance As [Order])
    End Sub
  Partial Private Sub DeleteOrder(instance As [Order])
    End Sub
  Partial Private Sub InsertOrderLineDetail(instance As OrderLineDetail)
    End Sub
  Partial Private Sub UpdateOrderLineDetail(instance As OrderLineDetail)
    End Sub
  Partial Private Sub DeleteOrderLineDetail(instance As OrderLineDetail)
    End Sub
  Partial Private Sub InsertOrderLine(instance As OrderLine)
    End Sub
  Partial Private Sub UpdateOrderLine(instance As OrderLine)
    End Sub
  Partial Private Sub DeleteOrderLine(instance As OrderLine)
    End Sub
  #End Region
	
	Shared Sub New()
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New()
		MyBase.New(Global.DeepData.DAL.DLinq.My.MySettings.Default.DeepDataStoreConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property Orders() As System.Data.Linq.Table(Of [Order])
		Get
			Return Me.GetTable(Of [Order])
		End Get
	End Property
	
	Public ReadOnly Property OrderLineDetails() As System.Data.Linq.Table(Of OrderLineDetail)
		Get
			Return Me.GetTable(Of OrderLineDetail)
		End Get
	End Property
	
	Public ReadOnly Property OrderLines() As System.Data.Linq.Table(Of OrderLine)
		Get
			Return Me.GetTable(Of OrderLine)
		End Get
	End Property
End Class

<Table(Name:="dbo.[Order]")>  _
Partial Public Class [Order]
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _Id As Integer
	
	Private _Customer As String
	
	Private _OrderLines As EntitySet(Of OrderLine)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate()
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnIdChanged()
    End Sub
    Partial Private Sub OnCustomerChanging(value As String)
    End Sub
    Partial Private Sub OnCustomerChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
		Me._OrderLines = New EntitySet(Of OrderLine)(AddressOf Me.attach_OrderLines, AddressOf Me.detach_OrderLines)
	End Sub
	
	<Column(Storage:="_Id", DbType:="Int NOT NULL", IsPrimaryKey:=true)>  _
	Public Property Id() As Integer
		Get
			Return Me._Id
		End Get
		Set
			If ((Me._Id = value)  _
						= false) Then
				Me.OnIdChanging(value)
				Me.SendPropertyChanging
				Me._Id = value
				Me.SendPropertyChanged("Id")
				Me.OnIdChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Customer", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property Customer() As String
		Get
			Return Me._Customer
		End Get
		Set
			If ((Me._Customer = value)  _
						= false) Then
				Me.OnCustomerChanging(value)
				Me.SendPropertyChanging
				Me._Customer = value
				Me.SendPropertyChanged("Customer")
				Me.OnCustomerChanged
			End If
		End Set
	End Property
	
	<Association(Name:="Order_OrderLine", Storage:="_OrderLines", OtherKey:="OrderId")>  _
	Public Property OrderLines() As EntitySet(Of OrderLine)
		Get
			Return Me._OrderLines
		End Get
		Set
			Me._OrderLines.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_OrderLines(ByVal entity As OrderLine)
		Me.SendPropertyChanging
		entity.[Order] = Me
		Me.SendPropertyChanged("OrderLines")
	End Sub
	
	Private Sub detach_OrderLines(ByVal entity As OrderLine)
		Me.SendPropertyChanging
		entity.[Order] = Nothing
		Me.SendPropertyChanged("OrderLines")
	End Sub
End Class

<Table(Name:="dbo.OrderLineDetail")>  _
Partial Public Class OrderLineDetail
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _OrderId As Integer
	
	Private _LineId As Integer
	
	Private _Id As Integer
	
	Private _Detail As String
	
	Private _OrderLine As EntityRef(Of OrderLine)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate()
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnOrderIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnOrderIdChanged()
    End Sub
    Partial Private Sub OnLineIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnLineIdChanged()
    End Sub
    Partial Private Sub OnIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnIdChanged()
    End Sub
    Partial Private Sub OnDetailChanging(value As String)
    End Sub
    Partial Private Sub OnDetailChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
		Me._OrderLine = CType(Nothing, EntityRef(Of OrderLine))
	End Sub
	
	<Column(Storage:="_OrderId", DbType:="Int NOT NULL", IsPrimaryKey:=true)>  _
	Public Property OrderId() As Integer
		Get
			Return Me._OrderId
		End Get
		Set
			If ((Me._OrderId = value)  _
						= false) Then
				If Me._OrderLine.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException
				End If
				Me.OnOrderIdChanging(value)
				Me.SendPropertyChanging
				Me._OrderId = value
				Me.SendPropertyChanged("OrderId")
				Me.OnOrderIdChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_LineId", DbType:="Int NOT NULL", IsPrimaryKey:=true)>  _
	Public Property LineId() As Integer
		Get
			Return Me._LineId
		End Get
		Set
			If ((Me._LineId = value)  _
						= false) Then
				If Me._OrderLine.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException
				End If
				Me.OnLineIdChanging(value)
				Me.SendPropertyChanging
				Me._LineId = value
				Me.SendPropertyChanged("LineId")
				Me.OnLineIdChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Id", DbType:="Int NOT NULL", IsPrimaryKey:=true)>  _
	Public Property Id() As Integer
		Get
			Return Me._Id
		End Get
		Set
			If ((Me._Id = value)  _
						= false) Then
				Me.OnIdChanging(value)
				Me.SendPropertyChanging
				Me._Id = value
				Me.SendPropertyChanged("Id")
				Me.OnIdChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Detail", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property Detail() As String
		Get
			Return Me._Detail
		End Get
		Set
			If ((Me._Detail = value)  _
						= false) Then
				Me.OnDetailChanging(value)
				Me.SendPropertyChanging
				Me._Detail = value
				Me.SendPropertyChanged("Detail")
				Me.OnDetailChanged
			End If
		End Set
	End Property
	
	<Association(Name:="OrderLine_OrderLineDetail", Storage:="_OrderLine", ThisKey:="OrderId,LineId", IsForeignKey:=true)>  _
	Public Property OrderLine() As OrderLine
		Get
			Return Me._OrderLine.Entity
		End Get
		Set
			Dim previousValue As OrderLine = Me._OrderLine.Entity
			If (((previousValue Is value)  _
						= false)  _
						OrElse (Me._OrderLine.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._OrderLine.Entity = Nothing
					previousValue.OrderLineDetails.Remove(Me)
				End If
				Me._OrderLine.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.OrderLineDetails.Add(Me)
					Me._OrderId = value.OrderId
					Me._LineId = value.Id
				Else
					Me._OrderId = CType(Nothing, Integer)
					Me._LineId = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("OrderLine")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Table(Name:="dbo.OrderLine")>  _
Partial Public Class OrderLine
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _OrderId As Integer
	
	Private _Id As Integer
	
	Private _Product As String
	
	Private _OrderLineDetails As EntitySet(Of OrderLineDetail)
	
	Private _Order As EntityRef(Of [Order])
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate()
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnOrderIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnOrderIdChanged()
    End Sub
    Partial Private Sub OnIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnIdChanged()
    End Sub
    Partial Private Sub OnProductChanging(value As String)
    End Sub
    Partial Private Sub OnProductChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
		Me._OrderLineDetails = New EntitySet(Of OrderLineDetail)(AddressOf Me.attach_OrderLineDetails, AddressOf Me.detach_OrderLineDetails)
		Me._Order = CType(Nothing, EntityRef(Of [Order]))
	End Sub
	
	<Column(Storage:="_OrderId", DbType:="Int NOT NULL", IsPrimaryKey:=true)>  _
	Public Property OrderId() As Integer
		Get
			Return Me._OrderId
		End Get
		Set
			If ((Me._OrderId = value)  _
						= false) Then
				If Me._Order.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException
				End If
				Me.OnOrderIdChanging(value)
				Me.SendPropertyChanging
				Me._OrderId = value
				Me.SendPropertyChanged("OrderId")
				Me.OnOrderIdChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Id", DbType:="Int NOT NULL", IsPrimaryKey:=true)>  _
	Public Property Id() As Integer
		Get
			Return Me._Id
		End Get
		Set
			If ((Me._Id = value)  _
						= false) Then
				Me.OnIdChanging(value)
				Me.SendPropertyChanging
				Me._Id = value
				Me.SendPropertyChanged("Id")
				Me.OnIdChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Product", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property Product() As String
		Get
			Return Me._Product
		End Get
		Set
			If ((Me._Product = value)  _
						= false) Then
				Me.OnProductChanging(value)
				Me.SendPropertyChanging
				Me._Product = value
				Me.SendPropertyChanged("Product")
				Me.OnProductChanged
			End If
		End Set
	End Property
	
	<Association(Name:="OrderLine_OrderLineDetail", Storage:="_OrderLineDetails", OtherKey:="OrderId,LineId")>  _
	Public Property OrderLineDetails() As EntitySet(Of OrderLineDetail)
		Get
			Return Me._OrderLineDetails
		End Get
		Set
			Me._OrderLineDetails.Assign(value)
		End Set
	End Property
	
	<Association(Name:="Order_OrderLine", Storage:="_Order", ThisKey:="OrderId", IsForeignKey:=true)>  _
	Public Property [Order]() As [Order]
		Get
			Return Me._Order.Entity
		End Get
		Set
			Dim previousValue As [Order] = Me._Order.Entity
			If (((previousValue Is value)  _
						= false)  _
						OrElse (Me._Order.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Order.Entity = Nothing
					previousValue.OrderLines.Remove(Me)
				End If
				Me._Order.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.OrderLines.Add(Me)
					Me._OrderId = value.Id
				Else
					Me._OrderId = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("[Order]")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_OrderLineDetails(ByVal entity As OrderLineDetail)
		Me.SendPropertyChanging
		entity.OrderLine = Me
		Me.SendPropertyChanged("OrderLineDetails")
	End Sub
	
	Private Sub detach_OrderLineDetails(ByVal entity As OrderLineDetail)
		Me.SendPropertyChanging
		entity.OrderLine = Nothing
		Me.SendPropertyChanged("OrderLineDetails")
	End Sub
End Class
