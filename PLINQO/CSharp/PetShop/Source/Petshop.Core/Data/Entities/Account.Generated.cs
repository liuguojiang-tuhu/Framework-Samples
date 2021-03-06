﻿#pragma warning disable 1591
#pragma warning disable 0414        
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

namespace PetShop.Core.Data
{
    /// <summary>
    /// The class representing the dbo.Account table.
    /// </summary>
    [System.Data.Linq.Mapping.Table(Name="dbo.Account")]
    [System.Runtime.Serialization.DataContract(IsReference = true)]
    [System.ComponentModel.DataAnnotations.ScaffoldTable(true)]
    [System.ComponentModel.DataAnnotations.MetadataType(typeof(PetShop.Core.Data.Account.Metadata))]
    [System.Data.Services.Common.DataServiceKey("AccountId")]
    [System.Diagnostics.DebuggerDisplay("AccountId: {AccountId}")]
    public partial class Account
        : LinqEntityBase, ICloneable 
    {
        #region Static Constructor
        /// <summary>
        /// Initializes the <see cref="Account"/> class.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        static Account()
        {
            AddSharedRules();
        }
        #endregion

        #region Default Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public Account()
        {
            Initialize();
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private void Initialize()
        {
            _profile = default(System.Data.Linq.EntityRef<Profile>);
            OnCreated();
        }
        #endregion

        #region Column Mapped Properties

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private int _uniqueID;

        /// <summary>
        /// Gets or sets the UniqueID column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "UniqueID", Storage = "_uniqueID", DbType = "int NOT NULL", CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 1)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public int UniqueID
        {
            get { return _uniqueID; }
            set
            {
                if (_uniqueID != value)
                {
                    if (_profile.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    OnUniqueIDChanging(value);
                    SendPropertyChanging("UniqueID");
                    _uniqueID = value;
                    SendPropertyChanged("UniqueID");
                    OnUniqueIDChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _email;

        /// <summary>
        /// Gets or sets the Email column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Email", Storage = "_email", DbType = "varchar(80) NOT NULL", CanBeNull = false)]
        [System.ComponentModel.DataAnnotations.StringLength(80)]
        [System.Runtime.Serialization.DataMember(Order = 2)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string Email
        {
            get { return _email; }
            set
            {
                if (_email != value)
                {
                    OnEmailChanging(value);
                    SendPropertyChanging("Email");
                    _email = value;
                    SendPropertyChanged("Email");
                    OnEmailChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _firstName;

        /// <summary>
        /// Gets or sets the FirstName column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "FirstName", Storage = "_firstName", DbType = "varchar(80) NOT NULL", CanBeNull = false)]
        [System.ComponentModel.DataAnnotations.StringLength(80)]
        [System.Runtime.Serialization.DataMember(Order = 3)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName != value)
                {
                    OnFirstNameChanging(value);
                    SendPropertyChanging("FirstName");
                    _firstName = value;
                    SendPropertyChanged("FirstName");
                    OnFirstNameChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _lastName;

        /// <summary>
        /// Gets or sets the LastName column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "LastName", Storage = "_lastName", DbType = "varchar(80) NOT NULL", CanBeNull = false)]
        [System.ComponentModel.DataAnnotations.StringLength(80)]
        [System.Runtime.Serialization.DataMember(Order = 4)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName != value)
                {
                    OnLastNameChanging(value);
                    SendPropertyChanging("LastName");
                    _lastName = value;
                    SendPropertyChanged("LastName");
                    OnLastNameChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _address1;

        /// <summary>
        /// Gets or sets the Address1 column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Address1", Storage = "_address1", DbType = "varchar(80) NOT NULL", CanBeNull = false)]
        [System.ComponentModel.DataAnnotations.StringLength(80)]
        [System.Runtime.Serialization.DataMember(Order = 5)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string Address1
        {
            get { return _address1; }
            set
            {
                if (_address1 != value)
                {
                    OnAddress1Changing(value);
                    SendPropertyChanging("Address1");
                    _address1 = value;
                    SendPropertyChanged("Address1");
                    OnAddress1Changed();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _address2;

        /// <summary>
        /// Gets or sets the Address2 column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Address2", Storage = "_address2", DbType = "varchar(80)")]
        [System.ComponentModel.DataAnnotations.StringLength(80)]
        [System.Runtime.Serialization.DataMember(Order = 6)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string Address2
        {
            get { return _address2; }
            set
            {
                if (_address2 != value)
                {
                    OnAddress2Changing(value);
                    SendPropertyChanging("Address2");
                    _address2 = value;
                    SendPropertyChanged("Address2");
                    OnAddress2Changed();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _city;

        /// <summary>
        /// Gets or sets the City column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "City", Storage = "_city", DbType = "varchar(80) NOT NULL", CanBeNull = false)]
        [System.ComponentModel.DataAnnotations.StringLength(80)]
        [System.Runtime.Serialization.DataMember(Order = 7)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string City
        {
            get { return _city; }
            set
            {
                if (_city != value)
                {
                    OnCityChanging(value);
                    SendPropertyChanging("City");
                    _city = value;
                    SendPropertyChanged("City");
                    OnCityChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _state;

        /// <summary>
        /// Gets or sets the State column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "State", Storage = "_state", DbType = "varchar(80) NOT NULL", CanBeNull = false)]
        [System.ComponentModel.DataAnnotations.StringLength(80)]
        [System.Runtime.Serialization.DataMember(Order = 8)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string State
        {
            get { return _state; }
            set
            {
                if (_state != value)
                {
                    OnStateChanging(value);
                    SendPropertyChanging("State");
                    _state = value;
                    SendPropertyChanged("State");
                    OnStateChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _zip;

        /// <summary>
        /// Gets or sets the Zip column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Zip", Storage = "_zip", DbType = "varchar(20) NOT NULL", CanBeNull = false)]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        [System.Runtime.Serialization.DataMember(Order = 9)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string Zip
        {
            get { return _zip; }
            set
            {
                if (_zip != value)
                {
                    OnZipChanging(value);
                    SendPropertyChanging("Zip");
                    _zip = value;
                    SendPropertyChanged("Zip");
                    OnZipChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _country;

        /// <summary>
        /// Gets or sets the Country column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Country", Storage = "_country", DbType = "varchar(20) NOT NULL", CanBeNull = false)]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        [System.Runtime.Serialization.DataMember(Order = 10)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string Country
        {
            get { return _country; }
            set
            {
                if (_country != value)
                {
                    OnCountryChanging(value);
                    SendPropertyChanging("Country");
                    _country = value;
                    SendPropertyChanged("Country");
                    OnCountryChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _phone;

        /// <summary>
        /// Gets or sets the Phone column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Phone", Storage = "_phone", DbType = "varchar(20)")]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        [System.Runtime.Serialization.DataMember(Order = 11)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string Phone
        {
            get { return _phone; }
            set
            {
                if (_phone != value)
                {
                    OnPhoneChanging(value);
                    SendPropertyChanging("Phone");
                    _phone = value;
                    SendPropertyChanged("Phone");
                    OnPhoneChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private int _accountId = default(int);

        /// <summary>
        /// Gets the AccountId column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "AccountId", Storage = "_accountId", DbType = "int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 12)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public int AccountId
        {
            get { return _accountId; }
            set
            {
                if (_accountId != value)
                {
                    OnAccountIdChanging(value);
                    SendPropertyChanging("AccountId");
                    _accountId = value;
                    SendPropertyChanged("AccountId");
                    OnAccountIdChanged();
                }
            }
        }
        #endregion

        #region Association Mapped Properties

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.Data.Linq.EntityRef<Profile> _profile;

        /// <summary>
        /// Gets or sets the <see cref="Profile"/> association.
        /// </summary>
        [System.Data.Linq.Mapping.Association(Name = "Profile_Account", Storage = "_profile", ThisKey = "UniqueID", OtherKey = "UniqueID", IsForeignKey = true, DeleteRule = "CASCADE")]
        [System.Runtime.Serialization.DataMember(Order = 13, EmitDefaultValue = false)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public Profile Profile
        {
            get { return (serializing && !_profile.HasLoadedOrAssignedValue) ? null : _profile.Entity; }
            set
            {
                Profile previousValue = _profile.Entity;
                if (previousValue != value || _profile.HasLoadedOrAssignedValue == false)
                {
                    OnProfileChanging(value);
                    SendPropertyChanging("Profile");
                    if (previousValue != null)
                    {
                        _profile.Entity = null;
                        previousValue.AccountList.Remove(this);
                    }
                    _profile.Entity = value;
                    if (value != null)
                    {
                        value.AccountList.Add(this);
                        _uniqueID = value.UniqueID;
                    }
                    else
                    {
                        _uniqueID = default(int);
                    }
                    SendPropertyChanged("Profile");
                    OnProfileChanged();
                }
            }
        }
        
        
        
        #endregion

        #region Extensibility Method Definitions
        /// <summary>Called by the static constructor to add shared rules.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        static partial void AddSharedRules();
        /// <summary>Called when this instance is loaded.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnLoaded();
        /// <summary>Called when this instance is being saved.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        /// <summary>Called when this instance is created.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnCreated();
        /// <summary>Called when <see cref="UniqueID"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnUniqueIDChanging(int value);
        /// <summary>Called after <see cref="UniqueID"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnUniqueIDChanged();
        /// <summary>Called when <see cref="Email"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnEmailChanging(string value);
        /// <summary>Called after <see cref="Email"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnEmailChanged();
        /// <summary>Called when <see cref="FirstName"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnFirstNameChanging(string value);
        /// <summary>Called after <see cref="FirstName"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnFirstNameChanged();
        /// <summary>Called when <see cref="LastName"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnLastNameChanging(string value);
        /// <summary>Called after <see cref="LastName"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnLastNameChanged();
        /// <summary>Called when <see cref="Address1"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnAddress1Changing(string value);
        /// <summary>Called after <see cref="Address1"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnAddress1Changed();
        /// <summary>Called when <see cref="Address2"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnAddress2Changing(string value);
        /// <summary>Called after <see cref="Address2"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnAddress2Changed();
        /// <summary>Called when <see cref="City"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnCityChanging(string value);
        /// <summary>Called after <see cref="City"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnCityChanged();
        /// <summary>Called when <see cref="State"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnStateChanging(string value);
        /// <summary>Called after <see cref="State"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnStateChanged();
        /// <summary>Called when <see cref="Zip"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnZipChanging(string value);
        /// <summary>Called after <see cref="Zip"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnZipChanged();
        /// <summary>Called when <see cref="Country"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnCountryChanging(string value);
        /// <summary>Called after <see cref="Country"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnCountryChanged();
        /// <summary>Called when <see cref="Phone"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnPhoneChanging(string value);
        /// <summary>Called after <see cref="Phone"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnPhoneChanged();
        /// <summary>Called when <see cref="AccountId"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnAccountIdChanging(int value);
        /// <summary>Called after <see cref="AccountId"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnAccountIdChanged();
        /// <summary>Called when <see cref="Profile"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnProfileChanging(Profile value);
        /// <summary>Called after <see cref="Profile"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnProfileChanged();

        #endregion

        #region Serialization
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private bool serializing;

        /// <summary>
        /// Called when serializing.
        /// </summary>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        [System.Runtime.Serialization.OnSerializing]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public void OnSerializing(System.Runtime.Serialization.StreamingContext context) {
            serializing = true;
        }

        /// <summary>
        /// Called when serialized.
        /// </summary>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        [System.Runtime.Serialization.OnSerialized]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public void OnSerialized(System.Runtime.Serialization.StreamingContext context) {
            serializing = false;
        }

        /// <summary>
        /// Called when deserializing.
        /// </summary>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        [System.Runtime.Serialization.OnDeserializing]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public void OnDeserializing(System.Runtime.Serialization.StreamingContext context) {
            Initialize();
        }

        /// <summary>
        /// Deserializes an instance of <see cref="Account"/> from XML.
        /// </summary>
        /// <param name="xml">The XML string representing a <see cref="Account"/> instance.</param>
        /// <returns>An instance of <see cref="Account"/> that is deserialized from the XML string.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static Account FromXml(string xml)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Account));

            using (var sr = new System.IO.StringReader(xml))
            using (var reader = System.Xml.XmlReader.Create(sr))
            {
                return deserializer.ReadObject(reader) as Account;
            }
        }

        /// <summary>
        /// Deserializes an instance of <see cref="Account"/> from a byte array.
        /// </summary>
        /// <param name="buffer">The byte array representing a <see cref="Account"/> instance.</param>
        /// <returns>An instance of <see cref="Account"/> that is deserialized from the byte array.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static Account FromBinary(byte[] buffer)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Account));

            using (var ms = new System.IO.MemoryStream(buffer))
            using (var reader = System.Xml.XmlDictionaryReader.CreateBinaryReader(ms, System.Xml.XmlDictionaryReaderQuotas.Max))
            {
                return deserializer.ReadObject(reader) as Account;
            }
        }
        
        #endregion

        #region Clone
        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        object ICloneable.Clone()
        {
            var serializer = new System.Runtime.Serialization.DataContractSerializer(GetType());
            using (var ms = new System.IO.MemoryStream())
            {
                serializer.WriteObject(ms, this);
                ms.Position = 0;
                return serializer.ReadObject(ms);
            }
        }

        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        /// <remarks>
        /// Only loaded <see cref="T:System.Data.Linq.EntityRef`1"/> and <see cref="T:System.Data.Linq.EntitySet`1" /> child accessions will be cloned.
        /// </remarks>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public Account Clone()
        {
            return (Account)((ICloneable)this).Clone();
        }
        #endregion

        #region Detach Methods
        /// <summary>
        /// Detach this instance from the <see cref="System.Data.Linq.DataContext"/>.
        /// </summary>
        /// <remarks>
        /// Detaching the entity will stop all lazy loading and allow it to be added to another <see cref="System.Data.Linq.DataContext"/>.
        /// </remarks>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public override void Detach()
        {
            if (!IsAttached())
                return;

            base.Detach();
            _profile = Detach(_profile);
        }
        #endregion
    }
}
#pragma warning restore 1591
#pragma warning restore 0414

