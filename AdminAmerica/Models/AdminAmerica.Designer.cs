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

namespace AdminAmerica.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class NBK455_homebasewebEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new NBK455_homebasewebEntities object using the connection string found in the 'NBK455_homebasewebEntities' section of the application configuration file.
        /// </summary>
        public NBK455_homebasewebEntities() : base("name=NBK455_homebasewebEntities", "NBK455_homebasewebEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new NBK455_homebasewebEntities object.
        /// </summary>
        public NBK455_homebasewebEntities(string connectionString) : base(connectionString, "NBK455_homebasewebEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new NBK455_homebasewebEntities object.
        /// </summary>
        public NBK455_homebasewebEntities(EntityConnection connection) : base(connection, "NBK455_homebasewebEntities")
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
        public ObjectSet<vspclient> vspclients
        {
            get
            {
                if ((_vspclients == null))
                {
                    _vspclients = base.CreateObjectSet<vspclient>("vspclients");
                }
                return _vspclients;
            }
        }
        private ObjectSet<vspclient> _vspclients;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the vspclients EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTovspclients(vspclient vspclient)
        {
            base.AddObject("vspclients", vspclient);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="NBK455_homebasewebModel", Name="vspclient")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class vspclient : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new vspclient object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        /// <param name="parent_id">Initial value of the parent_id property.</param>
        /// <param name="contactFirstName">Initial value of the ContactFirstName property.</param>
        /// <param name="contactLastName">Initial value of the ContactLastName property.</param>
        /// <param name="businessName">Initial value of the BusinessName property.</param>
        /// <param name="agent_id">Initial value of the agent_id property.</param>
        /// <param name="businessType">Initial value of the businessType property.</param>
        /// <param name="sICcode">Initial value of the SICcode property.</param>
        /// <param name="status">Initial value of the status property.</param>
        /// <param name="effectiveDate">Initial value of the effectiveDate property.</param>
        /// <param name="termDate">Initial value of the termDate property.</param>
        /// <param name="billingType_id">Initial value of the billingType_id property.</param>
        /// <param name="invoiceName">Initial value of the invoiceName property.</param>
        /// <param name="address">Initial value of the address property.</param>
        /// <param name="address2">Initial value of the address2 property.</param>
        /// <param name="city">Initial value of the city property.</param>
        /// <param name="state">Initial value of the state property.</param>
        /// <param name="zip">Initial value of the zip property.</param>
        /// <param name="phone">Initial value of the phone property.</param>
        /// <param name="email">Initial value of the email property.</param>
        /// <param name="phone2">Initial value of the phone2 property.</param>
        /// <param name="fax">Initial value of the fax property.</param>
        /// <param name="comments">Initial value of the comments property.</param>
        /// <param name="webURL">Initial value of the webURL property.</param>
        /// <param name="customField1">Initial value of the customField1 property.</param>
        /// <param name="customField2">Initial value of the customField2 property.</param>
        /// <param name="customField3">Initial value of the customField3 property.</param>
        /// <param name="customFieldNumeric">Initial value of the customFieldNumeric property.</param>
        /// <param name="eft">Initial value of the eft property.</param>
        public static vspclient Createvspclient(global::System.Int32 id, global::System.Int32 parent_id, global::System.String contactFirstName, global::System.String contactLastName, global::System.String businessName, global::System.Int32 agent_id, global::System.String businessType, global::System.String sICcode, global::System.String status, global::System.DateTime effectiveDate, global::System.DateTime termDate, global::System.Int32 billingType_id, global::System.String invoiceName, global::System.String address, global::System.String address2, global::System.String city, global::System.String state, global::System.String zip, global::System.String phone, global::System.String email, global::System.String phone2, global::System.String fax, global::System.String comments, global::System.String webURL, global::System.String customField1, global::System.String customField2, global::System.String customField3, global::System.Int32 customFieldNumeric, global::System.Boolean eft)
        {
            vspclient vspclient = new vspclient();
            vspclient.id = id;
            vspclient.parent_id = parent_id;
            vspclient.ContactFirstName = contactFirstName;
            vspclient.ContactLastName = contactLastName;
            vspclient.BusinessName = businessName;
            vspclient.agent_id = agent_id;
            vspclient.businessType = businessType;
            vspclient.SICcode = sICcode;
            vspclient.status = status;
            vspclient.effectiveDate = effectiveDate;
            vspclient.termDate = termDate;
            vspclient.billingType_id = billingType_id;
            vspclient.invoiceName = invoiceName;
            vspclient.address = address;
            vspclient.address2 = address2;
            vspclient.city = city;
            vspclient.state = state;
            vspclient.zip = zip;
            vspclient.phone = phone;
            vspclient.email = email;
            vspclient.phone2 = phone2;
            vspclient.fax = fax;
            vspclient.comments = comments;
            vspclient.webURL = webURL;
            vspclient.customField1 = customField1;
            vspclient.customField2 = customField2;
            vspclient.customField3 = customField3;
            vspclient.customFieldNumeric = customFieldNumeric;
            vspclient.eft = eft;
            return vspclient;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 parent_id
        {
            get
            {
                return _parent_id;
            }
            set
            {
                Onparent_idChanging(value);
                ReportPropertyChanging("parent_id");
                _parent_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("parent_id");
                Onparent_idChanged();
            }
        }
        private global::System.Int32 _parent_id;
        partial void Onparent_idChanging(global::System.Int32 value);
        partial void Onparent_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ContactFirstName
        {
            get
            {
                return _ContactFirstName;
            }
            set
            {
                OnContactFirstNameChanging(value);
                ReportPropertyChanging("ContactFirstName");
                _ContactFirstName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ContactFirstName");
                OnContactFirstNameChanged();
            }
        }
        private global::System.String _ContactFirstName;
        partial void OnContactFirstNameChanging(global::System.String value);
        partial void OnContactFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ContactLastName
        {
            get
            {
                return _ContactLastName;
            }
            set
            {
                OnContactLastNameChanging(value);
                ReportPropertyChanging("ContactLastName");
                _ContactLastName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ContactLastName");
                OnContactLastNameChanged();
            }
        }
        private global::System.String _ContactLastName;
        partial void OnContactLastNameChanging(global::System.String value);
        partial void OnContactLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String BusinessName
        {
            get
            {
                return _BusinessName;
            }
            set
            {
                OnBusinessNameChanging(value);
                ReportPropertyChanging("BusinessName");
                _BusinessName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("BusinessName");
                OnBusinessNameChanged();
            }
        }
        private global::System.String _BusinessName;
        partial void OnBusinessNameChanging(global::System.String value);
        partial void OnBusinessNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 agent_id
        {
            get
            {
                return _agent_id;
            }
            set
            {
                Onagent_idChanging(value);
                ReportPropertyChanging("agent_id");
                _agent_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("agent_id");
                Onagent_idChanged();
            }
        }
        private global::System.Int32 _agent_id;
        partial void Onagent_idChanging(global::System.Int32 value);
        partial void Onagent_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String businessType
        {
            get
            {
                return _businessType;
            }
            set
            {
                OnbusinessTypeChanging(value);
                ReportPropertyChanging("businessType");
                _businessType = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("businessType");
                OnbusinessTypeChanged();
            }
        }
        private global::System.String _businessType;
        partial void OnbusinessTypeChanging(global::System.String value);
        partial void OnbusinessTypeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String SICcode
        {
            get
            {
                return _SICcode;
            }
            set
            {
                OnSICcodeChanging(value);
                ReportPropertyChanging("SICcode");
                _SICcode = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("SICcode");
                OnSICcodeChanged();
            }
        }
        private global::System.String _SICcode;
        partial void OnSICcodeChanging(global::System.String value);
        partial void OnSICcodeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String status
        {
            get
            {
                return _status;
            }
            set
            {
                OnstatusChanging(value);
                ReportPropertyChanging("status");
                _status = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("status");
                OnstatusChanged();
            }
        }
        private global::System.String _status;
        partial void OnstatusChanging(global::System.String value);
        partial void OnstatusChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime effectiveDate
        {
            get
            {
                return _effectiveDate;
            }
            set
            {
                OneffectiveDateChanging(value);
                ReportPropertyChanging("effectiveDate");
                _effectiveDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("effectiveDate");
                OneffectiveDateChanged();
            }
        }
        private global::System.DateTime _effectiveDate;
        partial void OneffectiveDateChanging(global::System.DateTime value);
        partial void OneffectiveDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime termDate
        {
            get
            {
                return _termDate;
            }
            set
            {
                OntermDateChanging(value);
                ReportPropertyChanging("termDate");
                _termDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("termDate");
                OntermDateChanged();
            }
        }
        private global::System.DateTime _termDate;
        partial void OntermDateChanging(global::System.DateTime value);
        partial void OntermDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 billingType_id
        {
            get
            {
                return _billingType_id;
            }
            set
            {
                OnbillingType_idChanging(value);
                ReportPropertyChanging("billingType_id");
                _billingType_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("billingType_id");
                OnbillingType_idChanged();
            }
        }
        private global::System.Int32 _billingType_id;
        partial void OnbillingType_idChanging(global::System.Int32 value);
        partial void OnbillingType_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String invoiceName
        {
            get
            {
                return _invoiceName;
            }
            set
            {
                OninvoiceNameChanging(value);
                ReportPropertyChanging("invoiceName");
                _invoiceName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("invoiceName");
                OninvoiceNameChanged();
            }
        }
        private global::System.String _invoiceName;
        partial void OninvoiceNameChanging(global::System.String value);
        partial void OninvoiceNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String address
        {
            get
            {
                return _address;
            }
            set
            {
                OnaddressChanging(value);
                ReportPropertyChanging("address");
                _address = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("address");
                OnaddressChanged();
            }
        }
        private global::System.String _address;
        partial void OnaddressChanging(global::System.String value);
        partial void OnaddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String address2
        {
            get
            {
                return _address2;
            }
            set
            {
                Onaddress2Changing(value);
                ReportPropertyChanging("address2");
                _address2 = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("address2");
                Onaddress2Changed();
            }
        }
        private global::System.String _address2;
        partial void Onaddress2Changing(global::System.String value);
        partial void Onaddress2Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String city
        {
            get
            {
                return _city;
            }
            set
            {
                OncityChanging(value);
                ReportPropertyChanging("city");
                _city = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("city");
                OncityChanged();
            }
        }
        private global::System.String _city;
        partial void OncityChanging(global::System.String value);
        partial void OncityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String state
        {
            get
            {
                return _state;
            }
            set
            {
                OnstateChanging(value);
                ReportPropertyChanging("state");
                _state = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("state");
                OnstateChanged();
            }
        }
        private global::System.String _state;
        partial void OnstateChanging(global::System.String value);
        partial void OnstateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String zip
        {
            get
            {
                return _zip;
            }
            set
            {
                OnzipChanging(value);
                ReportPropertyChanging("zip");
                _zip = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("zip");
                OnzipChanged();
            }
        }
        private global::System.String _zip;
        partial void OnzipChanging(global::System.String value);
        partial void OnzipChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String phone
        {
            get
            {
                return _phone;
            }
            set
            {
                OnphoneChanging(value);
                ReportPropertyChanging("phone");
                _phone = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("phone");
                OnphoneChanged();
            }
        }
        private global::System.String _phone;
        partial void OnphoneChanging(global::System.String value);
        partial void OnphoneChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String email
        {
            get
            {
                return _email;
            }
            set
            {
                OnemailChanging(value);
                ReportPropertyChanging("email");
                _email = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("email");
                OnemailChanged();
            }
        }
        private global::System.String _email;
        partial void OnemailChanging(global::System.String value);
        partial void OnemailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String phone2
        {
            get
            {
                return _phone2;
            }
            set
            {
                Onphone2Changing(value);
                ReportPropertyChanging("phone2");
                _phone2 = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("phone2");
                Onphone2Changed();
            }
        }
        private global::System.String _phone2;
        partial void Onphone2Changing(global::System.String value);
        partial void Onphone2Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String fax
        {
            get
            {
                return _fax;
            }
            set
            {
                OnfaxChanging(value);
                ReportPropertyChanging("fax");
                _fax = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("fax");
                OnfaxChanged();
            }
        }
        private global::System.String _fax;
        partial void OnfaxChanging(global::System.String value);
        partial void OnfaxChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String comments
        {
            get
            {
                return _comments;
            }
            set
            {
                OncommentsChanging(value);
                ReportPropertyChanging("comments");
                _comments = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("comments");
                OncommentsChanged();
            }
        }
        private global::System.String _comments;
        partial void OncommentsChanging(global::System.String value);
        partial void OncommentsChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String webURL
        {
            get
            {
                return _webURL;
            }
            set
            {
                OnwebURLChanging(value);
                ReportPropertyChanging("webURL");
                _webURL = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("webURL");
                OnwebURLChanged();
            }
        }
        private global::System.String _webURL;
        partial void OnwebURLChanging(global::System.String value);
        partial void OnwebURLChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String customField1
        {
            get
            {
                return _customField1;
            }
            set
            {
                OncustomField1Changing(value);
                ReportPropertyChanging("customField1");
                _customField1 = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("customField1");
                OncustomField1Changed();
            }
        }
        private global::System.String _customField1;
        partial void OncustomField1Changing(global::System.String value);
        partial void OncustomField1Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String customField2
        {
            get
            {
                return _customField2;
            }
            set
            {
                OncustomField2Changing(value);
                ReportPropertyChanging("customField2");
                _customField2 = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("customField2");
                OncustomField2Changed();
            }
        }
        private global::System.String _customField2;
        partial void OncustomField2Changing(global::System.String value);
        partial void OncustomField2Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String customField3
        {
            get
            {
                return _customField3;
            }
            set
            {
                OncustomField3Changing(value);
                ReportPropertyChanging("customField3");
                _customField3 = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("customField3");
                OncustomField3Changed();
            }
        }
        private global::System.String _customField3;
        partial void OncustomField3Changing(global::System.String value);
        partial void OncustomField3Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 customFieldNumeric
        {
            get
            {
                return _customFieldNumeric;
            }
            set
            {
                OncustomFieldNumericChanging(value);
                ReportPropertyChanging("customFieldNumeric");
                _customFieldNumeric = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("customFieldNumeric");
                OncustomFieldNumericChanged();
            }
        }
        private global::System.Int32 _customFieldNumeric;
        partial void OncustomFieldNumericChanging(global::System.Int32 value);
        partial void OncustomFieldNumericChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean eft
        {
            get
            {
                return _eft;
            }
            set
            {
                OneftChanging(value);
                ReportPropertyChanging("eft");
                _eft = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("eft");
                OneftChanged();
            }
        }
        private global::System.Boolean _eft;
        partial void OneftChanging(global::System.Boolean value);
        partial void OneftChanged();

        #endregion
    
    }

    #endregion
    
}
