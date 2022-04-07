'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On


'Generation date: 19.05.2021 1:05:29
Namespace Namespace1
    ''' <summary>
    ''' There are no comments for EntityContainer in the schema.
    ''' </summary>
    Partial Public Class EntityContainer
        Inherits Global.Microsoft.OData.Client.DataServiceContext
        ''' <summary>
        ''' Initialize a new EntityContainer object.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")>  _
        Public Sub New(ByVal serviceRoot As Global.System.Uri)
            MyBase.New(serviceRoot, Global.Microsoft.OData.Client.ODataProtocolVersion.V4)
            Me.OnContextCreated
            Me.Format.LoadServiceModel = AddressOf GeneratedEdmModel.GetInstance
            Me.Format.UseJson()
        End Sub
        Partial Private Sub OnContextCreated()
        End Sub
        ''' <summary>
        ''' There are no comments for Products in the schema.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")>  _
        Public Overridable ReadOnly Property Products() As Global.Microsoft.OData.Client.DataServiceQuery(Of Product)
            Get
                If (Me._Products Is Nothing) Then
                    Me._Products = MyBase.CreateQuery(Of Product)("Products")
                End If
                Return Me._Products
            End Get
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")>  _
        Private _Products As Global.Microsoft.OData.Client.DataServiceQuery(Of Product)
        ''' <summary>
        ''' There are no comments for Products in the schema.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")>  _
        Public Overridable Sub AddToProducts(ByVal product As Product)
            MyBase.AddObject("Products", product)
        End Sub
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")>  _
        Private MustInherit Class GeneratedEdmModel
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")>  _
            Private Shared ParsedModel As Global.Microsoft.OData.Edm.IEdmModel = LoadModelFromString
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")>  _
            Private Const Edmx As String = "<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">" & _
 "  <edmx:DataServices>" & _
 "    <Schema Namespace=""Namespace1"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">" & _
 "      <EntityType Name=""Product"">" & _
 "        <Key>" & _
 "          <PropertyRef Name=""Id"" />" & _
 "        </Key>" & _
 "        <Property Name=""Id"" Type=""Edm.Int32"" Nullable=""false"" />" & _
 "        <Property Name=""Name"" Type=""Edm.String"" Nullable=""false"" />" & _
 "      </EntityType>" & _
 "      <Function Name=""GetProductTax"" IsBound=""true"">" & _
 "        <Parameter Name=""product"" Type=""Namespace1.Product"" />" & _
 "        <Parameter Name=""taxRate"" Type=""Edm.Double"" Nullable=""false"" />" & _
 "        <ReturnType Type=""Edm.Double"" />" & _
 "        <Annotation Term=""Org.OData.Core.V1.Revisions"">" & _
 "          <Collection>" & _
 "            <Record>" & _
 "              <PropertyValue Property=""Date"" Date=""2020-08-20"" />" & _
 "              <PropertyValue Property=""Version"" String=""2020-08/Tasks_And_Plans"" />" & _
 "              <PropertyValue Property=""Kind"" EnumMember=""Org.OData.Core.V1.RevisionKind/Deprecated"" />" & _
 "              <PropertyValue Property=""Description"" String=""The Service has deprecated the GetProductTax Function and will stop returning data on August 20, 2022."" />" & _
 "              <PropertyValue Property=""RemovalDate"" Date=""2022-08-20"" />" & _
 "            </Record>" & _
 "          </Collection>" & _
 "        </Annotation>" & _
 "      </Function>" & _
 "      <Action Name=""UpdateProductName"" IsBound=""true"">" & _
 "        <Parameter Name=""product"" Type=""Namespace1.Product"" />" & _
 "        <Parameter Name=""lastName"" Type=""Edm.String"" Nullable=""false"" Unicode=""false"" />" & _
 "        <ReturnType Type=""Namespace1.Product"" Nullable=""false"" />" & _
 "        <Annotation Term=""Org.OData.Core.V1.Revisions"">" & _
 "          <Collection>" & _
 "            <Record>" & _
 "              <PropertyValue Property=""Date"" Date=""2020-08-20"" />" & _
 "              <PropertyValue Property=""Version"" String=""2020-08/Tasks_And_Plans"" />" & _
 "              <PropertyValue Property=""Kind"" EnumMember=""Org.OData.Core.V1.RevisionKind/Deprecated"" />" & _
 "              <PropertyValue Property=""Description"" String=""The Service has deprecated the UpdateProductName Action and will stop returning data on August 20, 2022."" />" & _
 "              <PropertyValue Property=""RemovalDate"" Date=""2022-08-20"" />" & _
 "            </Record>" & _
 "          </Collection>" & _
 "        </Annotation>" & _
 "      </Action>" & _
 "      <EntityContainer Name=""EntityContainer"">" & _
 "        <EntitySet Name=""Products"" EntityType=""Namespace1.Product"" />" & _
 "      </EntityContainer>" & _
 "    </Schema>" & _
 "  </edmx:DataServices>" & _
 "</edmx:Edmx>"
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")>  _
            Public Shared Function GetInstance() As Global.Microsoft.OData.Edm.IEdmModel
                Return ParsedModel
            End Function
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")>  _
            Private Shared Function LoadModelFromString() As Global.Microsoft.OData.Edm.IEdmModel
                Dim reader As Global.System.Xml.XmlReader = CreateXmlReader(Edmx)
                Try
                    Dim errors As Global.System.Collections.Generic.IEnumerable(Of Global.Microsoft.OData.Edm.Validation.EdmError) = Nothing
                    Dim edmModel As Global.Microsoft.OData.Edm.IEdmModel = Nothing
                    If Not Global.Microsoft.OData.Edm.Csdl.CsdlReader.TryParse(reader, False, edmModel, errors) Then
                        Dim errorMessages As Global.System.Text.StringBuilder = New Global.System.Text.StringBuilder()
                        For Each err As Global.Microsoft.OData.Edm.Validation.EdmError In errors
                            errorMessages.Append(err.ErrorMessage)
                            errorMessages.Append("; ")
                        Next
                        Throw New Global.System.InvalidOperationException(errorMessages.ToString())
                    End If

                    Return edmModel
                Finally
                    CType(reader, Global.System.IDisposable).Dispose()
                End Try
            End Function
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")>  _
            Private Shared Function CreateXmlReader(ByVal edmxToParse As String) As Global.System.Xml.XmlReader
                Return Global.System.Xml.XmlReader.Create(New Global.System.IO.StringReader(edmxToParse))
            End Function
        End Class
    End Class
    ''' <summary>
    ''' There are no comments for ProductSingle in the schema.
    ''' </summary>
    Partial Public Class ProductSingle
        Inherits Global.Microsoft.OData.Client.DataServiceQuerySingle(Of Product)
        ''' <summary>
        ''' Initialize a new ProductSingle object.
        ''' </summary>
        Public Sub New(ByVal context As Global.Microsoft.OData.Client.DataServiceContext, ByVal path As String)
            MyBase.New(context, path)
        End Sub

        ''' <summary>
        ''' Initialize a new ProductSingle object.
        ''' </summary>
        Public Sub New(ByVal context As Global.Microsoft.OData.Client.DataServiceContext, ByVal path As String, ByVal isComposable As Boolean)
            MyBase.New(context, path, isComposable)
        End Sub

        ''' <summary>
        ''' Initialize a new ProductSingle object.
        ''' </summary>
        Public Sub New(ByVal query As Global.Microsoft.OData.Client.DataServiceQuerySingle(Of Product))
            MyBase.New(query)
        End Sub
    End Class
    ''' <summary>
    ''' There are no comments for Product in the schema.
    ''' </summary>
    ''' <KeyProperties>
    ''' Id
    ''' </KeyProperties>
    <Global.Microsoft.OData.Client.Key("Id")>  _
    Partial Public Class Product
        Inherits Global.Microsoft.OData.Client.BaseEntityType
        ''' <summary>
        ''' Create a new Product object.
        ''' </summary>
        ''' <param name="ID">Initial value of Id.</param>
        ''' <param name="name">Initial value of Name.</param>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")>  _
        Public Shared Function CreateProduct(ByVal ID As Integer, ByVal name As String) As Product
            Dim product As Product = New Product()
            product.Id = ID
            product.Name = name
            Return product
        End Function
        ''' <summary>
        ''' There are no comments for Property Id in the schema.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")>  _
        <Global.System.ComponentModel.DataAnnotations.RequiredAttribute()>  _
        Public Overridable Property Id() As Integer
            Get
                Return Me._Id
            End Get
            Set
                Me.OnIdChanging(value)
                Me._Id = value
                Me.OnIdChanged
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")>  _
        Private _Id As Integer
        Partial Private Sub OnIdChanging(ByVal value As Integer)
        End Sub
        Partial Private Sub OnIdChanged()
        End Sub
        ''' <summary>
        ''' There are no comments for Property Name in the schema.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")>  _
        <Global.System.ComponentModel.DataAnnotations.RequiredAttribute()>  _
        Public Overridable Property Name() As String
            Get
                Return Me._Name
            End Get
            Set
                Me.OnNameChanging(value)
                Me._Name = value
                Me.OnNameChanged
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")>  _
        Private _Name As String
        Partial Private Sub OnNameChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnNameChanged()
        End Sub
        ''' <summary>
        ''' There are no comments for GetProductTax in the schema.
        ''' </summary>
        <Global.System.ObsoleteAttribute("The Service has deprecated the GetProductTax Function and will stop returning data on August 20, 2022.")>  _
        Public Overridable Function GetProductTax(taxRate As Double) As Global.Microsoft.OData.Client.DataServiceQuerySingle(Of Global.System.Nullable(Of Double))
            Dim requestUri As Global.System.Uri = Nothing
            Context.TryGetUri(Me, requestUri)
            Return Me.Context.CreateFunctionQuerySingle(Of Global.System.Nullable(Of Double))(String.Join("/", Global.System.Linq.Enumerable.Select(Global.System.Linq.Enumerable.Skip(requestUri.Segments, Me.Context.BaseUri.Segments.Length), Function(s) s.Trim("/"C))), "/Namespace1.GetProductTax", False, New Global.Microsoft.OData.Client.UriOperationParameter("taxRate", taxRate))
        End Function
        ''' <summary>
        ''' There are no comments for UpdateProductName in the schema.
        ''' </summary>
        <Global.System.ObsoleteAttribute("The Service has deprecated the UpdateProductName Action and will stop returning data on August 20, 2022.")>  _
        Public Overridable Function UpdateProductName(lastName As String) As Global.Microsoft.OData.Client.DataServiceActionQuerySingle(Of Namespace1.Product)
            Dim resource As Global.Microsoft.OData.Client.EntityDescriptor = Context.EntityTracker.TryGetEntityDescriptor(Me)
            If resource Is Nothing Then
                Throw New Global.System.Exception("cannot find entity")
            End If

            Return New Global.Microsoft.OData.Client.DataServiceActionQuerySingle(Of Namespace1.Product)(Me.Context, resource.EditLink.OriginalString.Trim("/"C) + "/Namespace1.UpdateProductName", New Global.Microsoft.OData.Client.BodyOperationParameter("lastName", lastName))
        End Function
    End Class
    ''' <summary>
    ''' Class containing all extension methods
    ''' </summary>
    Public Module ExtensionMethods
        ''' <summary>
        ''' Get an entity of type Namespace1.Product as Namespace1.ProductSingle specified by key from an entity set
        ''' </summary>
        ''' <param name="_source">source entity set</param>
        ''' <param name="_keys">dictionary with the names and values of keys</param>
        <Global.System.Runtime.CompilerServices.Extension()>
        Public Function ByKey(ByVal _source As Global.Microsoft.OData.Client.DataServiceQuery(Of Namespace1.Product), ByVal _keys As Global.System.Collections.Generic.IDictionary(Of String, Object)) As Namespace1.ProductSingle
            Return New Namespace1.ProductSingle(_source.Context, _source.GetKeyPath(Global.Microsoft.OData.Client.Serializer.GetKeyString(_source.Context, _keys)))
        End Function
        ''' <summary>
        ''' Get an entity of type Namespace1.Product as Namespace1.ProductSingle specified by key from an entity set
        ''' </summary>
        ''' <param name="_source">source entity set</param>
        ''' <param name="id">The value of id</param>
        <Global.System.Runtime.CompilerServices.Extension()>
        Public Function ByKey(ByVal _source As Global.Microsoft.OData.Client.DataServiceQuery(Of Namespace1.Product),
            id As Integer) As Namespace1.ProductSingle
            Dim _keys As Global.System.Collections.Generic.IDictionary(Of String, Object) = New Global.System.Collections.Generic.Dictionary(Of String, Object)() From
            {
                { "Id", id }
            }
            Return New Namespace1.ProductSingle(_source.Context, _source.GetKeyPath(Global.Microsoft.OData.Client.Serializer.GetKeyString(_source.Context, _keys)))
        End Function
        ''' <summary>
        ''' There are no comments for GetProductTax in the schema.
        ''' </summary>
        <Global.System.Runtime.CompilerServices.Extension()>
        Public Function GetProductTax(ByVal _source As Global.Microsoft.OData.Client.DataServiceQuerySingle(Of Namespace1.Product), taxRate As Double) As Global.Microsoft.OData.Client.DataServiceQuerySingle(Of Global.System.Nullable(Of Double))
            If Not _source.IsComposable Then
                Throw New Global.System.NotSupportedException("The previous function is not composable.")
            End If

            Return _source.CreateFunctionQuerySingle(Of Global.System.Nullable(Of Double))("Namespace1.GetProductTax", False, New Global.Microsoft.OData.Client.UriOperationParameter("taxRate", taxRate))
        End Function
        ''' <summary>
        ''' There are no comments for UpdateProductName in the schema.
        ''' </summary>
        <Global.System.Runtime.CompilerServices.Extension()>
        Public Function UpdateProductName(ByVal _source As Global.Microsoft.OData.Client.DataServiceQuerySingle(Of Namespace1.Product), lastName As String) As Global.Microsoft.OData.Client.DataServiceActionQuerySingle(Of Namespace1.Product)
            If Not _source.IsComposable Then
                Throw New Global.System.NotSupportedException("The previous function is not composable.")
            End If
            Return New Global.Microsoft.OData.Client.DataServiceActionQuerySingle(Of Namespace1.Product)(_source.Context, _source.AppendRequestUri("Namespace1.UpdateProductName"), New Global.Microsoft.OData.Client.BodyOperationParameter("lastName", lastName))
        End Function
    End Module
End Namespace
