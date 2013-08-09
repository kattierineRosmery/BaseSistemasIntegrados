﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace datos.ActivoFijo
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class PruebaEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new PruebaEntities object using the connection string found in the 'PruebaEntities' section of the application configuration file.
        /// </summary>
        public PruebaEntities() : base("name=PruebaEntities", "PruebaEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new PruebaEntities object.
        /// </summary>
        public PruebaEntities(string connectionString) : base(connectionString, "PruebaEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new PruebaEntities object.
        /// </summary>
        public PruebaEntities(EntityConnection connection) : base(connection, "PruebaEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<AbPrueba> AbPrueba
        {
            get
            {
                if ((_AbPrueba == null))
                {
                    _AbPrueba = base.CreateObjectSet<AbPrueba>("AbPrueba");
                }
                return _AbPrueba;
            }
        }
        private ObjectSet<AbPrueba> _AbPrueba;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the AbPrueba EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToAbPrueba(AbPrueba abPrueba)
        {
            base.AddObject("AbPrueba", abPrueba);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="PruebaModel", Name="AbPrueba")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class AbPrueba : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new AbPrueba object.
        /// </summary>
        /// <param name="codigo">Initial value of the codigo property.</param>
        public static AbPrueba CreateAbPrueba(global::System.Int32 codigo)
        {
            AbPrueba abPrueba = new AbPrueba();
            abPrueba.codigo = codigo;
            return abPrueba;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 codigo
        {
            get
            {
                return _codigo;
            }
            set
            {
                if (_codigo != value)
                {
                    OncodigoChanging(value);
                    ReportPropertyChanging("codigo");
                    _codigo = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("codigo");
                    OncodigoChanged();
                }
            }
        }
        private global::System.Int32 _codigo;
        partial void OncodigoChanging(global::System.Int32 value);
        partial void OncodigoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                OnnombreChanging(value);
                ReportPropertyChanging("nombre");
                _nombre = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("nombre");
                OnnombreChanged();
            }
        }
        private global::System.String _nombre;
        partial void OnnombreChanging(global::System.String value);
        partial void OnnombreChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String descripcion
        {
            get
            {
                return _descripcion;
            }
            set
            {
                OndescripcionChanging(value);
                ReportPropertyChanging("descripcion");
                _descripcion = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("descripcion");
                OndescripcionChanged();
            }
        }
        private global::System.String _descripcion;
        partial void OndescripcionChanging(global::System.String value);
        partial void OndescripcionChanged();

        #endregion
    
    }

    #endregion
    
}