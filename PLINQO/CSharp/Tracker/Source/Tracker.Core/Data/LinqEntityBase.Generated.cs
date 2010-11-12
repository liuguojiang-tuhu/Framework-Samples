﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.Linq;

namespace Tracker.Core.Data
{
    /// <summary>
    /// A base class for Linq entities that implements notification events.
    /// </summary>
    [System.Runtime.Serialization.DataContract(IsReference = true)]
    public abstract partial class LinqEntityBase :
        CodeSmith.Data.ILinqEntity,
        System.ComponentModel.INotifyPropertyChanging,
        System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinqEntityBase"/> class.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        protected LinqEntityBase()
        { }

        #region Notification Events

        /// <summary>
        /// Implements a PropertyChanged event.
        /// </summary>
        [field: NonSerialized]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raise the PropertyChanged event for a specific property.
        /// </summary>
        /// <param name="propertyName">Name of the property that has changed.</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        protected virtual void SendPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Implements a PropertyChanging event.
        /// </summary>
        [field: NonSerialized]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        /// <summary>
        /// Raise the PropertyChanging event for a specific property.
        /// </summary>
        /// <param name="propertyName">Name of the property that is changing.</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        protected virtual void SendPropertyChanging(string propertyName)
        {
            if (PropertyChanging != null)
                PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
            
        }
        #endregion
        
        #region Detach Methods
        /// <summary>
        /// Gets a value indicating whether this instance is attached to the change tracking of <see cref="System.Data.Linq.DataContext"/>.
        /// </summary>
        /// <returns>
        /// <c>true</c> if this instance is attached; otherwise, <c>false</c>.
        /// </returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public bool IsAttached()
        {
            return PropertyChanging != null;
        }
        
        /// <summary>
        /// Detach this instance from the <see cref="System.Data.Linq.DataContext"/>.
        /// </summary>
        /// <remarks>
        /// Detaching the entity will allow it to be attached to another <see cref="System.Data.Linq.DataContext"/>.
        /// </remarks>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual void Detach()
        {
            PropertyChanging = null;
            PropertyChanged = null;
        }
        
        /// <summary>
        /// Detach the specified <see cref="T:System.Data.Linq.EntitySet`1" />.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="set">The <see cref="T:System.Data.Linq.EntitySet`1" /> to detach.</param>
        /// <param name="onAdd">Delegate for <see cref="M:System.Data.Linq.EntitySet`1.Add(`0)" />.</param>
        /// <param name="onRemove">Delegate for <see cref="M:System.Data.Linq.EntitySet`1.Remove(`0)" />.</param>
        /// <returns>A new <see cref="T:System.Data.Linq.EntitySet`1" /> with the list copied if it was loaded.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        protected static System.Data.Linq.EntitySet<TEntity> Detach<TEntity>(System.Data.Linq.EntitySet<TEntity> set, Action<TEntity> onAdd, Action<TEntity> onRemove) 
            where TEntity : LinqEntityBase
        {
            if (set == null || !set.HasLoadedOrAssignedValues)
                return new System.Data.Linq.EntitySet<TEntity>(onAdd, onRemove);

            // copy list and detach all entities
            var list = set.ToList();
            list.ForEach(t => t.Detach());

            var newSet = new System.Data.Linq.EntitySet<TEntity>(onAdd, onRemove);
            newSet.Assign(list);
            return newSet;
        }

        /// <summary>
        /// Detach the specified <see cref="T:System.Data.Linq.EntityRef`1"/>.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="entity">The <see cref="T:System.Data.Linq.EntityRef`1"/> to detach.</param>
        /// <returns>A new <see cref="T:System.Data.Linq.EntityRef`1"/> with the entity detached.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        protected static System.Data.Linq.EntityRef<TEntity> Detach<TEntity>(System.Data.Linq.EntityRef<TEntity> entity) 
            where TEntity : LinqEntityBase
        {
            if (!entity.HasLoadedOrAssignedValue || entity.Entity == null)
                return new System.Data.Linq.EntityRef<TEntity>();

            entity.Entity.Detach();
            return new System.Data.Linq.EntityRef<TEntity>(entity.Entity);
        }
        
        /// <summary>
        /// Detach the specified lazy loaded value.
        /// </summary>
        /// <typeparam name="T">The type of the value.</typeparam>
        /// <param name="value">The lazy loaded value.</param>
        /// <returns>A new <see cref="T:System.Data.Linq.Link`1"/> that is detached.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        protected static System.Data.Linq.Link<T> Detach<T>(System.Data.Linq.Link<T> value)
        {
            if (!value.HasLoadedOrAssignedValue)
                return default(System.Data.Linq.Link<T>);

            return new System.Data.Linq.Link<T>(value.Value);
        }
        #endregion

        #region ToString()
        
        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <param name="indentLevel">The indent level.</param>
        /// <param name="indentValue">The indent value.</param>
        /// <returns>
        /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public string ToEntityString(int indentLevel, string indentValue)
        {
            System.Reflection.PropertyInfo[] props = this.GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            var sb = new System.Text.StringBuilder();
            object value = null;
            bool includeProperty = true;

            for (int t = 0; t < indentLevel; t++)
                sb.Append(indentValue);

            sb.AppendLine("{");

            for (int i = 0; i < props.Length; i++)
            {
                value = null;

                if (props[i].PropertyType == typeof(byte[])
                    || props[i].PropertyType == typeof(System.Data.Linq.Binary))
                {
                    value = "<binary>";
                }
                else if (props[i].PropertyType == typeof(System.Data.Linq.EntitySet<>)
                    || props[i].PropertyType.BaseType == typeof(LinqEntityBase))
                {
                    includeProperty = false;
                }
                else
                {
                    try
                    {
                        value = props[i].GetValue(this, null);
                    }
                    catch (Exception)
                    {
                        value = "<exception>";
                    }
                }

                if (includeProperty)
                {
                    if (value != null)
                        value = value.ToString().Replace("\r\n", " ").Replace('\n', ' ').Replace('\t', ' ');

                    if (value != null && value.ToString().Length > 50)
                        value = String.Concat(value.ToString().Substring(0, 50), "...");

                    for (int t = 0; t < indentLevel + 1; t++)
                        sb.Append(indentValue);

                    sb.Append(props[i].Name);
                    sb.Append(" = ");

                    sb.AppendLine(value != null ? value.ToString().Length > 0 ? value.ToString() : "<empty>" : "<null>");
                }
            }

            for (int t = 0; t < indentLevel; t++)
                sb.Append(indentValue);

            sb.AppendLine("}");

            return sb.ToString();
        }

        /// <summary>
        /// Returns an XML <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>. 
        /// </summary>
        /// <returns>An XML <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public string ToXml()
        {
            var settings = new System.Xml.XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;

            var sb = new System.Text.StringBuilder();
            using (var writer = System.Xml.XmlWriter.Create(sb, settings))
            {
                var serializer = new System.Runtime.Serialization.DataContractSerializer(GetType());
                serializer.WriteObject(writer, this);
                writer.Flush();
            }

            return sb.ToString();
        }

        /// <summary>
        /// Returns a byte array that represents the current <see cref="T:System.Object"/>. 
        /// </summary>
        /// <returns>A byte array that represents the current <see cref="T:System.Object"/>.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public byte[] ToBinary()
        {
            byte[] buffer;
            using (var ms = new System.IO.MemoryStream())
            using (var writer = System.Xml.XmlDictionaryWriter.CreateBinaryWriter(ms))
            {
                var serializer = new System.Runtime.Serialization.DataContractSerializer(GetType());
                serializer.WriteObject(writer, this);
                writer.Flush();
                buffer = ms.ToArray();
            }
            return buffer;
        }

        #endregion
    }
}
#pragma warning restore 1591

