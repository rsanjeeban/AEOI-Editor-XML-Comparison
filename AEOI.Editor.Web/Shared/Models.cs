using System;
using System.ComponentModel;
using System.Xml.Serialization;
namespace AEOI.Editor.Web.Shared
{

        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Report
    {

        private ushort customerIdField;

        private string nameField;

        private string agreementField;

        private string modeField;

        private System.DateTime requestedOnField;

        private ReportPeriod periodField;

        private ReportExtensions extensionsField;

        private ReportReportData reportDataField;

        private string ruleField;

        /// <remarks/>
        public ushort CustomerId
        {
            get
            {
                return this.customerIdField;
            }
            set
            {
                this.customerIdField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string Agreement
        {
            get
            {
                return this.agreementField;
            }
            set
            {
                this.agreementField = value;
            }
        }

        /// <remarks/>
        public string Mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime RequestedOn
        {
            get
            {
                return this.requestedOnField;
            }
            set
            {
                this.requestedOnField = value;
            }
        }

        /// <remarks/>
        public ReportPeriod Period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }

        /// <remarks/>
        public ReportExtensions Extensions
        {
            get
            {
                return this.extensionsField;
            }
            set
            {
                this.extensionsField = value;
            }
        }

        /// <remarks/>
        public ReportReportData ReportData
        {
            get
            {
                return this.reportDataField;
            }
            set
            {
                this.reportDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rule
        {
            get
            {
                return this.ruleField;
            }
            set
            {
                this.ruleField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ReportPeriod
    {

        private System.DateTime startField;

        private System.DateTime endField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime end
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ReportExtensions
    {

        private ReportExtensionsReportExtension reportExtensionField;

        /// <remarks/>
        public ReportExtensionsReportExtension ReportExtension
        {
            get
            {
                return this.reportExtensionField;
            }
            set
            {
                this.reportExtensionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ReportExtensionsReportExtension
    {

        private byte canSubmitNilReturnField;

        /// <remarks/>
        public byte CanSubmitNilReturn
        {
            get
            {
                return this.canSubmitNilReturnField;
            }
            set
            {
                this.canSubmitNilReturnField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ReportReportData
    {

        private ReportReportDataFinancialInstitutions financialInstitutionsField;

        /// <remarks/>
        public ReportReportDataFinancialInstitutions FinancialInstitutions
        {
            get
            {
                return this.financialInstitutionsField;
            }
            set
            {
                this.financialInstitutionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ReportReportDataFinancialInstitutions
    {

        private ReportReportDataFinancialInstitutionsFinancialInstitution financialInstitutionField;

        /// <remarks/>
        public ReportReportDataFinancialInstitutionsFinancialInstitution FinancialInstitution
        {
            get
            {
                return this.financialInstitutionField;
            }
            set
            {
                this.financialInstitutionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ReportReportDataFinancialInstitutionsFinancialInstitution
    {

        private string idField;

        private string referenceField;

        private string nameField;

        private string classificationField;

        private ReportReportDataFinancialInstitutionsFinancialInstitutionAdresses adressesField;

        private ReportReportDataFinancialInstitutionsFinancialInstitutionIdentificationNumbers identificationNumbersField;

        private string taxResidencyField;

        private ReportReportDataFinancialInstitutionsFinancialInstitutionAccounts accountsField;

        private byte rowField;

        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string Classification
        {
            get
            {
                return this.classificationField;
            }
            set
            {
                this.classificationField = value;
            }
        }

        /// <remarks/>
        public ReportReportDataFinancialInstitutionsFinancialInstitutionAdresses Adresses
        {
            get
            {
                return this.adressesField;
            }
            set
            {
                this.adressesField = value;
            }
        }

        /// <remarks/>
        public ReportReportDataFinancialInstitutionsFinancialInstitutionIdentificationNumbers IdentificationNumbers
        {
            get
            {
                return this.identificationNumbersField;
            }
            set
            {
                this.identificationNumbersField = value;
            }
        }

        /// <remarks/>
        public string TaxResidency
        {
            get
            {
                return this.taxResidencyField;
            }
            set
            {
                this.taxResidencyField = value;
            }
        }

        /// <remarks/>
        public ReportReportDataFinancialInstitutionsFinancialInstitutionAccounts Accounts
        {
            get
            {
                return this.accountsField;
            }
            set
            {
                this.accountsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte row
        {
            get
            {
                return this.rowField;
            }
            set
            {
                this.rowField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ReportReportDataFinancialInstitutionsFinancialInstitutionAdresses
    {

        private ReportReportDataFinancialInstitutionsFinancialInstitutionAdressesAdress adressField;

        /// <remarks/>
        public ReportReportDataFinancialInstitutionsFinancialInstitutionAdressesAdress Adress
        {
            get
            {
                return this.adressField;
            }
            set
            {
                this.adressField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ReportReportDataFinancialInstitutionsFinancialInstitutionAdressesAdress
    {

        private int buildingIdentifierField;

        private string streetNameField;

        private string cityField;

        /// <remarks/>
        public int BuildingIdentifier
        {
            get
            {
                return this.buildingIdentifierField;
            }
            set
            {
                this.buildingIdentifierField = value;
            }
        }

        /// <remarks/>
        public string StreetName
        {
            get
            {
                return this.streetNameField;
            }
            set
            {
                this.streetNameField = value;
            }
        }

        /// <remarks/>
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ReportReportDataFinancialInstitutionsFinancialInstitutionIdentificationNumbers
    {

        private ReportReportDataFinancialInstitutionsFinancialInstitutionIdentificationNumbersIdentificationNumber identificationNumberField;

        /// <remarks/>
        public ReportReportDataFinancialInstitutionsFinancialInstitutionIdentificationNumbersIdentificationNumber IdentificationNumber
        {
            get
            {
                return this.identificationNumberField;
            }
            set
            {
                this.identificationNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ReportReportDataFinancialInstitutionsFinancialInstitutionIdentificationNumbersIdentificationNumber
    {

        private string classificationField;

        private string countryField;

        private string numberField;

        /// <remarks/>
        public string Classification
        {
            get
            {
                return this.classificationField;
            }
            set
            {
                this.classificationField = value;
            }
        }

        /// <remarks/>
        public string Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <remarks/>
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ReportReportDataFinancialInstitutionsFinancialInstitutionAccounts
    {

        private ReportReportDataFinancialInstitutionsFinancialInstitutionAccountsAccount accountField;

        /// <remarks/>
        public ReportReportDataFinancialInstitutionsFinancialInstitutionAccountsAccount Account
        {
            get
            {
                return this.accountField;
            }
            set
            {
                this.accountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ReportReportDataFinancialInstitutionsFinancialInstitutionAccountsAccount
    {

        private string idField;

        private uint numberField;

        private string numberTypeField;

        private string typeField;

        private string statusField;

        private ReportReportDataFinancialInstitutionsFinancialInstitutionAccountsAccountAccountHolders accountHoldersField;

        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public uint Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        public string NumberType
        {
            get
            {
                return this.numberTypeField;
            }
            set
            {
                this.numberTypeField = value;
            }
        }

        /// <remarks/>
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public ReportReportDataFinancialInstitutionsFinancialInstitutionAccountsAccountAccountHolders AccountHolders
        {
            get
            {
                return this.accountHoldersField;
            }
            set
            {
                this.accountHoldersField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ReportReportDataFinancialInstitutionsFinancialInstitutionAccountsAccountAccountHolders
    {

        private ReportReportDataFinancialInstitutionsFinancialInstitutionAccountsAccountAccountHoldersIndividual individualField;

        /// <remarks/>
        public ReportReportDataFinancialInstitutionsFinancialInstitutionAccountsAccountAccountHoldersIndividual Individual
        {
            get
            {
                return this.individualField;
            }
            set
            {
                this.individualField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ReportReportDataFinancialInstitutionsFinancialInstitutionAccountsAccountAccountHoldersIndividual
    {

        private string idField;

        private ReportReportDataFinancialInstitutionsFinancialInstitutionAccountsAccountAccountHoldersIndividualBirdthInfo birdthInfoField;

        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public ReportReportDataFinancialInstitutionsFinancialInstitutionAccountsAccountAccountHoldersIndividualBirdthInfo BirdthInfo
        {
            get
            {
                return this.birdthInfoField;
            }
            set
            {
                this.birdthInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ReportReportDataFinancialInstitutionsFinancialInstitutionAccountsAccountAccountHoldersIndividualBirdthInfo
    {

        private string cityField;

        /// <remarks/>
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }
    }


}
